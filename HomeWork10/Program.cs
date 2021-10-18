using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesToRadians
{
    // Перевод угла в радианы.
    class UnitsConvertion
    {
        int degr1;
        int min1;
        int sec1;
        public UnitsConvertion(int degr2, int min2, int sec2)
        {
            Degrees = degr2;
            Min = min2;
            Sec = sec2;
        }
        public int Degrees
        {
            get
            {
                return degr1;
            }
            set
            {
                if (value >= 0 && value <= 360)
                {
                    degr1 = value;
                }
                else
                {
                    Console.WriteLine("Введенное значение для градусов не соотвествует допустимому диапазону значений (0 - 360)");
                    degr1 = -1;
                }
            }
        }
        public int Min
        {
            get
            {
                return min1;
            }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min1 = value;
                }
                else
                {
                    Console.WriteLine("Введенное значение для минут не соотвествует допустимому диапазону значений (0 - 60)");
                    min1 = -1;
                }
            }
        }
        public int Sec
        {
            get
            {
                return sec1;
            }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec1 = value;
                }
                else
                {
                    Console.WriteLine("Введенное значение для секунд не соотвествует допустимому диапазону значений (0 - 60)");
                    sec1 = -1;
                }
            }
        }
        public void ToRadians()
        {
            double radians = (double)((Math.PI / 180) * (Degrees + (Min / 60) + (Sec / 3600)));
            if ((Degrees != -1) && (Min != -1) && (Sec != -1) && ((Degrees + (Min / 60) + (Sec / 3600)) <= 360))
            {
                Console.WriteLine("Значение угла в радианах после перевода значений из градусов, минут, секунд = {0:f2}", radians);
            }
            else if ((Degrees + (Min / 60) + (Sec / 3600)) > 360)
            {
                Console.WriteLine("Введенное суммарное значение для градусов, минут, секунд не соотвествует" +
                    " допустимому диапазону значений (0 - 360)");
                Console.WriteLine("Значение угла в радианах не может быть выведено");
            }
            else
            {
                Console.WriteLine("Значение угла в радианах не может быть выведено");
            }

        }
    }
    class FromGradesToRadians
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение угла в градусах, минутах, секундах");
            Console.WriteLine("Введите значение градусов");
            int degrees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение минут");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение секунд");
            int seconds = Convert.ToInt32(Console.ReadLine());
            UnitsConvertion Convertion = new UnitsConvertion(degrees, minutes, seconds);
            Convertion.ToRadians();

            Console.ReadKey();
        }

    }
}



