using System;
namespace QAAssignment1
{
    public class Rectangle
    {
        private int length;
        private int width;

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public Rectangle()
        {
            Width = 1;
            Length = 1;
        }

        public Rectangle(int Length1, int Width)
        {
            this.Length = length;
            this.Width = width;
        }

        public int GetLength()
        {
            return this.Length;
        }

        public int SetLength(int l)
        {
            this.Length = l;
            return this.Length;

        }

        public int GetWidth()
        {
            return this.Width;

        }

        public int SetWidth(int w)
        {
            this.Width = w;
            return this.Width;
        }

        public int Getperimeter()
        {
            int perimeter = 2 * (this.Length + this.Width);
            return perimeter;
        }

        public int GetArea()
        {
            int area = this.Length * this.Width;
            return area;
        }
    }
}
