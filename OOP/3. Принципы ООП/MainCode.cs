using Принципы_ООП;

//У ООП есть основные три принципа: инкапсуляция, наследование, полиморфизм

#region Инкапсуляция

#region 1-ый способ инкапсуляции (через конструктор)

Rectangle rectangle = new(5, 10); //упрощенная запись без объявления конструктора
                                  //rectangle._width = 3;    - Так делать низя. Значение для поля объекта определяется только в конструкторе один раз за всю программу

Console.WriteLine($"{rectangle.CalcArea()} \t {rectangle.CalcPerimetr()}");

#endregion

#region 2-ый способ инкапсуляции (через свойства)

//Rectangle1 rectangle1 = new();
//rectangle1.Width = 5; //обращаемся напрямую к свойствам Wight и Height (срабатывает set)
//rectangle1.Height = 10;

//Console.WriteLine($"\nWidth: {rectangle1.Width}\nHeight: {rectangle1.Height}\n"); //Выведем значения наших полей через свойсвта (срабатывает get)
//Console.WriteLine($"Area: {rectangle1.CalcArea()}\nPerimetr: {rectangle1.CalcPerimetr()}");

#endregion

#region Конкретный пример (для закрепления)

//var user1 = new User("Макс", "Lolololo");

////Получим данные пользователя, включая ID
//Console.WriteLine($"Username: {user1.Username}\nPassword: {user1.Password}\nID: {user1.ID}");

////Здесь же мы можем изменять данные пользователя, кроме ID.
//user1.Username = "Гойда";
//user1.Password = "qwerty";

//Console.WriteLine($"\nUsername: {user1.Username}\nPassword: {user1.Password}\nID: {user1.ID}");

//var user2 = new User("Димасик", "аоаоаоаоа");
//Console.WriteLine($"\nUsername: {user2.Username}\nPassword: {user2.Password}\nID: {user2.ID}");

#endregion

#endregion

#region Наследование 

////Попробуем создать сначала человека, а затем и нашего сотрудника
//var person1 = new Person("Райан", "Гослингович", 18);

//var employee1 = new Employee("Райан", "Гослингович", 18, "бимбимбамбам", "бимбимбамбам", "бимбимбамбам");

////Теперь выведем наши данные
//Console.WriteLine($"Данные сотрудника:\n" +
//                  $"Имя:           {employee1.Firstname}\n" +
//                  $"Фамилия:       {employee1.Lastname}\n" +
//                  $"Возраст:       {employee1.Age}\n" +
//                  $"ИНН:           {employee1.Inn}\n" +
//                  $"Серия и номер: {employee1.SerialNumber}\n" +
//                  $"СНИЛС:         {employee1.Snills}");


#endregion

#region Полиморфизм
//советую раскомментировать

////После создания объектов будет доступен общий метод Greeting(), унаследованный от Person1
//var person1 = new Person1("Макс", "Кринжаловский", 19);
//var employee1 = new Employee1("Райан", "Гослингович", 2342, "234234", "2344", "234234");
//var developer1 = new Developer1("Дима", "Панковский", 18, "бимбимбамбам", "бимбимбамбам", "бимбимбамбам", "СЕНЬОР", "СКРЭТЧ");

////Далее попробуем вывести приветствия наших людей

////person1.Greeting(); //можно либо так
////employee1.Greeting();
////developer1.Greeting();


////А можно сделать разовое приветствие с помощью перебора объектов в массиве
////Создаем массив типа Person1 (список наших людей) 
//Person1[] personlist = new Person1[] { person1, employee1, developer1 };

//static void MassGreeting(Person1[] personlist)
//{
//    foreach (Person1 person in personlist) 
//    {
//        person.Greeting();
//    }
//}


//MassGreeting(personlist);

#endregion

