using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             # 1
            Console.WriteLine("Введите первое число");
            string FirstNumber = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string SecondNumber = Console.ReadLine();
            Console.WriteLine("Введите третье число");
            string ThirdNumber = Console.ReadLine();
            Console.WriteLine(FirstNumber + "  " + SecondNumber + "  " + ThirdNumber);
            Console.ReadLine();
            */

           /*
            Console.WriteLine("Введите первое число");
            string FirstNumber = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string SecondNumber = Console.ReadLine();
            Console.WriteLine("Введите третье число");
            string ThirdNumber = Console.ReadLine();
            Console.WriteLine(FirstNumber + "\n" + SecondNumber + "\n" + ThirdNumber);
            Console.ReadLine();
            */
        
            
            /*             
            int Num;
            int Ten = 10;
            Console.WriteLine("Введите двузначное число");
            Num = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Число десяток в нем = {0}", Num / Ten); 
            Console.WriteLine("Число единиц в нем = {0}", Num % Ten);
            Console.WriteLine("Сумма его цифр = {0}", Nu % Ten + Num / Ten);
            Console.WriteLine("Произведение его цифр = {0}", Num % Ten * Num / Ten);
            Console.ReadLine();
            */

           /*
            Console.WriteLine("Введите радиус круга");
            string r = Console.ReadLine();
            Console.WriteLine("Введите сторону квадрата");
            string a = Console.ReadLine();

            Double R = Convert.ToDouble(r);
            double Radius = 2 * Math.PI * R;

            int p = Convert.ToInt32(a);
            int S = p * p;
            if(Radius > S)
            {
                Console.WriteLine("Радиус круга больше чем площадь квадрата");
            }
            else
            {
                Console.WriteLine("площадь квадрата больше чем радиус круга");
            }
            Console.ReadLine();
            */

            /*
            Console.WriteLine("Write days");
            string Day = Console.ReadLine();
            int Month = 7;
            int Days = Convert.ToInt32(Day);
            int volume = Days / Month;
            Console.WriteLine("Month = {0}", volume);
            Console.ReadLine();
            */

            
            
            Console.WriteLine("Write Cm");
            string a = Console.ReadLine();
            int M = 100;
            int Cm = Convert.ToInt32(a);
            int volume = Cm / M;
            Console.WriteLine("MK = {0}", volume);
            Console.ReadLine();
          
        }

    }
}
