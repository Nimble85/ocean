using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OceanRandomizer
    {
        // 1 - Up
        // 2 - Left
        // 3 - Right
        // 4 - Down
        // _rnd 

        public static Random _rnd = new Random();
        public static Direction GetRandomDirection()
        {

            int low = (int)Direction.NoDirection;    // 0
            int high = (int)Direction.Down + 1;         // 4

            int randDirection = _rnd.Next(low, high);

            return (Direction)randDirection;
        }
    }
}
