using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

//Класс является описанием характеристик объекта и поведения (его шаблоном)
//Главным примечанием является то, что: создавая класс или структуру, мы сами создаём свой тип данных (ЭТО ОБЯЗАТЕЛЬНО СТОИТ УЧИТЫВАТЬ)


//с помощью проги можно создавать отдельные исходные файлы отдельно для классов
namespace Классы_и_объекты
{
    class Rectangle //наш класс (или производный наш тип данных, который мы здесь описываем)
    {
        public double width; //поля класса или переменные-члены 
        public double height;
        public double langest_angle;

        public Rectangle(double width, double height) //любой класс имеет конструктор (создается автоматически, если его нет). Он вызывается при создании объекта
        {
            this.width = width; //используем this для обращения к члену класса, разрешая конфликт имен
            this.height = height;
        }

        //конструктор можно перегружать, как и остальные методы

        public Rectangle(double width, double height, double largest_angle) : this(width, height) //наследуемся от продыдущего конструктора
        {
            //представь что ты тут видишь вот это:
            //this.width = height;
            //this.height = largest_angle;
            this.langest_angle = largest_angle;
        }

        public double CalcArea() //метод класса или функции-члены
        {
            return this.width * this.height;
        }
        /*
         * Внутри самого метода: this представляет собой объект, у которого будет вызван данный метод
         * Либо ссылку на текущий экземпляр класса (члены класса), служащей для явного обращения к членам объекта класса. 
         * Оно помогает устранить неоднозначность и указать, что именно используется в текущем контексте.
         */
    }
}
