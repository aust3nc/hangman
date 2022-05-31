namespace hangman
{
    public class Puzzle
    {
        public string getWord()
        {
            string[] puzzleList; 
            puzzleList = new string[3] {"jacob", "marley", "joshua"};
            Random random = new Random();  
            int index = random.Next(puzzleList.Length);  
            string word = puzzleList[index];
            return word;
        }
        public char getLetter()
        {
            Console.WriteLine();
            Console.WriteLine("^^^^^^");
            char letter;
            Console.WriteLine();
            Console.Write("Enter a letter (A-Z): ");
            letter = Console.ReadKey().KeyChar;
            return letter;
        }
    }
}
