using System;
using System.Threading;

namespace ThreadRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read, Set, Go...");
            int t1Location = 0;
            int t2Location = 0;
            int t3Location = 0;
            int t4Location = 0;
            int t5Location = 0;

            // Creating Threads
            Thread t1 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Speedy Gonzales";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t1Location);
                }

            });

            Thread t2 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Road Runner";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t2Location);

                }
            });

            Thread t3 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Flash";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t3Location);
                }

            });

            Thread t4 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Sonic";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t4Location);

                }
            });

            Thread t5 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Flash Gordon";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t5Location);
                }

            });

            t1.Priority = ThreadPriority.AboveNormal;

            
     t1.Start();
     t2.Start();
     t3.Start();
     t4.Start();
     t5.Start();

            Console.WriteLine("Race has ended");
        }

        static void MoveIt(ref int location)
        {
         location++;
            Console.WriteLine($"{Thread.CurrentThread.Name} location={location}");
            if (location >= 100)
            {
            Console.WriteLine($"{Thread.CurrentThread.Name} is the winner");
            return;
            }
        }
    }
}