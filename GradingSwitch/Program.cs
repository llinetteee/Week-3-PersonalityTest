using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A", siis konsool kuvab "Suurepärane!";
            //kui kasutaja sai "B", siis konsool kuvab "Väga hea!";
            //kui kasutaja sai "C", siis konsool kuvab "Hea!";
            //kui kasutaja sai "D", siis konsool kuvab "Rahuldav";
            //kui kasutaja sai "E", siis konsool kuvab "Kasin";
            //"F", sii skuvab "Puudulik";
            // kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus";

            Console.WriteLine("Palun sisesta oma hinne: ");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav.");
                    break;
                case 'E':
                    Console.WriteLine("Kasin.");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik.");
                    break;

                default:
                    Console.WriteLine($"Vale väärtus.");
                    break;
            }

           










        }

    }
}
