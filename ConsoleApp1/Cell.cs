using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Cell
    {

        public Cell(Ocean owner)
        {
            _owner = owner;
        }


        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Process(); //точка входа

        public abstract char GetImage(); // получение символа отображения , связанного с наследниками
        // protected - как private + доступ для наследника
        protected Ocean _owner;
    }
}
