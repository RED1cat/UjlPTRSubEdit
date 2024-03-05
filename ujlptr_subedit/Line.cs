using System;

namespace ujlptr_subedit
{
    public class Line
    {
        public int PointerLocation;
        public string Text;
        public string Time;
        public string SwitchingTime;

        public Line(int pointerLocation, byte[] pointer, string text)
        {

            PointerLocation = pointerLocation;
            Text = text;
            if (pointer.Length == 6)
            {
                Time = BitConverter.ToString(pointer, 3, 1).Replace("-", "");
                SwitchingTime = BitConverter.ToString(pointer, 4, 2).Replace("-", "");
            }
        }
    }
}
