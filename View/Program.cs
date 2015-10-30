using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cat = new Cats
            {

            };
            bool x = true;

            Console.WriteLine("Нажмите 1, если хотите купить кота");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Сколько лет вашему коту?");
                cat.Age = Convert.ToInt32(Console.ReadLine());
                do
                {
                    int select = 0;
                    Console.WriteLine($"Привет, меня зовут {cat.Name} и мне {cat.Age} лет, мой цвет - {cat.CurrentColor}");
                    Console.WriteLine("\n1.Задать имя\n2.Покормить\n3.Ударить\n4.Выйти");
                    select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("Введите имя");
                            cat.Name = Console.ReadLine();
                            break;
                        case 2:
                            cat.Feed();
                            Console.WriteLine($"Вы покормили {cat.Name}a");
                            break;
                        case 3:
                            cat.Punish();
                            Console.WriteLine($"Вы наказали кота {cat.Name}a");
                            break;
                        case 4:
                            x = false;
                            break;
                        default:
                            Console.WriteLine("Неверный пункт меню");
                            break;
                    }
                } while (x);
            }
        }
    }
}
