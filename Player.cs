using System.Collections.Generic;

namespace blackJack{
    public class Player
    {
        string name;
        public List<Card> hand;
        public bool isDealer;
        public Player(string n){
            // do the other end of the hand creation. Set hand to be a list of strings
            hand = new List<Card>();
            // name is n
            name = n;
            //set isDealer to false by default
            isDealer = false;
        }
        // function that runs the dealer logic. return the dealers score or - for a bust
        public int dealerRound()
        {
            //dealer??
            if (isDealer == true)
            {
                int score;

                return score;
            }    
        }
        public void Draw(Deck gameDeck)
        {
            hand.Add(gameDeck.Deal());
        }
        public Card Discard(int idx)
        {
            if (idx < hand.Count - 1 && idx > 0)
            {
                Card theCard = hand[idx];
                hand.RemoveAt(idx);
                return theCard;
            }
            else{return null;}
        }

    }

}