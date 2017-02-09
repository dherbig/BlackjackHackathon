using System.Collections.Generic;

namespace ConsoleApplication{
    public class Player
    {
        string name;
        List<Card> hand = new List<Card>();

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