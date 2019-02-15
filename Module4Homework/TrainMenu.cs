using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4Homework
{
    public class TrainMenu
    {
        public static void TrainServiceMenu()
        { 

            while (true)
            {
                Console.WriteLine("1. Создать поезд");
                Console.WriteLine("2. Посмотреть информацию о поезде");
                Console.WriteLine("0. Выйти");
                int num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        TrainService.CreateTrain();
                        break;
                    //case 2:
                      //  TrainService.InfoAboutTrain(Train train);
                        //break;
                }
            }
        }
    }
}
