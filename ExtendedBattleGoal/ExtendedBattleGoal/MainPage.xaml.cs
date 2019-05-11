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
        public MainPage()
        {
            InitializeComponent();
            ExtendedBattleGoal.Data.BattleGoals.BattleGoalInit();
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            ExtendedBattleGoal.Data.BattleGoals.BattleGoalDraw();
            ((Button)sender).Text = $"Battle Goals Generated";
            ChooseButton1.IsEnabled = true;
            ChooseButton2.IsEnabled = true;
            ChooseButton1.IsVisible = true;
            ChooseButton2.IsVisible = true;
        }

        private void ChosenGoal1(object sender, EventArgs e)
        {
            ChooseButton1.IsEnabled = false;
            ChooseButton2.IsEnabled = false;
            ChooseButton1.IsVisible = false;
            ChooseButton2.IsVisible = false;
            BatGoalName1.Text = "";
            BatGoalDesc1.Text = "";
            BatGoalChecks1.Text = "";
        }

        private void ChosenGoal2(object sender, EventArgs e)
        {
            ChooseButton1.IsEnabled = false;
            ChooseButton2.IsEnabled = false;
            ChooseButton1.IsVisible = false;
            ChooseButton2.IsVisible = false;
            BatGoalName0.Text = "";
            BatGoalDesc0.Text = "";
            BatGoalChecks0.Text = "";
        }
    }
}
