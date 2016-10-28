using System;

namespace HomeworkVariables
{
    public class Size
    {
        private double width, height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width can't be less than zero!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height can't be less than zero!");
                }
                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size initialSize, double rotationAngle)
        {
            double width = Math.Abs(Math.Cos(rotationAngle)) * initialSize.Width +
                           Math.Abs(Math.Sin(rotationAngle)) * initialSize.Height;

            double height = Math.Abs(Math.Sin(rotationAngle)) * initialSize.Width +
                            Math.Abs(Math.Cos(rotationAngle)) * initialSize.Height;

            var newSize = new Size(width, height);
            return newSize;
        }
    }
}
