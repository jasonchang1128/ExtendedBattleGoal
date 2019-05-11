using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedBattleGoal.Data
{
    class BattleGoals
    {
        static Dictionary<int, List<string>> BattleGoalDict = new Dictionary<int, List<string>>();
        public static void BattleGoalInit()
        {
            BattleGoalDict[1] = new List<string> { "Acrobatic     ", "Lose a card to negate 5 or more damage.                                                                                   ", "✓ " };
            BattleGoalDict[2] = new List<string> { "Aggressor*    ", "Have one or more monsters present on the map at the beginning of every round during the scenario.                         ", "✓✓" };
            BattleGoalDict[3] = new List<string> { "Ambusher      ", "Open a door and end your move action adjacent to a monster in the revealed room.                                          ", "✓ " };
            BattleGoalDict[4] = new List<string> { "Assassin      ", "Kill a monster before it takes any actions in the scenario.                                                               ", "✓ " };
            BattleGoalDict[5] = new List<string> { "Assistant     ", "Kill a monster attacked by an ally earlier in the round.                                                                  ", "✓ " };
            BattleGoalDict[6] = new List<string> { "Bastion       ", "Be adjacent to at least two monsters while standing on a door hex.                                                        ", "✓ " };
            BattleGoalDict[7] = new List<string> { "Bully         ", "Kill a monster afflicted by a negative condition.                                                                         ", "✓ " };
            BattleGoalDict[8] = new List<string> { "Contagious    ", "While afflicted by a negative condition, apply any negative condition to a monster.                                       ", "✓ " };
            BattleGoalDict[9] = new List<string> { "Covetous      ", "Never collect a money token from end-of-turn looting.                                                                     ", "✓ " };
            BattleGoalDict[10] = new List<string> { "Cuddler       ", "Take a rest only on rounds in which an ally is also taking a long or short rest.                                          ", "✓ " };
            BattleGoalDict[11] = new List<string> { "Diehard*      ", "Never allow your current hit point value to drop below half your maximum hit point value (rounded up) during the scenario.", "✓ " };
            BattleGoalDict[12] = new List<string> { "Discriminating", "Kill no elite monsters or bosses during the scenario.                                                                     ", "✓ " };
            BattleGoalDict[13] = new List<string> { "Distracted    ", "Kill a monster you are not adjacent to while adjacent to another monster.                                                 ", "✓ " };
            BattleGoalDict[14] = new List<string> { "Drowsy        ", "Declare a long rest while at your maximum hit point value.                                                                ", "✓ " };
            BattleGoalDict[15] = new List<string> { "Dynamo*       ", "Kill a monster during the scenario by causing at least 4 more points of damage to it than is necessary.                   ", "✓ " };
            BattleGoalDict[16] = new List<string> { "Elitist       ", "Kill only elite monsters.                                                                                                 ", "✓ " };
            BattleGoalDict[17] = new List<string> { "Executioner*  ", "Kill an undamaged monster with a single attack during the scenario.                                                       ", "✓ " };
            BattleGoalDict[18] = new List<string> { "Explorer*     ", "Reveal a room tile by opening a door on your turn during the scenario.                                                    ", "✓ " };
            BattleGoalDict[19] = new List<string> { "Exterminator  ", "Kill three monsters in the same round.                                                                                    ", "✓✓" };
            BattleGoalDict[20] = new List<string> { "Fast Healer*  ", "Your current hit point value must be equal to your maximum hit point value at the end of the scenario.                    ", "✓ " };
            BattleGoalDict[21] = new List<string> { "Fearful       ", "Never end your turn adjacent to a monster.                                                                                ", "✓ " };
            BattleGoalDict[22] = new List<string> { "Feeble        ", "Be the first player to become exhausted.                                                                                  ", "✓ " };
            BattleGoalDict[23] = new List<string> { "Feral         ", "Have the most cards in your lost pile at the end of the scenario.                                                         ", "✓ " };
            BattleGoalDict[24] = new List<string> { "Finisher      ", "Kill the last monster to die in the scenario.                                                                             ", "✓ " };
            BattleGoalDict[25] = new List<string> { "Hesitant      ", "Never go first in a round's initiative.                                                                                   ", "✓ " };
            BattleGoalDict[26] = new List<string> { "Hoarder*      ", "Loot five or more money tokens during the scenario.                                                                       ", "✓ " };
            BattleGoalDict[27] = new List<string> { "Hothead       ", "Add two cards to your lost pile before your first rest.                                                                   ", "✓✓" };
            BattleGoalDict[28] = new List<string> { "Hunter*       ", "Kill one or more elite monsters during the scenario.                                                                      ", "✓ " };
            BattleGoalDict[29] = new List<string> { "Indigent*     ", "Loot no money tokens or treasure overlay tiles during the scenario.                                                       ", "✓✓" };
            BattleGoalDict[30] = new List<string> { "Instigator    ", "Except when long resting, never go last in a round's initiative.                                                          ", "✓ " };
            BattleGoalDict[31] = new List<string> { "Insulting     ", "Apply another negative condition to a monster already afflicted by one.                                                   ", "✓ " };
            BattleGoalDict[32] = new List<string> { "Layabout*     ", "Gain 7 or fewer experience points during the scenario.                                                                    ", "✓✓" };
            BattleGoalDict[33] = new List<string> { "Limping       ", "Move using only basic move actions.                                                                                       ", "✓✓" };
            BattleGoalDict[34] = new List<string> { "Lucky         ", "Kill a monster with an attack with disadvantage.                                                                          ", "✓ " };
            BattleGoalDict[35] = new List<string> { "Marksman      ", "Kill a monster three or more hexes away from you.                                                                         ", "✓ " };
            BattleGoalDict[36] = new List<string> { "Masochist*    ", "Your current hit point value must be equal to or less than 2 at the end of the scenario.                                  ", "✓ " };
            BattleGoalDict[37] = new List<string> { "Miser         ", "Never exit a room while money tokens remain in it.                                                                        ", "✓✓" };
            BattleGoalDict[38] = new List<string> { "Mugger        ", "Kill a monster and loot its money token on the same turn.                                                                 ", "✓ " };
            BattleGoalDict[39] = new List<string> { "Multitasker   ", "Kill a monster and open a door on the same round.                                                                         ", "✓✓" };
            BattleGoalDict[40] = new List<string> { "Neutralizer*  ", "Cause a trap to be sprung or disarmed on your turn or on the turn of one of your summons during the scenario.             ", "✓ " };
            BattleGoalDict[41] = new List<string> { "Opener*       ", "Be the first to kill a monster during the scenario.                                                                       ", "✓ " };
            BattleGoalDict[42] = new List<string> { "Pacifist*     ", "Kill three or fewer monsters during the scenario.                                                                         ", "✓ " };
            BattleGoalDict[43] = new List<string> { "Paranoid      ", "End each of your turns adjacent to a wall or obstacle.                                                                    ", "✓✓" };
            BattleGoalDict[44] = new List<string> { "Peacemonger   ", "Never deal the killing blow to a monster.                                                                                 ", "✓✓" };
            BattleGoalDict[45] = new List<string> { "Perforated    ", "Lose 6 or more hit points in a single round.                                                                              ", "✓ " };
            BattleGoalDict[46] = new List<string> { "Pickpocket    ", "Perform a loot action while adjacent to at least two monsters.                                                            ", "✓ " };
            BattleGoalDict[47] = new List<string> { "Pincushion    ", "Get attacked by three or more monsters in the same round.                                                                 ", "✓ " };
            BattleGoalDict[48] = new List<string> { "Plunderer*    ", "Loot a treasure overlay tile during the scenario.                                                                         ", "✓ " };
            BattleGoalDict[49] = new List<string> { "Professional* ", "Use your equipped items a number of times equal to or greater than your level plus 2 during the scenario.                 ", "✓ " };
            BattleGoalDict[50] = new List<string> { "Prosperous    ", "Collect three or more money tokens in the same turn.                                                                      ", "✓ " };
            BattleGoalDict[51] = new List<string> { "Protector*    ", "Allow none of your character allies to become exhausted during the scenario.                                              ", "✓ " };
            BattleGoalDict[52] = new List<string> { "Purist*       ", "Use no items during the scenario.                                                                                         ", "✓✓" };
            BattleGoalDict[53] = new List<string> { "Ravager       ", "Play two cards for their lost actions on the same turn.                                                                   ", "✓ " };
            BattleGoalDict[54] = new List<string> { "Recluse       ", "Never end your turn adjacent to an ally.                                                                                  ", "✓ " };
            BattleGoalDict[55] = new List<string> { "Reserved      ", "Have the fewest cards in your lost pile at the end of the scenario.                                                       ", "✓ " };
            BattleGoalDict[56] = new List<string> { "Restless      ", "Move at least one hex on each of your turns (except when long resting).                                                   ", "✓ " };
            BattleGoalDict[57] = new List<string> { "Retaliator    ", "Don't make any attacks in the scenario until after you've taken damage for the first time.                                ", "✓ " };
            BattleGoalDict[58] = new List<string> { "Ritualistic   ", "Kill a monster when two or more elements are strong or waning.                                                            ", "✓ " };
            BattleGoalDict[59] = new List<string> { "Sadist*       ", "Kill five or more monsters during the scenario.                                                                           ", "✓ " };
            BattleGoalDict[60] = new List<string> { "Scavenger     ", "Collect more money tokens than any other player.                                                                          ", "✓ " };
            BattleGoalDict[61] = new List<string> { "Scrambler*    ", "Take only short rests during the scenario.                                                                                ", "✓ " };
            BattleGoalDict[62] = new List<string> { "Shadow        ", "End each of your turns adjacent to an ally.                                                                               ", "✓ " };
            BattleGoalDict[63] = new List<string> { "Sharpshooter  ", "Kill a monster in a different room (neither of you may be on a doorway tile).                                             ", "✓ " };
            BattleGoalDict[64] = new List<string> { "Slayer        ", "Kill two monsters in the same round.                                                                                      ", "✓ " };
            BattleGoalDict[65] = new List<string> { "Sleepless     ", "Take damage during the same round you take a long rest.                                                                   ", "✓ " };
            BattleGoalDict[66] = new List<string> { "Sober         ", "Use no potions during the scenario.                                                                                       ", "✓ " };
            BattleGoalDict[67] = new List<string> { "Sociable      ", "Never leave a room with a character ally remaining in it.                                                                 ", "✓ " };
            BattleGoalDict[68] = new List<string> { "Specialized   ", "Don't use any basic actions.                                                                                              ", "✓ " };
            BattleGoalDict[69] = new List<string> { "Stalwart      ", "Never leave a hex adjacent to a monster.                                                                                  ", "✓✓" };
            BattleGoalDict[70] = new List<string> { "Straggler*    ", "Take only long rests during the scenario.                                                                                 ", "✓ " };
            BattleGoalDict[71] = new List<string> { "Streamliner*  ", "Have five or more total cards in your hand and discard at the end of the scenario.                                        ", "✓ " };
            BattleGoalDict[72] = new List<string> { "Stubborn      ", "Do not lose any cards to negate damage during the scenario.                                                               ", "✓ " };
            BattleGoalDict[73] = new List<string> { "Thorough      ", "Never exit a room with monsters remaining in it.                                                                          ", "✓ " };
            BattleGoalDict[74] = new List<string> { "Untouchable   ", "Take no damage.                                                                                                           ", "✓✓" };
            BattleGoalDict[75] = new List<string> { "Wasteful      ", "Lose a card to negate 2 or less damage from an attack.                                                                    ", "✓ " };
            BattleGoalDict[76] = new List<string> { "Winded        ", "Never have fewer than one card in your hand.                                                                              ", "✓ " };
            BattleGoalDict[77] = new List<string> { "Workhorse*    ", "Gain 13 or more experience points during the scenario.                                                                    ", "✓ " };
            BattleGoalDict[78] = new List<string> { "Zealot*       ", "Have three or fewer total cards in your hand and discard at the end of the scenario.                                      ", "✓ " };
        }

        static Random rnd = new Random();
        public static void BattleGoalDraw()
        {
            List<int> listBatGoalNum = new List<int>();

            for (int i = 0; i < 2; i++)
            {
                int number;
                do
                {
                    number = rnd.Next(1, 78);
                } while (listBatGoalNum.Contains(number));
                listBatGoalNum.Add(number);
            }

            MainPage.BatGoalName0.Text = BattleGoalDict[listBatGoalNum[0]][0];
            MainPage.BatGoalDesc0.Text = BattleGoalDict[listBatGoalNum[0]][1];
            MainPage.BatGoalChecks0.Text = BattleGoalDict[listBatGoalNum[0]][2];
            MainPage.BatGoalName1.Text = BattleGoalDict[listBatGoalNum[1]][0];
            MainPage.BatGoalDesc1.Text = BattleGoalDict[listBatGoalNum[1]][1];
            MainPage.BatGoalChecks1.Text = BattleGoalDict[listBatGoalNum[1]][2];
        }
    }
}
