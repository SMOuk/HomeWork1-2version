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
                    Console.WriteLine($"\nПривет, меня зовут {cat.Name} и мне {cat.Age} лет, мой цвет - {cat.CurrentColor}");
                    Console.WriteLine("\n1.Задать имя\n2.Покормить\n3.Ударить\n4.Поменять цвет здоровой и больной кошки\n5.Выйти");
                    select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            if (cat.Name == "NoName")
                            {
                                Console.WriteLine("Введите имя");
                                cat.Name = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Имя можно задавать только 1 раз!");
                            }
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
                            Console.WriteLine("Введите цвет здоровой кошки:");
                            CatColor.HealthyColor = Console.ReadLine();
                            Console.WriteLine("Введите цвет больной кошки:");
                            CatColor.SickColor = Console.ReadLine();
                            break;
                        case 5:
                            x = false;
                            break;
                        default:
                            Console.WriteLine("Неверный пункт меню");
                            break;
                    }
                    Console.WriteLine("Нажмите Enter для подтверждения!");
                    Console.ReadKey();
                    Console.Clear();
                } while (x);
            }
        }
    }
}
