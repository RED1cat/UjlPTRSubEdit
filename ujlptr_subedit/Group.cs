using System.Collections.Generic;
using System.ComponentModel;

namespace ujlptr_subedit
{
    public  class Group
    {
        public List<Line> Lines = new List<Line>();
        public int MaxChars = 0;
        public int CurChars = 0;
        public int TextLocation;
        public bool Edit = false;

        public int UpdateCurChars()
        {
            CurChars = 0;
            foreach (Line line in Lines)
            {
                CurChars += line.Text.Replace("\0", "").Length;
            }
            return CurChars;
        }

        public Group(List<int> pointersLocation, List<byte[]> pointers, List<string> texts, int FirstCharAddress, int MaxChars)
        {
            TextLocation = FirstCharAddress;
            this.MaxChars = MaxChars;
            foreach (string text in texts)
            {
                CurChars += text.Replace("\0", "").Length;
            }

            for (int i = 0; i < pointersLocation.Count; i++)
            {
                Lines.Add(new Line(pointersLocation[i], pointers[i], texts[i].Replace("\0", "")));
            }
        }
    }
}
