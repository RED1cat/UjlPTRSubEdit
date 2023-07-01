using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

namespace ujl_subedit
{
    static class Program
    {
        [STAThread]
        static void Main(string[] arg)
        {
            using (var cm = new CapturedMutex())
            {
                if (cm.Captured != true && arg.Length == 1)
                {
                    cm.SendMessage(arg[0]);
                    return;
                }
                else if(arg.Length == 1)
                {
                    Editor.m_StartFilePath= arg[0];
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Editor());
            }
        }



        /// <summary>
        /// This class tries to capture app mutex
        /// </summary>
        public class CapturedMutex : IDisposable
        {
            private const int timeout = 1000;
            Mutex mutex;

            /// <summary>
            /// Creates mutex with given unique app Id
            /// </summary>
            public CapturedMutex(string appGuid)
            {
                bool createdNew;
                var allowEveryoneRule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
                var securitySettings = new MutexSecurity();
                securitySettings.AddAccessRule(allowEveryoneRule);

                mutex = new Mutex(false, appGuid, out createdNew, securitySettings);
                try
                {
                    if (!mutex.WaitOne(timeout, false))
                        mutex = null;//we can not capture mutex
                }
                catch (AbandonedMutexException)
                {
                }
            }

            /// <summary>
            /// Creates mutex based on application GUID as defined in AssemblyInfo.cs
            /// </summary>
            public CapturedMutex()
                : this(((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value)
            {
            }

            public void Dispose()
            {
                if (mutex != null)
                    mutex.ReleaseMutex();
            }

            /// <summary>
            /// Mutex captured?
            /// </summary>
            public bool Captured
            {
                get { return mutex != null; }
            }

            public const int HWND_BROADCAST = 0xFFFF;
            public const int WM_COPYDATA = 0x004A;

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern IntPtr LocalAlloc(int flag, int size);

            [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, ref CopyDataStruct lParam);


            public void SendMessage(string message)
            {
                var currentProcess = Process.GetCurrentProcess();

                foreach (var process in Process.GetProcessesByName(currentProcess.ProcessName))
                    if (process.Id != currentProcess.Id)
                    {
                        var handle = process.MainWindowHandle;

                        if (handle == IntPtr.Zero)
                            handle = (IntPtr)HWND_BROADCAST;

                        var cds = new CopyDataStruct();
                        cds.cbData = (message.Length + 1) * 2;
                        cds.lpData = LocalAlloc(0x40, cds.cbData);
                        Marshal.Copy(message.ToCharArray(), 0, cds.lpData, message.Length);
                        cds.dwData = (IntPtr)1;
                        SendMessage(handle, WM_COPYDATA, IntPtr.Zero, ref cds);

                        break;
                    }
            }

            public struct CopyDataStruct : IDisposable
            {
                public const int WM_COPYDATA = 0x004A;
                public IntPtr dwData;
                public int cbData;
                public IntPtr lpData;

                [DllImport("kernel32.dll", SetLastError = true)]
                public static extern IntPtr LocalFree(IntPtr p);

                public void Dispose()
                {
                    if (this.lpData != IntPtr.Zero)
                    {
                        LocalFree(this.lpData);
                        this.lpData = IntPtr.Zero;
                    }
                }
            }
        }
    }
}
