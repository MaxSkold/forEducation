namespace Принципы_ООП
{
    //Итак, полиморфизм (поли - разная, морф - форма) - это такой принцип ООП,
    //который позволяет одному и тому же фрагменту кода работать с разными типами данных либо работать с разными типами данных, опираясь на обобщенный тип

    //Является основным принципом (фундаментом) ООП и существует благодаря наследованию (тогда как наследование благодаря инкаплсуляции)
    
    //Существует 4 вида п-изма: ad-hoc (специальный или мнимый п-изм), полиморфизм подтипов, параметрический (истинный) п-изм и полиморфизм через интерфейсы.
    //Здесь разберем первые два

    //начну с простого (ad-hoc):
    class Calc
    {
        public string Add(string a, string b) => a + b;
        public int Add(int a, int b) => a + b;
        //Есть два одинаковых метода, которые принимают разные параметры и выполняют общее действие сложения.
        //Но в первом методе происходит конкатенация строк, а во втором - сложение чисел
        //Так в зависимости от параметров, этот код будет работать по-разному

        //Перегрузка методов ЯВЛЯЕТСЯ мнимым полиморфизмом
        //Неявное приведение типов (процесс преобразования экземпляра одного типа данных в экземпляр другого типа данных) тоже относится к ad-hoc полиморфизму

        //В рамках классов это выглядит вот так:
        class Parent { }
        class Child : Parent { }

        // Преобразование дочернего класса к родительскому классу
        static Child child = new Child();
        static Parent parent = child; // неявное приведение

        //Но стоит отметить, что ad-hoc очень мало связан с ООП и его можно использовать в процедурном программировании, так что это только для понимания

    }

    //-------------------------------------------------------------------------------------------------------------

    //Теперь разберемся с полиморфизмом подтипов

    //вернемся к нашим человечкам и сотрудникам, предварительно скопировав классы
    class Person1
    {
        private string _fisrtname = String.Empty;
        private string _lastname = String.Empty;
        private int _age;

        public Person1(string firstname, string lastname, int age)
        {
            this._fisrtname = firstname;
            this._lastname = lastname;
            this._age = age;
        }

        public string Firstname
        {
            get => _fisrtname;
            set => _fisrtname = value;
        }
        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }
        public int Age
        {
            get => _age;
            set
            {
                if (_age < 0) _age = 0;
                else _age = value;
            }
        }

        //добавим метод приветствия в Person1 и сделаем его виртуальным. Здесь я очень советую глянуть вот это видео https://www.youtube.com/watch?v=xH61vpBebjw&pp=ygUZ0L_QvtC70LjQvNC-0YDRhNC40LfQvCBjIw%3D%3D

        public virtual void Greeting() //Проще говоря при наследовании классов virtual позволяет методу быть переопределенным в дочернем классе
                                       //В родительском классе метод Greeting() может выполнять одну логику, а в дочернем совсем другую
        {
            Console.WriteLine($"Привет, я человек и меня зовут {this._fisrtname}"); //здесь приветствуется человек
        }
    }
    class Employee1 : Person1
    {
        private string _inn;
        private string _serial_number;
        private string _snils;

        public Employee1(string firstname, string lastname, int age, string inn, string serial_number, string snills) : base(firstname, lastname, age)
        {
            this._inn = inn;
            this._serial_number = serial_number;
            this._snils = snills;
        }

        public string Inn
        {
            get => _inn;
            set => _inn = value;
        }
        public string SerialNumber
        {
            get => _serial_number;
            set => _serial_number = value;
        }
        public string Snills
        {
            get => _snils;
            set => _snils = value;
        }

        public override void Greeting() //непосредственно здесь мы обращаемся к методу базового класса,
                                        //и с помощью override мы можем переопределить этот метод (изменить форму)
        {
            Console.WriteLine($"Привет, я работник и меня зовут {this.Firstname}"); //здесь приветствуется уже работник
        }
    }

    //добавим класс разработчика
    class Developer1 : Employee1
    {
        private string level = string.Empty;
        private string language = string.Empty;

        public Developer1(string firstname, string lastname, int age, string inn, string serial_number, string snills, string level, string language) : base(firstname, lastname, age, inn, serial_number, snills)
        { //пиздец, почему разработчики не додумались просто сделать технологию с наследованием конструкторов
            this.level = level;
            this.language = language;
        }

        public string Level
        {
            get => level;
            set => level = value;
        }
        public string Language
        {
            get => language;
            set => language = value;
        }

        public override void Greeting() //здесь работает всё также
        {
            Console.WriteLine($"Привет, я разработчик и меня зовут {this.Firstname}");
        }
    }

    /* Полиморфизм подтипов: это тип полиморфизма, который позволяет объектам одного типа использовать методы объектов другого типа, 
     * предоставляя базовый интерфейс для всех производных классов. Это достигается с использованием виртуальных методов и переопределения (override).
     * 
     * 
     * 
     * 
     * 
     * 
     Таким образом, специальный (ad-hoc) полиморфизм связан с перегрузкой функций и приведением типов/классов, 
     При полиморфизме подтипов дочерние классы предоставляют разные реализации метода некоторого базового класса. 
     В отличие от специального полиморфизма, где решение о том, какая реализация вызывается, принимается на этапе компиляции (раннее связывание), 
     в полиморфизме подтипов оно принимается во время выполнения (позднее связывание). 
     Для закрепления советую глянуть, т.к. понятие очень сложное в теории: https://www.youtube.com/watch?v=bkGKQ3pY6kE
     */
}
