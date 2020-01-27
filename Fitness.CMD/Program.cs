﻿using System;
using Fitness.BL.Controller;

namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в приложение Fitness");
            Console.WriteLine("Введите Ваше имя");
            var name = Console.ReadLine();

            var userController = new UserController(name);
            if (userController.IsNewUser)
            {
                Console.Write("Введите пол: ");
                var gender = Console.ReadLine();
                var birthDate= ParseDateTime();;
                var weight= ParseDouble("вес");
                var height= ParseDouble("рост");

                userController.SetNewUserData(gender,birthDate, weight,height);

            }
            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();

        }

        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
                {
                    Console.Write("Введите дату рождения(dd.mm.yyyy): ");
                    if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат даты");
                    }
                }
            return birthDate;
        }

        private static double ParseDouble(string name)
        {
            while (true)
                {
                    Console.Write($"Введите {name}: ");
                    if (double.TryParse(Console.ReadLine(), out double value))
                    {
                    return value;                       
                    }
                    else
                    {
                        Console.WriteLine($"Неверный формат {name}");
                    }
                }

        }
    }
    
}
