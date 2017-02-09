using System.Collections.Generic;

namespace blackJack 
{
    public class Player
    {
        public string name;
        public List<Card> hand;
        public bool isDealer;
        public double wins;
        public Player(string n){
            // do the other end of the hand creation. Set hand to be a list of strings
            hand = new List<Card>();
            // name is n
            name = n;
            //set isDealer to false by default
            isDealer = false;
            wins = 0.0;
        }
        // function that runs the dealer logic. return the dealers score or - for a bust
        public int dealerRound(Table table, Turn MyTurn)
        {
            // did the player bust? && is you a dealer??
            int busted = MyTurn.checkTotal(table.PlayerList[1]);
            if (busted > 0 && isDealer == true)
            {
                // this is the score that will be messed with and utimately be returned
                int score;

                // return the score. should be either between 16-21 or a bust (-1)
                return score;
            }
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