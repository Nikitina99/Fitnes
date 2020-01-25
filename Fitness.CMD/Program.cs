
using System;
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

            Console.WriteLine("Введите Ваш пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите Вашу дату рождения");
            var birthDay =DateTime.Parse( Console.ReadLine());//Переписать

            Console.WriteLine("Введите Ваш вес");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ваш рост");
            var height =double.Parse( Console.ReadLine());

            var userController = new UserController(
                name,
                gender,
                birthDay,
                weight,
                height);
            userController.Save();
        }
    }
}
