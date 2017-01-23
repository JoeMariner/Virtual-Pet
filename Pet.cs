using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class Pet
    {
        //fields
        public string PetsName;
        private int Happiness;
        private int Belly;
        private int Potty;

        

        //properties
        public string NameStat //user will name chao
        {
            get { return this.PetsName; }
            set { this.PetsName = value; }
        }
        public int HappinessStat //when chao is played with, happiness stat will take effect.
        {
            get { return this.Happiness; }
            set { this.Happiness = value; }
        }
        public int BellyStat //when chao is fed, belly stat will take effect.
        {
            get { return this.Belly; }
            set { this.Belly = value; }
        }
        public int PottyStat //when chao is taken out to the bathroom, potty stat will take effect.
        {
            get { return this.Potty; }
            set { this.Potty = value; }
        }


        public Pet(string name) //Constructor. User will name its chao.
        {
            Random randomStat = new Random();
            this.PetsName = name;
            this.Happiness = randomStat.Next(30, 50); // Chao will start with random stats
            this.Belly = randomStat.Next(30, 50);
            this.Potty = randomStat.Next(30, 50);
        }

        //Methods
        public void FeedMe() //When user feeds chao, belly stat goes up while potty goes down.
        {
            Random FeedMeOutcome = new Random();
            Console.WriteLine("\"That was really good!\"");
            this.Belly = this.Belly + FeedMeOutcome.Next(10, 30);
            this.Potty = this.Potty - FeedMeOutcome.Next(10, 30);
    
        }
        public void FeedMeWarning() //Belly stat getting low
        {
            Console.WriteLine("\"\aI'm hungry!!\"");

        }
        public void FeedMeGameOver() //Game over screen. Belly went to 0
        {
            Console.WriteLine("Your chao starved to death...");
        }
        public void BathroomBreak() //When user takes chao to bathroom, potty stat goes up while happiness goes down
        {
            Random bathroomBreakOutcome = new Random();
            Console.WriteLine("\"ahh...relieved!\"");
            this.Potty = this.Potty + bathroomBreakOutcome.Next(10, 25);
            this.Happiness = this.Happiness - bathroomBreakOutcome.Next(10, 25);
        }
        public void BathroomBreakWarning() //Potty stat getting low
        {
            Console.WriteLine("\"\aI need to go outside!!\"");
        }
        public void BathroomBreakGameOver() //Game over screen. Potty went to 0
        {
            Console.WriteLine("Your chao went on the carpet...");
            
        }
        public void PlayWithMe() //When chao is played with happiness goes up while. It burns calories and starts to get hungry.
        {
            Random playWithMeOutcome = new Random();
            this.Happiness = this.Happiness + playWithMeOutcome.Next(10, 45);
            this.Belly = this.Belly - +playWithMeOutcome.Next(10, 30);
            Console.WriteLine("\"That was fun!\"");
        }
        public void PlayWithMeWarning() //happiness stat getting low
        {
            Console.WriteLine("\"\aI'm bored...\"");
        }
        public void PlayWithMeGameOver() //Game over screen. Happiness went to 0
        {
            Console.WriteLine("Your chao ran away...");
        }
        public void PlayWithMeWin() //Game over screen. Happiness is at 100. User wins.
        {
            Console.WriteLine("Your chao is really happy! You've raised it well and have given it a good home");
        }
        

        public void displayStatus() //Status screen. Will display and update when user performs an action.

        {
            Console.WriteLine("Name: " + PetsName);
            Console.WriteLine(" Happiness: " + Happiness);
            Console.WriteLine(" Belly: " + Belly);
            Console.WriteLine(" Potty: " + Potty);
        }
    }
}
