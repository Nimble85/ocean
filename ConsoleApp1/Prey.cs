﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Prey :Cell
    {
        public const char PRAY_IMAGE = 'F';

        public Prey(Ocean owner)
                :base (owner)
        {

        }

        public override void Process()

   
        {
          Move();
        }

        public virtual void Move()
        {
            Direction rndDirect = OceanRandomizer.GetRandomDirection();
            // сохранили текущие координаты
            int newXCoord = X;
            int newYCoord = Y;
            // получили координаты в указагном напрвлении
            GetNewPosition(rndDirect, ref newXCoord, ref newYCoord);
            // изменили ссылку во владельце
            _owner.Move(this, newXCoord, newYCoord);
            // bpvtybkb cdjb rjhlbyfns yf yjdst
            X = newXCoord;
            Y = newYCoord;
        }
        
        private void GetNewPosition(Direction rndDirect, ref int newXCoord, ref int newYCoord) //// ----
        {//weight - do not find
            switch (rndDirect)
            {
                case Direction.Up:
                    if (newYCoord > 0)
                    {
                        newYCoord--;
                    }
                    break;
                case Direction.Left:
                    if (newXCoord > 0)
                    {
                        newXCoord--;
                    }
                    break;
                case Direction.Right:
                    if (newXCoord < _owner.Widht -1)
                    {
                        newXCoord++;
                    }

                    break;

                case Direction.Down:

                    if (newYCoord < _owner.Height - 1)
                    {
                        newYCoord++;
                    }
                    break;

                case Direction.NoDirection:
                     break;
                default:
                    break;
            }


           
            }


        public override char GetImage()
        {
            return PRAY_IMAGE;
        }
    }
}