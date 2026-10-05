using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;

    namespace Lab1_Task9
    {
        class Program
        {
            static void Main(string[] args)
            {
                Rectangle rect = new Rectangle();

                rect.height = 2;// высота
                rect.width = 3;// ширина

                rect.Show();

                double p = rect.Perimetr();
                Console.WriteLine("Периметр прямоугольника = " + p);

                Console.ReadKey();
            }
        }

        class Rectangle
        {
            // Открытые поля для хранения данных о высоте и ширине
            public double height;
            public double width;

            // Метод - показать на экране данные о прямоугольнике
            public void Show()
            {
                Console.WriteLine("Прямоугольник:");
                Console.WriteLine("  высота = " + height);
                Console.WriteLine("  ширина = " + width);
            }

            // Метод Perimetr() - рассчитывает и возвращает значение периметра
            // Формула: 2 * высота + 2 * ширина
            public double Perimetr()
            {
                double result = 2 * height + 2 * width;
                return result;
            }
        }
    }
}
