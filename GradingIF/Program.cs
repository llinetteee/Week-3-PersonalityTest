using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A", siis konsool kuvab "Suurepärane!";
            //kui kasutaja sai "B", siis konsool kuvab "Väga hea!";
            //kui kasutaja sai "C", siis konsool kuvab "Hea!";
            //kui kasutaja sai "D", siis konsool kuvab "Rahuldav";
            //kui kasutaja sai "E", siis konsool kuvab "Kasin";
            //"F", sii skuvab "Puudulik";
            // kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus";

            Console.WriteLine("Sisesta oma hinne: ");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());


            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }

            else if (userResult == 'B' )
            {
                Console.WriteLine("Väga hea!");
            }

            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }

            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav.");
            }

            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin.");
            }

            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik.");
            }
            else 

                Console.WriteLine("Vale väärtus.");

        }
    }
}
