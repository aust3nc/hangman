namespace hangman
{
    public class Director
    {
        private Player player = new Player();
        private Puzzle puzzle = new Puzzle();
        private Parachute parachute = new Parachute();
        private bool isPlaying = true;
        public Director()
        {
        }
        public void startGame()
        {
            string key = puzzle.getWord();
            while (isPlaying)
            {
                Console.WriteLine(key);
                Console.WriteLine();
                string man = parachute.getMan();
                Console.WriteLine(man);
                char val = puzzle.getLetter();
                bool check = key.Contains(val);
                if (check)
                {
                    System.Console.WriteLine(parachute.removePart());
                }
                else if (String.IsNullOrEmpty(man))
                {
                    isPlaying = false;
                    Console.WriteLine("Game over!");
                }
            }
        }
    }
}
