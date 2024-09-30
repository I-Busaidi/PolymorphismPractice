namespace ShapesTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose an option:\n\n1. Calculate Square Area.\n2. Calculate Rectangle Area.\n3. Calculate Triangle Area.\n4. Calculate Circle Area.\n\n0. Exit.");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice > 4 || choice < 0)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
                Console.Clear();
                switch(choice)
                {
                    case 0:
                        Console.WriteLine("Exiting the program.\nPress any key to continue...");
                        return;

                    case 1:
                        Console.WriteLine("Enter the Length of the Square Side:");
                        double SideLength;
                        while (!double.TryParse(Console.ReadLine(), out SideLength) || SideLength <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the Length of the Square Side:");
                            Console.WriteLine("Invalid input, please try again.");
                        }
                        Shape s = new Square(SideLength);
                        Console.WriteLine($"The are of the square with side length of {SideLength} is {s.Area()}");
                        break;

                    case 2:
                        double Length;
                        double Width;
                        Console.WriteLine("Enter the Length of the Rectangle:");
                        while (!double.TryParse(Console.ReadLine(), out Length) || Length <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the Length of the Rectangle:");
                            Console.WriteLine("Invalid input, please try again.");
                        }
                        Console.WriteLine("Enter the Width of the Rectangle:");
                        while (!double.TryParse(Console.ReadLine(), out Width) || Width <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the Width of the Rectangle:");
                            Console.WriteLine("Invalid input, please try again.");
                        }
                        Shape r = new Rectangle(Length, Width);
                        Console.WriteLine($"The are of the rectangle is {r.Area()}");
                        break;

                    case 3:
                        Console.WriteLine("Enter the Height of the Triangle:");
                        double Height;
                        while (!double.TryParse(Console.ReadLine(), out Height) || Height <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the Height of the Triangle:");
                            Console.WriteLine("Invalid input, please try again.");
                        }

                        Console.WriteLine("Enter the Base Length of the Triangle:");
                        double Base;
                        while (!double.TryParse(Console.ReadLine(), out Base) || Base <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the Base Length of the Triangle:");
                            Console.WriteLine("Invalid input, please try again.");
                        }
                        Shape t = new Triangle(Base, Height);
                        Console.WriteLine($"The are of the triangle is {t.Area()}");
                        break;

                    case 4:
                        Console.WriteLine("Enter the Length of the raduis ( 1/2 the diameter):");
                        double raduis;
                        while (!double.TryParse(Console.ReadLine(), out raduis) || raduis <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the Length of the raduis ( 1/2 the diameter):");
                            Console.WriteLine("Invalid input, please try again.");
                        }
                        Shape c = new Circle(raduis);
                        Console.WriteLine($"The are of the circle with raduis {raduis} is {c.Area()}");
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

                Console.WriteLine("Press any Key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }

    public class Shape
    {
        protected double Length;
        protected double Width;

        public virtual double Area()
        {
            return 0;
        }
    }

    public class Square : Shape
    {
        public Square(double SideLength)
        {
            Console.WriteLine("Calculating Square Area.");
            Length = SideLength;
        }
        public override double Area()
        {
            return Length*Length;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double Base, double Height)
        {
            Console.WriteLine("Calculating Triangle Area.");
            Length = Height;
            Width = Base;
        }
        public override double Area()
        {
            return Length * Width * 1/2;
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Console.WriteLine("Calculating Circle Area.");
            Length = radius;
        }
        public override double Area()
        {
            return Length * Length * 22 / 7;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double Length, double Width)
        {
            Console.WriteLine("Calculating Rectangle Area.");
            this.Length = Length;
            this.Width = Width;
        }
        public override double Area()
        {
            return Length * Width;
        }
    }
}
