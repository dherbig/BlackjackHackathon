using System.Collections.Generic;

namespace blackJack {
    public class Turn {
        public bool checkBlackJack (Player player) {
            int sum = 0;
            foreach (Card card in player.hand) {
                sum += card.realVal;
            }
            if (sum == 21) {
                return true
            } else return false;
        }
        public static int checkTotal (Player player) {
            int sum = 0;
            foreach (Card card in player.hand) {
                sum += card.realVal;
                if (sum > 21 && card.val == 1) {
                    sum -= 10;
                }
                if (sum > 21) {
                    return -1;
                }
                return sum;
            }
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
                    int player = checkTotal (player);
                    if (player > 21) {
                        results += player.name + " Busts!.\n";
                    }
                    if (player > dealer) {
                        results += player.name + " beats the dealer.\n";
                        player.wins++;
                    } else if (dealer > player) {
                        results += player.name + " loses to the dealer.\n"
                        else {
                            results += player.name + " and the dealer PUSH.\n"
                            wins += 0.5
                        }
                    }
                }
            }
        }
    }
}