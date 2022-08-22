using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class Box
    {
        //member Vaiable
        int _length;
        int _height;
        //public int width;
       

        // Short cut of declaring the getter and setter method
        public int Width { get; set; } 
        public int Lenght
        {
            get { return _length; }
            set { _length = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public Box(int length,int height,int width)
        {
            _length = length;
            _height = height;
            Width = width;

        }
        public void Display()
        {
            Console.WriteLine("Length is {0} and Height is {1} and width is {2}", 
                _length, _height, Width);
        }
        public int FrontSurface
        {
            get { return _height * _length; }
        }
        public int Volume
        {
            get { return _length * _height * Width; }
        }
    }

    class PropertiesDriverClass
    {
        static void Main(string[] args)
        {
            Box box = new Box(2, 4, 6);
            //Console.WriteLine("Box s Height is " + box.Height);
            //Console.WriteLine("Box s width is " + box.Width);
            Console.WriteLine("FrontSurface of the box is {0} ",box.FrontSurface);
            Console.WriteLine("Volume of Box is : {0}",box.Volume);
            box.Display();
            
            Console.ReadLine();
        }
    }
}
