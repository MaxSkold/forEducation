using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы_и_интерфейсы
{
    //Чтож, если ты добрался до этого файла и не прогорел как я, то ты сигма
    //Для закрепления очень хочу поделиться примером, который расставит всё на вся и покажет всю силу интерфейсов

    //Итак, у нас есть задача реализовать работу ракеты через всё, что мы знаем. Это немного похоже на задачу с машиной, но тут всё детальнее

    class Rocket //сама ракета... типа
    {
        public RocketHeader Header = new RocketHeader(); //создаём головку
        public IEngine Engine { get; set; } //двигатель

        public int Weight // общая масса всей ракеты
        {
            get => Header.GetWeight() + Engine.Weight; 
        }

    }

    class RocketHeader //головная часть
    {
        public int Cosmonauts { get; private set; } //Количество космонавтов на борту
        public int MassShell { get; private set; } //Масса нашей головки

        public RocketHeader() 
        {
            Cosmonauts = 3;
            MassShell = 5000;
        }

        public int GetWeight() //общая масса, учитывая и головку и людей
        {
            return (Cosmonauts * 80) + MassShell;
        }

        public void Message(string message) //позволим космонантам отправлять сообщения
        {
            Console.WriteLine("Сообщение:");
            Console.WriteLine(message);
            Console.WriteLine("===Отправлено");
        }

    }

    interface IEngine //двигатель, который будет общим для ВСЕХ ракет
    {
        void Start();
        void Stop();
        int Weight { get; } //вес двигателя
        int Power { get; } //его мощность 
    }

    class HatersEngine : IEngine //конкретный двигатель
    {
        public int Weight { get; set; }
        public int Power { get; set; }

        public HatersEngine()
        {
            Weight = 322;
            Power = 228; //хз в чём измерять мощность, но пусть будет так
        }

        public void Start()
        {
            Console.WriteLine("Ракета была запущена...");
        }
        public void Stop()
        {
            Console.WriteLine("Вброс годного контента... Пуканы остывают");
        }


    }
    //если тут всё понятно, см. в Program и раскрой главную вишенку на торте

    //если всё объясняется вот здесь  https://www.youtube.com/watch?v=fu13d1V73K4&t=229s и там дополнительные возможности
}
