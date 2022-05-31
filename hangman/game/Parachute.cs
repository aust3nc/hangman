namespace hangman
{
    public class Parachute
    {
        string man = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
        public Parachute()
        {

        }
        public string removePart()
        {
            man.Remove(0,1);
            return man;
        }
        public string getMan()
        {
            return man;
        }
    }
}
