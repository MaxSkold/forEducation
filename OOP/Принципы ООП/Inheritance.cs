namespace Принципы_ООП
{
    //Наследование - не менее важная концепция ООП, подразумевающая в прямом смысле наследование характеристик одного класса от другого
    //Живой пример: у нас есть человек с ФИО и возрастом, а так же есть работник с снилсом, инн и паспортными данными
    //Работник будет наследоваться от человека и принимать все его характеристики и поведение

    //теперь на практике
    class Person
    {
        private string _fisrtname = String.Empty; //String.Empty просто возвращает пустую строку во избежание исключения с null
        private string _lastname = String.Empty;
        private int _age;

        public Person(string firstname, string lastname, int age)
        {
            this._fisrtname = firstname;
            this._lastname = lastname;
            this._age = age;
        }

        public string Firstname { 
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
    }

    //Теперь создаём класс, который будет наследоваться от Person. Обозначается наследие через двоеточие
    class Employee : Person
    {
        private string _inn;
        private string _serial_number;
        private string _snils;

        public Employee(string firstname, string lastname, int age, string inn, string serial_number, string snills) : base(firstname, lastname, age) 
        //Через base мы напрямую обращаемся к конструктору базового класса. В base мы передаем параметры, которые мы наследуем от родителя.
        //Эта процедура обязательна, т.к. классы не могут наследовать напрямую конструкторы (если они не по-умолчанию, то бишь не прописываем)
        { 
            //Советую не удивляться с кол-ва параметров, но так и задумано
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
    }

    /* Нюансы по работе с наследованием:
     * 1. Не поддерживается множественное наследование, класс может наследоваться только от одного класса
     * 2. При создании производного класса надо учитывать тип доступа к базовому классу - тип доступа к производному классу должен быть таким же, как и у базового класса, или более строгим. 
     * То есть, если базовый класс у нас имеет тип доступа internal (а это тип по-умолчанию, если мы не указываем тип), 
     * то производный класс может иметь тип доступа internal или private, но не public.
     * 3. ВАЖНО: если класс объявлен с модификатором sealed, то от этого класса нельзя наследовать и создавать производные классы
     */
}
