using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
            /*int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Console.Write("Понедельник");
                    break;
                case 2:
                    Console.Write("Вторник");
                    break;
                case 3:
                    Console.Write("Среда");
                    break;
                case 4:
                    Console.Write("Четверг");
                    break;
                case 5:
                    Console.Write("Пятница");
                    break;
                case 6:
                    Console.Write("Суббота");
                    break;
                case 7:
                    Console.Write("Воскресенье");
                    break;
                default:
                    Console.Write("ERROR101");
                    break;
            }*/




            //Задача 2. В зависимости от порядкового номера месяца (1, 2, ... , 12) вывести на экран его название (январь, февраль, ... , декабрь).
            /*
            Console.Write("Введите номер месяца:");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Console.Write("Январь");
                    break;
                case 2:
                    Console.Write("Февраль");
                    break;
                case 3:
                    Console.Write("Март");
                    break;
                case 4:
                    Console.Write("Апрель");
                    break;
                case 5:
                    Console.Write("Май");
                    break;
                case 6:
                    Console.Write("Июнь");
                    break;
                case 7:
                    Console.Write("Июль");
                    break;
                case 8:
                    Console.Write("Август");
                    break;
                case 9:
                    Console.Write("Сентябрь");
                    break;
                case 10:
                    Console.Write("Октябрь");
                    break;
                case 11:
                    Console.Write("Ноябрь");
                    break;
                case 12:
                    Console.Write("Декабрь");
                    break;
                default:
                    Console.Write("ERROR101");
                    break;
            */



            //Задача 3. По номеру месяца вывести название времени года.

            /*Console.Write("Введите номера месяцев по порядку:");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Autumn");
                    break;
                default:
                    Console.Write("ERROR101");
                    break;
            }*/


            //Задача 4. Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
            Console.Write("Введите первую букву дисциплины:");
            char value = char.Parse(Console.ReadLine());
            switch (value)
            {
                case 'ф':
                case 'Ф':
                    Console.Write("Физика");
                    break;
                case 'м':
                case 'М':
                    Console.Write("Математика");
                    break;
                case 'и':
                case 'И':
                    Console.Write("История");
                    break;
                case 'г':
                case 'Г':
                    Console.Write("География");
                    break;
                case 'б':
                case 'Б':
                    Console.Write("Биология");
                    break;
                default:
                    Console.Write("Ошибка!");
                    break;
            }

            Console.Read();

        }
    }
}
