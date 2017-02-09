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
            int dealer = checkTotal (table.PlayerList [0]);
            if (dealer < 0) {
                return "Dealer Busts";
            }
            string results = "";
            foreach (Player player in table.PlayerList) {
                if (player.isDealer = true) {
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
                        else {
                            results += player.name + " and the dealer PUSH.\n";
                            player.wins += 0.5;
                        }
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
    }
}
