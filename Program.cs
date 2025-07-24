using static System.Console;

namespace Project1
{
    class Program
    {
        private const int SIZE = 3;
        static void Main(string[] args)
        {
            string input, word1 = "rock", word2 = "paper", word3 = "scissors", input1;
            int draw=0, win=0, lose = 0;
            
            string [] words = new string [SIZE] { word1, word2, word3 };

            StartGame(out input,word1, word2, word3);

            do
            {
                GameAlgorithm(input, words, word1, word2, word3, ref win, ref lose, ref draw);

                input1 = ContinueGameOrNot(ref input, word1, word2, word3, win, lose, draw);
                
            } while (input1 == "y");

        }

        static void StartGame(out string input,string word1, string word2, string word3)
        {
            Write("Rock, paper, scissors? \nYou     : ");
            input = ReadLine();
            input = input.ToLower();
            
            input = ValidateInput(input, word1, word2, word3);
        }

        static string ValidateInput(string input, string word1, string word2, string word3)
        {
            while (!(input == word1 || input == word2 || input == word3))
            {
                WriteLine("Invalid input. Try again.");
                WriteLine();
                Write("Rock, paper, scissors? \nYou     : ");
                input = ReadLine();
                input = input.ToLower();
            }

            return input;
        }

        static void GameAlgorithm(string input, string[] words, string word1, string word2, string word3, ref int win, ref int lose, ref int draw)
        {
            string computerChoice = null;
            
            Random rnd = new Random();
            
            switch (input)
                {
                    case "rock":
                        
                        computerChoice = words[rnd.Next(0, words.Length)];

                        if (computerChoice == word1)
                        {
                            WriteLine("Computer: rock \nDraw!");
                            draw++;
                        }
                        else if (computerChoice == word2)
                        {
                            WriteLine("Computer: paper \nYou lose!");
                            lose++;
                        }
                        else if (computerChoice == word3)
                        {
                            WriteLine("Computer: scissors \nYou win!");
                            win++;
                        }

                        break;
                    
                    case "paper":
                        
                        computerChoice = words[rnd.Next(0, words.Length)];

                        if (computerChoice == word1)
                        {
                            WriteLine("Computer: rock \nYou win!");
                            win++;
                        }
                        else if (computerChoice == word2)
                        {
                            WriteLine("Computer: paper \nDraw!");
                            draw++;
                        }
                        else if (computerChoice == word3)
                        {
                            WriteLine("Computer: scissors \nYou lose!");
                            lose++;
                        }
                        break;
                    
                    case "scissors":
                        
                        computerChoice = words[rnd.Next(0, words.Length)];

                        if (computerChoice == word1)
                        {
                            WriteLine("Computer: rock \nYou lose!");
                            lose++;
                        }
                        else if (computerChoice == word2)
                        {
                            WriteLine("Computer: paper \nYou win!");
                            win++;
                        }
                        else if (computerChoice == word3)
                        {
                            WriteLine("Computer: scissors \nDraw!");
                            draw++;
                        }
                        break;
                }
        }

        static string ContinueGameOrNot(ref string input, string word1, string word2, string word3, int win, int lose, int draw)
        {
            string input1;
            
            WriteLine();

            Write("Play again? (Y/N) ");
            input1 = ReadLine().ToLower();
            while (!(input1 == "y" || input1 == "n"))
            {
                WriteLine("Invalid input. Try again.");
                WriteLine();
                Write("Play again? (Y/N) ");
                input1 = ReadLine().ToLower();
            }
                
            WriteLine();

            if (input1 == "y")
            {
                Write("Rock, paper, scissors? \nYou     : ");
                input = ReadLine();
                input = input.ToLower();
                
                input = ValidateInput(input, word1, word2, word3);
            }
            else if (input1 == "n")
            {
                WriteLine("You had {0} wins, {1} draws and {2} loses", win, draw, lose);
                if (win > lose)
                {
                    WriteLine("You've beaten the computer!");
                }
                else if (win < lose)
                {
                    WriteLine("You've lost to the computer!");
                }
                else if (win == lose)
                {
                    WriteLine("You've tied with the computer!");
                }
                    
                WriteLine();
                WriteLine("Goodbye!!!");
            }

            return input1;
        }
    }
}