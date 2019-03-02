using System;

namespace ConsoleApp1
{
    class Program
    {
        const int STEP_COUNT = 10;

        static void Main(string[] args)
        {
            Ocean o = new Ocean(20, 20);

            FillFakeData(o);

            // o.Draw();

            for (int i = 0; i < STEP_COUNT; i++)
            {
                Console.Clear();
                o.Draw();
                o.RunStep();

                Console.Write("Press any key ...");
                o.RunStep();
            }
        Console.Clear();
        o.Draw();
         //   Direction d1 = Direction.Right;
         //  int d1Int
         //   Direction d1 = OceanRandomizer.GetRandomDirection();
         //   Direction d2 = OceanRandomizer.GetRandomDirection();
         //   Direction d3 = OceanRandomizer.GetRandomDirection();
         //   Direction d4 = OceanRandomizer.GetRandomDirection();

            Console.Write("Press any key ...");
            Console.ReadKey();
        }



        private static void FillFakeData(Ocean o)
        {
            #region  Добавление преград

            Obstacle obst1 = new Obstacle(o) { X = 1, Y = 2 };
            Obstacle obst2 = new Obstacle(o) { X = 11, Y = 3 };
            Obstacle obst3 = new Obstacle(o) { X = 18, Y = 6 };

            o.Add(obst1);
            o.Add(obst2);
            o.Add(obst3);


            #endregion

            #region  Добавление хищников

            Predator pred1 = new Predator(o) { X = 15, Y = 13 };
            Predator pred2 = new Predator(o) { X = 19, Y = 15 };
            Predator pred3 = new Predator(o) { X = 4, Y = 18 };

            o.Add(pred1);
            o.Add(pred2);
            o.Add(pred3);


            #endregion
            
            #region  Добавление добычи

            Prey pr1 = new Prey(o) { X = 18, Y = 3 };
            Prey pr2 = new Prey(o) { X = 8, Y = 5 };
            Prey pr3 = new Prey(o) { X = 11, Y = 8 };


            o.Add(pr1);
            o.Add(pr2);
            o.Add(pr3);


            #endregion
        }
    }
}
