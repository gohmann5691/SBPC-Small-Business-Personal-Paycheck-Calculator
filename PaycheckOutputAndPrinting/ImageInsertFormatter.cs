using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PaycheckOutputAndPrinting
{
    public class ImageInsertFormatter
    {
        private Bitmap original;
        private Bitmap resized;
        private int newWidth;
        private int newHeight;
        //private string imagePath;
        public ImageInsertFormatter(string imagePath)
        {
            //this.imagePath = imagePathInput;
            //declare resizing variables
            newWidth = 0;
            newHeight = 0;
            // display image in picture box
            try
            {
                original = new Bitmap(imagePath);
            }
            catch (ArgumentException imageNotFound)
            {
                original = DrawFilledRectangle();
            }

        }
        //SOURCE: GITHUB ~ https://stackoverflow.com/questions/12502365/how-to-create-1024x1024-rgb-bitmap-image-of-white
        //Author: Lee Harrison
        //https://stackoverflow.com/users/889034/lee-harrison
        //used to build a default white image to keep the program from breaking
        private Bitmap DrawFilledRectangle(int x = 200, int y = 200)
        {
            Bitmap bmp = new Bitmap(x, y);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, x, y);
                graph.FillRectangle(Brushes.White, ImageSize);
            }
            return bmp;
        }
        public void FormatImage()
        {

            //get image under 200x200 while maintaining aspect ratio
            //scale down the aspect ratio if necessary
            if (original.Width <= 200 && original.Height <= 200)
            {
                newWidth = original.Width;
                newHeight = original.Height;
            }
            else if (original.Width > original.Height)
            {
                double divideWidth = original.Width / 150.00;
                newWidth = (int)(original.Width / divideWidth);
                newHeight = (int)((original.Height * 150.00) / original.Width);
            }
            else if (original.Height > original.Width)
            {
                double divideHeight = original.Height / 150.00;
                newHeight = (int)(original.Height / divideHeight);
                newWidth = (int)((original.Width * 150.00) / original.Height);
            }
            resized = new Bitmap(original, new Size(newWidth, newHeight));
        }
        public Bitmap BitmappedImage
        {
            set { resized = value; }
            get { return resized; }
        }
    }
}
