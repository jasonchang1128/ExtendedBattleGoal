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
        //ExtendedBattleGoal.Data.BattleGoals goalObj;
        public MainPage()
        {
            InitializeComponent();
            ExtendedBattleGoal.Data.BattleGoals.BattleGoalInit();
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            ExtendedBattleGoal.Data.BattleGoals.BattleGoalDraw();
            ((Button)sender).Text = $"Battle Goals Generated";
        }
    }
}
