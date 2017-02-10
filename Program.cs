using System;

namespace blackJack {
    public class Program {
        public static void Main (string [] args) {
            Table MyTable = new Table (1);
            Turn MyTurn = new Turn ();
            bool GameOn = true;
            int rounds = 0;
            while (GameOn == true) {
                // Deal each player up card
                foreach (Player player in MyTable.PlayerList) {
                    player.Draw (MyTable.deckName);
                    player.hand [0].faceDown = false;
                }
                // deal each player a face down card
                foreach (Player player in MyTable.PlayerList) {
                    player.Draw (MyTable.deckName);
                    player.hand [0].faceDown = true;
                }
                // each player takes a turn
                foreach (Player player in MyTable.PlayerList) {
                    // skip dealer.
                    if (player == MyTable.PlayerList [0]) {
                        continue;
                    }
                    // display all cards based upon their status
                    MyTurn.showTable (MyTable);
                    // flip player's cards
                    MyTurn.showHand (player);
                    // start hand loop
                    string choice = "";
                    while (choice != "stand")
                        // show total
                        System.Console.WriteLine ("Your total is: " + MyTurn.checkTotal (player).ToString ());
                    // hit or stand
                    choice = MyTurn.hitOrStand (player);
                    if (choice == "Hit") {
                        player.Draw (MyTable.deckName);
                    }
                    // calculate new total
                    int playerVal = MyTurn.checkTotal (player);
                    if (playerVal < 0) {
                        break;
                    }
                    // repeat till stand or busted.
                }
                // dealer takes turn
                MyTable.PlayerList [0].dealerRound (MyTable, MyTurn);
                // check winners
                string results = MyTurn.checkWinner (MyTable);
                System.Console.WriteLine (results);
                
                foreach (Player player in MyTable.PlayerList) {
                    if (player == MyTable.PlayerList [0]) {
                        continue;
                    }
                    System.Console.WriteLine (player.name + "'s win percent is " + player.wins / rounds);
                }
                // quit or continue
                //    query the player quit or continue
                System.Console.WriteLine ("Type 'Quit' to exit or anything else to continue");
                string playerQuit = System.Console.ReadLine ();
                if (playerQuit == "Quit") {
                    GameOn = false;
                }
            }

        }
    }
}