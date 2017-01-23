using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Virtual Chao Sim! Enter your chaos' name!");
            string chao = Console.ReadLine(); //user enters chaos' name

            Pet pet1 = new Pet(chao);


            string selection = "";
            while (selection != "4")
            {
                Console.Clear();
                pet1.displayStatus();
                Console.WriteLine("Whacha wanna do?");
                Console.WriteLine("1. Play with " + chao + "\n2. Feed " + chao + "\n3. Take " + chao +  " out to the potty \n4. Release " + chao);
             
                selection = (Console.ReadLine());
               

                if (selection == "1")
                {
                    
                    pet1.PlayWithMe();

                }

                else if (selection == "2")
                {
                    pet1.FeedMe();
                }
                else if (selection == "3")
                {
                    pet1.BathroomBreak();
                }
                else if (selection == "4")
                {
                    Console.WriteLine("Nice knowing ya...");
                }

                else
                {
                    Console.WriteLine("Um...what?");
                }

                if (pet1.BellyStat <= 25)
                {
                    pet1.FeedMeWarning();
                }
                if (pet1.BellyStat <= 0)
                {
                    pet1.FeedMeGameOver();
                    Environment.Exit(0);
                }
                if (pet1.HappinessStat <= 25)
                {
                    pet1.PlayWithMeWarning();
                }
                if (pet1.HappinessStat <= 0)
                {
                    pet1.PlayWithMeGameOver();
                    Environment.Exit(0);
                }
                if (pet1.HappinessStat >= 100)
                {
                    pet1.PlayWithMeWin();
                    Environment.Exit(0);
                    
                }
                if (pet1.PottyStat <= 25)
                {
                    pet1.BathroomBreakWarning();
                }
                if (pet1.PottyStat <= 0)
                {
                    pet1.BathroomBreakGameOver();
                    Environment.Exit(0);
                }
                Console.WriteLine("Press \"enter\" to continue");
                Console.ReadKey();
            }
            
            
            


        
        }
    }

}
    