using System;

namespace blackJack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Table MyTable = new Table(1);
            Turn MyTurn = new Turn();
            bool GameOn = true;
            while(GameOn=true){
                // Deal each player a card
                foreach (Player player in MyTable.PlayerList){

                }
                // deal each player a face up card
                {
                    
                }
                // each player takes a turn
                foreach (Player player in MyTable.PlayerList)
                {
                    // display all cards
                    // hit or stand
                    // calculate new total
                    // repeat till stand or busted.
                }
                // dealer takes turn
                MyTable.PlayerList[0].dealerRound(MyTable);
                // check winners
                string results = MyTurn.checkWinner(MyTable);
                System.Console.WriteLine(results);
                

            }


        }
    }
}
