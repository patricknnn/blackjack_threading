namespace Blackjack_threading
{
    public class Player : Participents
    {
        public string Name { get; set; }
        
        public Player(int X, int Y) : base(X, Y)
        {
            //contructor only passes X and Y;
        }
    }
}
