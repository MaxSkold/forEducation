﻿/*
 * Структуры так же являются частью ООП потому что и там, и там объекты. Но есть очень большие отличия
 * 
 * Структуры (объекты структур) хранятся в стеке, в то время как классы в куче. Соответственно они быстрее, НО
 * структуры используются как производные значимые типы данных, в которых выполняются простые действия над данными, и они не имеют многих возможностей ООП
 */


Rectangle rectangle = new Rectangle(5, 10); //Выделяем место в стеке для данных структуры


Rectangle rectangle1 = rectangle;
//А вот здесь уже интереснее. Поскольку структура - это значимый тип данных, то при копированни данных из одного объекта в другой выделяется новое место в стеке
//К слову примитивы int, float, double и т.д. работают по такому же принципу, т.к. это тоже структуры

Console.WriteLine($"{rectangle.CalcArea()} \t {rectangle1.CalcArea()}");

struct Rectangle
{
    readonly double width; //поля структуры
    readonly double height;

    public Rectangle(double width, double height) //структоры так же имеют конструкторы (создаются автоматически, если их нет)
    {
        this.width = width;
        this.height = height;
    }

    public double CalcArea() => this.width * this.height; //простейшая лямбда (анонимная функция, которая возвращает площадь фигуры)
}

