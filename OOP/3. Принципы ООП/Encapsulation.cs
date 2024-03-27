namespace Принципы_ООП
{
    //Инкапсуляция - это принцип ООП, суть которого заключается в том,
    //что класс - это капсула, которая содержит все свойства и методы класса. Она позволяет их объединять в один класс.
    //Вместе с инкапсуляцией всегда есть свойство сокрытия данных. То есть в классе могут быть поля/свойства и методы, доступ к которым ограничен извне класса. 
    //Это делается с помощью модификаторов доступа: public, private и других модификаторов. См. сюда https://metanit.com/sharp/tutorial/3.2.php

    //весь основной код в MainCode
    /// <summary>
    /// Пример 1
    /// </summary>
    class Rectangle
    {
        private double _width; //с помощью private мы отрубаем связь со внешним миром и поля доступны только в рамках класса
        private double _height;

        //у нас есть два способа задать значения полям: либо через конструкторы, либо через свойства (это отдельная тема)
        public Rectangle(double width, double height) 
        { 
            this._width = width;
            this._height = height; 
        }

        public double CalcArea()
        {
            return _width * _height;
        }
        public double CalcPerimetr() 
        { 
            return (_width + _height) * 2;
        }

    }
    /// <summary>
    /// Пример 2
    /// </summary>
    class Rectangle1
    {
        private double _width; 
        private double _height;

        
        //способ через сет и гет, но тогда уж глянь про свойства для понимания
        public double Width
        {
            get 
            { 
                return _width; 
            }
            set 
            { 
                if (value <= 0)
                    _width = 1;
                else 
                    _width = value; 
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value <= 0)
                    _height = 1;
                else
                    _height = value;
            }
        }


        public double CalcArea() => _width * _height;
        public double CalcPerimetr() => (_width + _height) * 2;

    }
    /// <summary>
    /// Конкретный пример
    /// </summary>
    class User
    {
        private string _username = String.Empty;
        private string _password = String.Empty;
        private static int _id;

        public User(string username, string password)
        {
            this._username = username;
            this._password = password;
            _id = Interlocked.Increment(ref _id); //просто по факту возвращает значение увеличенное на единицу
        }

        public string Username
        {
            get => _username; //Упрощенная запись. => используется вместо return, если у нас используется одна инструкция
            set => _username = value; //Либо просто для упрощения без return
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }
        public int ID
        {
            get => _id;
        }
    }
}
