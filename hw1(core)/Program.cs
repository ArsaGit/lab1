//Арсаланов А.И ПрИ-101
using System;

namespace hw1_core_
{
    class Program
    {
        static void Main(string[] args)
        {
            int b_day, b_month, b_year,age;
            string name;
            //приветствие и введение имени
            Console.WriteLine("Привет!");
            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();
            //ввод даты рождения
            Console.WriteLine("Введите вашу дату рождения: ");
            Console.WriteLine("День: ");
            b_day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            b_month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Год: ");
            b_year = Convert.ToInt32(Console.ReadLine());

            //получение текущей даты
            DateTime current_date = DateTime.Now;   
            int c_day, c_month, c_year;
            c_day = current_date.Day;       //c_day = DateTime.Now.Day; 
            c_month = current_date.Month;   //c_month = DateTime.Now.Month;
            c_year = current_date.Year;     //c_year = DateTime.Now.Year;
            //альтернативный способ
            /*
            Console.WriteLine("Введите текущую дату: ");
            Console.WriteLine("День: ");
            c_day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            c_month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Год: ");
            c_year = Convert.ToInt32(Console.ReadLine());
            */

            //проверка на високосный год
            int DinM = 31;      //кол-во дней в месяце
            if(b_year % 4!=0)
            {
                //обычный
                if(b_month == 2) DinM = 28;
                else DinM = 30 + (b_month + b_month / 8) % 2;
            }
            else
            {
                if(b_year % 100!=0)
                {
                    //високосный
                    if (b_month == 2) DinM = 29;
                    else DinM = 30 + (b_month + b_month / 8) % 2;

                }
                else
                {
                    if(b_year % 400==0)
                    {
                        //високосный
                        if (b_month == 2) DinM = 29;
                        else DinM = 30 + (b_month + b_month / 8) % 2;
                    }
                    else
                    {
                        //обычный
                        if (b_month == 2) DinM = 28;
                        else DinM = 30 + (b_month + b_month / 8) % 2;
                    }
                }
            }

            //вычисление возраста
            if (((b_year >= 1900) && (b_year < c_year) && (b_month > 0) && (b_month <= 12) && (b_day > 0) && (b_day <= DinM)) || ((b_year == c_year) && (((b_month < c_month) && (b_day > 0) && (b_day <= DinM)) || ((b_month == c_month) && (b_day <= c_day)))))
            {
                if(b_month<c_month)
                {
                    age = c_year - b_year;
                }
                else if (b_month == c_month) 
                {
                    if (b_day <= c_day) age = c_year - b_year;
                    else age = c_year - b_year-1;
                }
                else age = c_year - b_year - 1;

                Console.WriteLine("Привет " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
            }
            else Console.WriteLine("Введены неверные данные!");

        }
    }
}