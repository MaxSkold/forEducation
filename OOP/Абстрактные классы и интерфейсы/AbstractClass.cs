using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы_и_интерфейсы
{
    //Разумеется для реализации абстрактного класса используется спецификатор abstract 
    abstract class Human 
    {
        private readonly string _name = string.Empty;
        private readonly int _age;

        //несмотря на то, что объекты абстрактных классов нельзя создать, они могут иметь конструкторы для прописания какого-то общего шаблона
        public Human(string name, int age)
        {
            _name = name;
            _age = age;
        }

        //Когда мы создаём абстрактные методы и свойства, мы явно указываем на то, что они будут реализовываться только в дочерних классах
        public abstract string Name { get; set; } //По логике важно, чтобы эти свойства и методы не имели private
        public abstract int Age { get; set; }
        public abstract void Mes();



    }

    class Monkey : Human
    {
        string _name = string.Empty;
        int _age;

        public Monkey(string name, int age) : base(name, age) //Здесь мы так же можем наследовать конструктор абстрактного класса
        { 
        }

        //Название наследованного класса Petya будет гореть красным до сих пор, пока мы не обозначим все абстрактные члены родительского класса
        //Для того, чтобы реализовывать абстрактные члены, мы по факту как и при полиморфизме используем override 

        public override void Mes() => Console.WriteLine("Ку ёпта");
        //Во-первых, здесь мы наследуемся от абстрактного метода. Во-вторых, с помощью override мы добавляем свою логику к методу (переопределеяем)

        public override int Age 
        {
            get => _age;
            set => _age = value;
        }
        public override string Name
        {
            get => _name;
            set => _name = value;
        }

    }
}



//Более конкретный пример
abstract class Shape //Фигура
{
    public abstract double GetPerimeter();
    public abstract double GetArea();
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    // переопределение получения периметра
    public override double GetPerimeter() => Width * 2 + Height * 2;
    // переопрелеление получения площади
    public override double GetArea() => Width * Height;

}

class Circle : Shape
{
    public double Radius { get; set; }

    // переопределение получения периметра
    public override double GetPerimeter() => Radius * 2 * Math.PI;
    // переопрелеление получения площади
    public override double GetArea() => Radius * Radius * Math.PI;

}
