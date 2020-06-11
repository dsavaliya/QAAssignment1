using System;

namespace QAAssignment1
{
    public class Program
    {
        public static void OptionBook()
        {
            Console.WriteLine("Choose suitable option :- ");
            Console.WriteLine("========================================");

            Console.WriteLine("1. Get Rectangle's length");
            Console.WriteLine("2. Set Rectangle's length");
            Console.WriteLine("3. Get Rectangle's width");
            Console.WriteLine("4. Set Rectangle's width");
            Console.WriteLine("5. Get Rectangle's perimeter");
            Console.WriteLine("6. Get Rectangle's area");
            Console.WriteLine("=====================");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=====================");
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            int selectedOption;

            do
            {
                int length = 0;
                Console.WriteLine("Enter Length:");
                if (!Int32.TryParse(Console.ReadLine(), out length) || length <= 0)
                {
                    Console.WriteLine("Enter Valid Length");
                    continue;
                }
                else
                {
                    rect.Length = length;
                    break;
                }
            } while (true);
            do
            {
                int width = 0;
                Console.WriteLine("Enter Width:");
                if (!Int32.TryParse(Console.ReadLine(), out width) || width <= 0)
                {
                    Console.WriteLine("Enter Valid Width");
                    continue;
                }
                else
                {
                    rect.Width = width;
                    break;
                }
            } while (true);

            do
            {
                try
                {
                    OptionBook();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                }
                selectedOption = int.Parse(Console.ReadLine());

                switch (selectedOption)
                {
                    case 0:

                        Environment.Exit(0);

                        break;

                    case 1:

                        int length = rect.GetLength();
                        Console.WriteLine("\n\nLength = {0}", length);

                        break;

                    case 2:

                        int newLength;
                        Console.WriteLine("Current Length");
                        newLength = int.Parse(Console.ReadLine());
                        rect.Length = newLength;

                        if (newLength > 0)
                        {
                            int finalLength = rect.SetLength(newLength);
                        }
                        else
                        {
                            Console.WriteLine("Enter valid input");
                        }
                        break;

                    case 3:

                        int width = rect.GetWidth();
                        Console.WriteLine("\n\nWidth = {0}", width);
                        break;

                    case 4:

                        int newWidth;
                        Console.WriteLine("Current Width");
                        newWidth = int.Parse(Console.ReadLine());
                        rect.Width = newWidth;

                        if (newWidth > 0)
                        {
                            int finalWidth = rect.SetWidth(newWidth);
                        }
                        else
                        {
                            Console.WriteLine("Enter valid input");
                        }
                        break;

                    case 5:

                        int finalPerimeter = rect.Getperimeter();
                        Console.WriteLine("\n\nPerimeter = {0}", finalPerimeter);
                        break;

                    case 6:

                        int finalArea = rect.GetArea();
                        Console.WriteLine("\n\nArea = {0}", finalArea);
                        break;

                    default:

                        Console.WriteLine("Enter valid input");
                        break;
                }

                Console.WriteLine();
            } while (true);
        }
    }
}
