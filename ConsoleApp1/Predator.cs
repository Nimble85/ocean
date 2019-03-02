using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Predator : Prey
    {
        public const char PREDATOR_IMAGE = 'S';

        public Predator(Ocean owner) : base(owner)
        {
        }

        public override void Process()
        {
         //   throw new NotImplementedException();
        }

        public override char GetImage()
        {
            return PREDATOR_IMAGE;
        }
    }
}
