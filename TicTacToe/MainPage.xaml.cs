using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using System.Timers;
using System.Windows;


namespace TicTacToe
{

    public partial class MainPage : ContentPage
    {
        int score1 = 0;
        int score2 = 0;
        int player = 1;
        static int timertim;

        List<Button> buttons;

        public static void TimerWorks(object sender, ElapsedEventArgs e)
        {
           
            //timertim--;
        }
        public MainPage()
        {
           
            //System.Timers.Timer timer = new System.Timers.Timer();
            //timer.Enabled = true;
            //timer.Interval = 1000;
            //timer.Elapsed += TimerWorks;
            //timer.Start();
            InitializeComponent();
            buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            pl1.Text = score1.ToString();
            pl2.Text = score2.ToString();
            TimerLabel.Text = timertim.ToString();
        }
        public void Game(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 2;
                    break;
                case 2:
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = 1;
                    break;
            }
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            CheckWin();
        }
        public void CheckWin()
        {
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" ||
                btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" ||
                btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O" ||
                btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" ||
                btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" ||
                btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O" ||
                btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" ||
                btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                DisplayAlert("Player O win the game!", "Do you want to cantinue?", "Yes");
                score2++;
                pl2.Text = score2.ToString();
                ClearAll();
            }
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" ||
                btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" ||
                btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X" ||
                btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" ||
                btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" ||
                btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" ||
                btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" ||
                btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                DisplayAlert("Player X win the game!", "Do you want to cantinue?", "Yes");

                score1++;
                pl1.Text = score1.ToString();
                ClearAll();

            }
            if (btn1.Text.Length != 0 && btn2.Text.Length != 0 && btn3.Text.Length != 0 &&
                btn4.Text.Length != 0 && btn5.Text.Length != 0 && btn6.Text.Length != 0 &&
                btn7.Text.Length != 0 && btn8.Text.Length != 0 && btn9.Text.Length != 0)
            {
                DisplayAlert("Nobody win the game!", "Do you want to cantinue?", "Yes");

                ClearAll();
            }

        }
        public void ClearAll()
        {
            List<Button> button = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for (int i = 0; i < 9; i++)
            {
                button[i].Text = "";
                button[i].IsEnabled = true;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Thread.CurrentThread.Abort();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            List<Button> button = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for (int i = 0; i < 9; i++)
            {
                button[i].Text = "";
                button[i].IsEnabled = true;
            }
            score1 = 0;
            score2 = 0;
            pl1.Text = "0";
            pl2.Text = "0";


        }




    }
}