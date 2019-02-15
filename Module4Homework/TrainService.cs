using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4Homework
{
    class TrainService
    { 
        public TrainService() { }
        /// <summary>
        /// выводит информацию о поезде
        /// </summary>
        /// <param name="train"></param>
        public void InfoAboutTrain(Train train)
        {
            Console.WriteLine
                ("Назвнаие: {0}\nЦвет: {1}\nКоличество вагонов: {2}\nОбъем вагона: {3}\nСкорость вагона: {4}", train.Name,train.Color, train.KolichestvoVagonov, train.ObemVagona, train.Speed);
        }
        /// <summary>
        /// создаем поезд
        /// </summary>
        /// <param name="train"></param>
        public static void CreateTrain()
        {
            Console.Write("Укажите желаемое кол-во поездов: ");
            int num = Int32.Parse(Console.ReadLine());
            List<Train> train = new List<Train>();
            Console.WriteLine("\n---------------------------------------\n");

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("({0} Поезд)", i+1);
                Train t = new Train();
                Console.Write("Введите название поезда: ");
                t.Name = (Console.ReadLine());
                Console.Write("Введите цвет поезда: ");
                t.Color = (Console.ReadLine());
                Console.Write("Введите кол-во вагонов: ");
                t.KolichestvoVagonov = Int32.Parse(Console.ReadLine());
                Console.Write("Введите объем одного вагона: ");
                t.ObemVagona = Int32.Parse(Console.ReadLine());
                Console.Write("Введите скорость вагона(м/c): ");
                t.Speed = Int32.Parse(Console.ReadLine());
                train.Add(t);
                Console.WriteLine("\n---------------------------------------\n");
            }
        }

      
    }
}
