namespace ConsoleApplication{
    public class Card
    {
        private string stringVal;
        private string suit;
        private int val;

        public Card(string anzug, int num){
            suit = anzug;
            val = num+1;
            string[] sV = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            stringVal = sV[num];
        }
        public string Is()
        {
            return stringVal + " of " + suit;
        }
    }
}