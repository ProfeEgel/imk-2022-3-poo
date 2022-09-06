using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBasics
{
    class Box
    {
        private int width;
        private int length;
        private int height;

        public int Width
        {
            get => width;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("width");
                }

                this.width = value;
            }
        }

        public int Length
        {
            get => length;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("length");
                }

                this.length = value;
            }
        }

        public int Height
        {
            get => height;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("height");
                }

                this.height = value;
            }
        }

        public int Volume => width * length * height;

        public Box() : this(1) {}

        public Box(int size) : this(size, size, size) {}

        public Box(int width, int length, int height)
        {
            Width = width;
            Length = length;
            Height = height;
        }
    }

    internal class Program
    {
        static List<Box> FilterBoxesByWidth(List<Box> boxes, int width)
        {
            List<Box> filteredBoxes = new List<Box>();

            foreach (Box box in boxes)
            {
                if (box.Width == width)
                {
                    filteredBoxes.Add(box);
                }
            }

            return filteredBoxes;
        }

        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            boxes.Add(new Box());
            boxes.Add(new Box(2));
            boxes.Add(new Box(3, 4, 5));
            boxes.Add(new Box(4));
            boxes.Add(new Box(3));
            boxes.Add(new Box(3, 5, 1));
            boxes.Add(new Box());

            // *****************************
            // funciones lambda

            FilterBoxesByWidth(boxes, 3).ForEach(b =>
                Console.WriteLine($"({b.Width}, {b.Length}, {b.Height})")
            );

            Console.WriteLine();

            boxes.Sort((a, b) => a.Volume.CompareTo(b.Volume));
            FilterBoxesByWidth(boxes, 3).ForEach(b =>
                Console.WriteLine($"({b.Width}, {b.Length}, {b.Height})")
            );

            //foreach (Box box in FilterBoxesByWidth(boxes, 3))
            //{
            //    Console.WriteLine($"({box.Width}, {box.Length}, {box.Height})");
            //}



            // funciones lambda
            // *****************************

            Console.WriteLine();

            int totalVolume = 0;
            for (int i = 0; i < boxes.Count; i++)
            {
                totalVolume += boxes[i].Volume;
            }

            Console.WriteLine($"Volume: {totalVolume}");

            // foreach

            totalVolume = 0;
            foreach (Box box in boxes)
            {
                totalVolume += box.Volume;
            }

            Console.WriteLine($"Volume: {totalVolume}");

            //Box b1 = new Box(3);
            //Console.WriteLine($"Volumen = {b1.Volume}");
            //Console.WriteLine($"Box: ({b1.Width}, {b1.Height}, {b1.Length})");
        }
    }
}
