using System;

namespace HeadsTails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = "Circus Chirpus";
            Console.WriteLine(name);
            Console.WriteLine("Welcome Circus Chirpus. Do you want to do the COIN FLIP CHALLENGE? Yes/No");
            string text = "You entered No";
            Console.WriteLine(text);
            Console.WriteLine("You are a coward Circus Chirpus");
            Console.WriteLine("What's your name?");
            string txt = "Circus Chirpus";
            Console.WriteLine(txt);
            Console.WriteLine("Welcome Circus Chirpus. Do you want to do the COIN FLIP CHALLENGE? Yes/No");
            string response = "You entered Yes";
            Console.WriteLine(response);
            Console.WriteLine("Heads or Tails?");
            string word = "Heads";
            Console.WriteLine(word);
            string answer = "Incorrect";
            Console.WriteLine(answer);
            Console.WriteLine(text);
            Console.WriteLine("Thank you Circus Chirpus. You got a score of 3!");
            Coin coin = new Coin();
            for (int i = 1; i <= 5; i++)
            {
                string outcome = coin.Toss();
                Console.WriteLine($"Toss {i}: {outcome}");
            }
        }
    }
    public class Coin
    {
        private Random random;
        public Coin()
        {
            random = new Random();
        }
        public string Toss()
        {
            int randomNumber = random.Next(2);
            return randomNumber == 0 ? "Heads" : "Tails";
        }
    }
}
