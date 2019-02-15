using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4Homework
{
    public class Train
    {
        public Train()
        {
            Console.WriteLine("");
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
        }
        private string Name_;
        public string Name
        { get
            {
                return Name_;
            }
            set
            {
                Name_ = value;
            }
        }

        private int KolichestvoVagonov_;
        /// <summary>
        /// количестов вагонов
        /// </summary>
        public int KolichestvoVagonov
        {
            get
            {
                return KolichestvoVagonov_;
            }
            set
            {
                KolichestvoVagonov_ = value;
            }
        }
        private int ObemVagona_;
        /// <summary>
        /// Объем вагона
        /// </summary>
        public int ObemVagona
        {
            get
            {
                return ObemVagona_;
            }
            set
            {
                ObemVagona_ = value;
            }
        }
        private int Speed_;
        /// <summary>
        /// Скорость поезда
        /// </summary>
        public int Speed
        {
            get
            {
                return Speed_;
            }
            set
            {
                Speed_ = value;
            }
        }
        private string Color_;
        /// <summary>
        /// Цвет поезда
        /// </summary>
        public string Color
        {
            get
            {
                return Color_;
            }
            set
            {
                Color_ = value;
            }
        }
    }
}
