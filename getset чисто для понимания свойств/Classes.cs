using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    /// <summary>
    /// Установка значений и их получение через обычные методы
    /// </summary>
    class UsualMethods(string name, int age) //здесь класс объявлен с первичным конструктором (для удобства)
    {
        readonly string name = name;
        readonly int age = age;

        public int GetAge() => age;
        public string GetName() => name;
    }

    /// <summary>
    /// Через свойства (методы доступа). 
    /// Они обеспечивают простой доступ к полям классов и структур, узнать их значение или выполнить их установку.
    /// </summary>
    class GetSet
    {
        string name = "";
        int age;

        public string Name
        {
            get //get и set (сеттеры/геттеры, они же акссесоры) - полное определение свойства. 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
    }

    /// <summary>
    /// Упрощенный способ использования свойства (автоматическое свойство)
    /// </summary>
    class GetSetALT
    {
        public required string Name { get; set; }
        public int Age { get; set; }
    }
}
