using System;
using System.Collections.Generic;

namespace blackJack {
    public class Turn {
        public bool checkBlackJack (Player player) {
            int sum = 0;
            foreach (Card card in player.hand) {
                sum += card.realVal;
            }
            if (sum == 21) {
                return true;
            } else return false;
        }
        public int checkTotal (Player player) {
            int sum = 0;
            foreach (Card card in player.hand) {
                sum += card.realVal;
                if (sum > 21 && card.val == 1) {
                    sum -= 10;
                }
                if (sum > 21) {
                    return -1;
                }
            }
            return sum;
        }
        public string checkWinner (Table table) {
            int dealer = checkTotal (table.PlayerList[0]);
            if (dealer < 0) {
                return "Dealer Busts";
            }
            string results = "";
            foreach (Player player in table.PlayerList) {
                if (player.isDealer == true) {
                    continue;
                } else {
                    int playerHand = checkTotal (player);
                    if (playerHand > 21) {
                        results += player.name + " Busts!.\n";
                    }
                    if (playerHand > dealer) {
                        results += player.name + " beats the dealer.\n";
                        player.wins++;
                    } else if (dealer > playerHand) {
                        results += player.name + " loses to the dealer.\n";
                    } else {
                        results += player.name + " and the dealer PUSH.\n";
                        player.wins += 0.5;
                    }
                }
            }
            return results;
        }
        public string hitOrStand (Player player) {
            string output = "";
            while (output != "Hit" && output != "Stand")
                System.Console.WriteLine ("Do you wish to Hit or Stand?");
            output = System.Console.ReadLine ();
            return output;
        }

        // This function displays the cards that each player has visible on the table.
        public void showTable (Table table) {
            // Each player, in order...
            foreach (Player player in table.PlayerList) {
                // Display the name of the player
                Console.WriteLine (player.name + " has:");
                // Creates a response which we'll log to the console after it's been assembled.
                String ans = "";
                // For every card except for the last,
                for (int i = 0; i < player.hand.Count - 1; i++) {
                    // if the card is face up,
                    if (player.hand[i].faceDown == false) {
                        // add that card to the string.
                        ans += "the " + player.hand[i];
                    }
                    // Otherwise...
                    else {
                        // keep it mysterious.
                        ans += "a face down mystery card";
                    }
                    // I give a fuck about the Oxford comma.
                    ans += ", ";
                }
                // Last value won't need the comma
                ans += "and ";
                if (player.hand[player.hand.Count - 1].faceDown == false) {
                    ans += "the " + player.hand[player.hand.Count - 1];
                } else {
                    ans += "a face down mystery card";
                }
                // Finish the sentence with a period.
                ans += ".";
                ans = char.ToUpper (ans[0]) + ans.Substring (1);
                // Write the answer to the console.
                Console.WriteLine (ans);
            }
        }
        // This flips face down cards face up.
        public void showHand (Player player) {
            // Shows a message to let us know that we are flipping the cards.
            Console.WriteLine ("Let's see what " + player.name + " has, shall we?");
            // For every card in the passed player's hand...
            foreach (Card card in player.hand) {
                // ...change faceDown to false
                card.faceDown = false;
            }
        }
    }
}