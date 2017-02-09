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
        public void dealerRound(Table table, Turn MyTurn)
        {
            Player dealer = table.PlayerList[0];
            int inGame = 0;
            // did the player bust? && is you a dealer??
            foreach (Player player in table.PlayerList) {
                    // skip dealer.
                    if (player == dealer) {
                        continue;
                    }
            int busted = MyTurn.checkTotal(player);
            if (busted > 0) 
            {
                inGame++;
            }
            }

            if (inGame > 0)
            {
                // this is the score that will be messed with
                int score = MyTurn.checkTotal(dealer);
                while (score < 16)
                {
                    dealer.Draw(table.deckName);
                    score = MyTurn.checkTotal(dealer);
                }
                return;
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