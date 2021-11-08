using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lost_in_island
{
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You are lost in a island";
            option1label.Text = "Go left";
            option2label.Text = "Go right";
            option3label.Text = "Which side do you want to go?";
        }


        private void option1label_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 2; }
            else if (page == 2) { page = 6; }
            else if (page == 6) { page = 1; }
            else if (page == 5) { page = 8; }
            else if (page == 8) { page = 10; }
            else if (page == 10) { page = 1; }
            else if (page == 9) { page = 12; }
            else if (page == 12) { page = 1; }                   
            else if (page == 13) { page = 1; }           
            else if (page == 3) { page = 1; }

            DisplayPage();
        }

        private void option2label_Click(object sender, EventArgs e)
        {
            if (page == 6) { page = 7; }
            else if (page == 2) { page = 5; }
            else if (page == 10) { page = 14; }
            else if (page == 8) { page = 11; }
            else if (page == 11) { page = 15; }
            else if (page == 5) { page = 9; }
            else if (page == 12) { page = 18; }
            else if (page == 9) { page = 13; }
            else if (page == 13) { page = 17; }
            else if (page == 1) { page = 3; }
            else if (page == 3) { page = 4; }

            DisplayPage();
        }

        public void DisplayPage()
        {
            switch(page)
            {
                case 1:
                    outputLabel.Text = "You are lost in a island";
                    option1label.Text = "Go left";
                    option2label.Text = "Go right";
                    option3label.Text = "Which side do you want to go?";
                    break;
                case 2:
                    outputLabel.Text = "You see a fruit tree Do you want to eat the fruit from the tree?";
                    option1label.Text = "Yes";
                    option2label.Text = "No";
                    break;
                case 3:
                    outputLabel.Text = "You were trapped by savages and died. you wanna play again?";
                    option1label.Text = "Yes";
                    option2label.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "Thank you";
                    option1label.Text = "";
                    option2label.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "A sheep past you Do you want to chase it?";
                    option1label.Text = "Yes";
                    option2label.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "The fruit is poisonous You are dead wnna play again?";
                    option1label.Text = "Yes";
                    option2label.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "Thank you for playing";
                    option1label.Text = "";
                    option2label.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "When you were chasing it several savages found you Do you want to escape or fight them";
                    option1label.Text = "Yes";
                    option2label.Text = "No";
                    break;
                case 9:
                    outputLabel.Text = "You decided to look for water. After a while, you heared the sound of the waterfall Do you want to see it with the sound?";
                    option1label.Text = "Yes";
                    option2label.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "There are too many of them.You were killed. You wanna play again?";
                    option1label.Text = "Yes";
                    option2label.Text = "No";
                    break;
                case 11:
                    outputLabel.Text = "Running. you ran to the beach and saw your rescue team coming to pick you up. so you were saved.";
                    option1label.Text = "";
                    option2label.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "With the sound of the waterfall. You reach the place where the sound comes from only to find that it is a savage trap. and then you are killed by them. you wnna play again";
                    option1label.Text = "Yes";
                    option2label.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "You died of dehydration because you didn't drink water for a long time play again?";
                    option1label.Text = "yes";
                    option2label.Text = "no";
                    break;
                case 14:
                    outputLabel.Text = "Thank you for playing";
                    option1label.Text = "";
                    option2label.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "You win! game over.";
                    option1label.Text = "";
                    option2label.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "Thank you for playing";
                    option1label.Text = "";
                    option2label.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "Thank you for playing";
                    option1label.Text = "";
                    option2label.Text = "";
                    break;
                default:
                    break;


            }
        }
    }
}
    


