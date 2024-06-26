﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы_и_интерфейсы
{
    //Так же, как и класс, Интерфейс представляет ссылочный тип, который может определять некоторый функционал - набор методов и свойств без реализации (то бишь набор абстрактных членов).
    //Затем этот функционал реализуют классы и структуры, которые применяют данные интерфейсы.
    
    interface IExample //Этичным будет называть интерфейсы через заглавную I
    {
        //Здесь можно определять всё, что относится к классам: абстрактные методы , статические поля/константы и абстрактные свойства.
        //Причем модификаторы доступа не нужны
        //В отличие от абстрактных классов, здесь создаются только абстрактные методы, соответственно конструкторам здесь не место

        //константа
        const int minSpeed = 0;     
          
        //статическое поле
        static int maxSpeed = 60;   
                                    
        void Move();                
                                    
        string Name { get; set; }  

    }

    //Ладно, допустим. Приведем простейший пример взаидействия интерфейсов и классов

    interface IWriter
    {
        void Write_(string url);
    }

    interface IReader
    {
        void Read_(string url);
    }


    class FileClient : IWriter, IReader //Здесь через : "наследуем" интерфейсы (их может быть несколько через запятую)
                                        //Но более этичным будет называть это так: интерфейсы имплементируем, а классы наследуем
                                        //ЛИБО класс реализует интерфейс(ы)
    {
        //Так же как и при абстрактных классах, у нас будет постоянно ошибка, пока мы не определим все содержимое этих интерфейсов
        //Это делается для того, чтобы мы могли уже в основном коде (при создании объекта) иметь уже полноценный интерфейс взаимодействия (то бишь все публичные данные класа)

        public void Write_(string url) //к слову, override уже не требуется
        { 
            //Здесь уже можем прописывать свою логику
        }
        public void Read_(string url)
        {
        }
    }

    //теперь приведем другой класс
    class HttpClient : IWriter, IReader
    {
        public void Write_(string url) 
        { 
            //Теперь здесь применяется совсем иная логика
        }
        public void Read_(string url)
        {
        }
    }
    //Что-то напоминает?
    //Это одна из возможностей реализации полиморфизма подтипов, такой подход называется ещё полиморфизмом через интерфейсы.
    //Как по мне, такой подход более удобен тем, что с тем же методом Greeting() может работать несколько классов и в каждом из них будет своё переопределение этого метода.

    //Во-первых, в задаче с сотрудниками и человеками нам нет нужды создавать абстрактный класс Person, т.к. нам нужен объект и самого человека
    //Во-вторых, интерфейс позволяет нам работать как с родительским классом, так и с производными от него, позволяя нам не создавать основные методы у человека
    //Все основные методы и сами свойства класса человека мы можем засунуть в интерфейс и тем самым сделать код более гибким и управляемым.

    //Теперь смотреть в zLifeExample
}
