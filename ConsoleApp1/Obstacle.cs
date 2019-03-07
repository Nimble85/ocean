using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Obstacle : Cell
    {
        public const char OBSTRACT_IMAGE = '#';

        public Obstacle(Ocean owner)
            :base(owner)
    { 
    
    }
        public override void Process()
        {
            //  throw new NotImplementedException();
        }
        public override char GetImage()
        {
            return OBSTRACT_IMAGE;
        }
    }
}
