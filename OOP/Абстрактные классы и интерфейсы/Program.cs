//Итак, интерфейсы и абстрактные классы. Ну чтож, поехали

//В общем, интерфейсы - это своего рода контейнеры, в котором хранятся свойства, поля и методы (но без реализации) ДЛЯ каких-то классов
//То есть интерфейсы не позволяют создавать объекты на их основе и нужны исключительно для классов

//Абстрактные классы же похожи на интерфейсы за тем исключением, что в методах абстраткного класса можно прописывать собственную логику,
//но также они допускают создание абстрактных методов, в которых нет реализации, как в интерфейсах
//Что и интерфейсы, абстрактные классы не допускают создания объектов где-либо (это важно). В основном, они нужны как шаблон для других шаблонов (классов)

//Теперь по порядку. Рассмотрим абстрактные классы. Смотреть в AbstractClass

using Абстрактные_классы_и_интерфейсы;

#region Абстрактные классы
//пример 1

//Можно либо так
Human human = new Monkey("Петя", 10) { Name = "Петя", Age = 10 };
human.Mes();
//Либо так
Monkey monkey = new Monkey("Лёха", 5) { Name = "Лёха", Age = 5};
monkey.Mes();

//Но так низя => Human human = new Human();

//пример 2 

Shape rectangle = new Rectangle { Width = 20, Height = 20 };
Shape circle = new Circle { Radius = 20 };
PrintShape(rectangle); 
PrintShape(circle); 

void PrintShape(Shape shape)
{
    Console.WriteLine($"Perimeter: {Math.Round(shape.GetPerimeter(), 2)}  Area: {Math.Round(shape.GetArea(), 2)}");
}

#endregion

//К слову, классы и интерфейсы можно создавать как отдельные элементы проекта с помощью проги. Думаю там понятно будет. Смотреть Interfaces
#region Интерфейсы

#region Важная вишенка на конец
//советую раскоментировать

//int SpecialNasaMethod(int power, int mass) //метод рассчитания максимальной скорости 
//{
//    return (mass / power * 10) + 82;
//}

//Rocket rocket = new Rocket(); //создаём ракету 

//rocket.Header = new RocketHeader(); //создаём головку
//rocket.Engine = new HatersEngine(); //присоединяем движок собственного производства 

//int result = SpecialNasaMethod(rocket.Engine.Power, rocket.Weight);
//Console.WriteLine("Максимальная скорость: " + result);

//if (result > 200)
//    rocket.Engine.Start();
//else
//    Console.WriteLine("Сорямба, движок не вывозит, несите новый");


#endregion

#endregion