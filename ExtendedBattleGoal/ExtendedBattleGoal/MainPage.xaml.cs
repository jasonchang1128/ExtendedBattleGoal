using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExtendedBattleGoal
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        private BattleGoalData BatGoalData = new BattleGoalData();
        public MainPage()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        void Button_Clicked(object sender, System.EventArgs e)
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
            ((Button)sender).Text = $"Battle Goals Generated";

            List<string> TempBatGoalData = new List<string>();
            TempBatGoalData = BatGoalData.GetData(listBatGoalNum[0]);
            BatGoalName0.Text = TempBatGoalData[(int)BattleGoalData.BattleGoalListOrder.BatGoalName];
            BatGoalDesc0.Text = TempBatGoalData[(int)BattleGoalData.BattleGoalListOrder.BatGoalDescription];
            BatGoalChecks0.Text = TempBatGoalData[(int)BattleGoalData.BattleGoalListOrder.BatGoalChecks];
            TempBatGoalData = BatGoalData.GetData(listBatGoalNum[1]);
            BatGoalName1.Text = TempBatGoalData[(int)BattleGoalData.BattleGoalListOrder.BatGoalName];
            BatGoalDesc1.Text = TempBatGoalData[(int)BattleGoalData.BattleGoalListOrder.BatGoalDescription];
            BatGoalChecks1.Text = TempBatGoalData[(int)BattleGoalData.BattleGoalListOrder.BatGoalChecks];
        }
    }
}
