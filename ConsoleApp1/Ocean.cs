using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Ocean
    {
        public Ocean(int widht, int height)


        {
            // new Ceel
            _cells = new Cell[height, widht];
        }

        public bool Add(Cell newCell)
        {
            if (_cells[newCell.Y, newCell.X] != null)
            {
                return false; //Ячейка занята
            }
            _cells[newCell.Y, newCell.X] = newCell;

            return true;
        }

        public void RunStep()
        {
            //Call
            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                // Cell
                for (int j = 0; j < _cells.GetLength(1); j++)
                {
                    if(_cells[i, j] != null) //Активирование деятельности наследия Cell
                       {
                        _cells[i, j].Process();
                       }
                }
            }
        }


                public int Widht
                {
                   get
                   {
                        return _cells.GetLength(1);
                    }
                 }


                public int Height
                {
                    get
                      {
                         return _cells.GetLength(0);
                       }
                 }


        /// <summary>
        public bool Move(Cell c, int y, int x )
            {
                if (_cells[y, x] != null)
                        {
                            return false;
                        }
                _cells[y, x] = c;       // переместили объект в новую позицию
                _cells[c.Y, c.X] = null;  // старую позицию освободили

                return true;

            }


        /// отображение игрового поля


        public void Draw()
        {
            //Call
            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                // Cell
                for (int j = 0; j < _cells.GetLength(1); j++)
                {

                    if (_cells[i, j] != null)
                    {
                        Console.Write(_cells[i, j].GetImage());
                    }
                    else
                    {
                        Console.Write(' ');     //Вывод пустой ячейки
                    }

                }
                Console.WriteLine();
                }

        }
        
        private Cell[,] _cells = null;
    }
}
