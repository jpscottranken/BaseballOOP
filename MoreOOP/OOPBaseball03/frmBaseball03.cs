using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBaseball03
{
    public partial class frmBaseball03 : Form
    {
        public frmBaseball03()
        {
            InitializeComponent();
        }

        private void btnInstantiate_Click(object sender, EventArgs e)
        {
            CreateOrUpdateABallPlayer();
        }

        private void CreateOrUpdateABallPlayer()
        {
            string outputStr = "";

            //  Instantiate a new baseball player called
            //  player1 using the default constructor.
            BaseballPlayer player1 = new BaseballPlayer();
            ShowMessage("Name: "        + player1.FirstName + " " + player1.LastName +
                        "\nPosition: "  + player1.Position  +
                        "\nHome Runs: " + player1.HomeRuns.ToString() +
                        "\nAverage: "   + player1.Average.ToString("n3"),
                        "PLAYER1 STATS");

            //  Fill up player 1 using the
            //  programmer-created Set methods.
            player1.FirstName = "Lou";
            player1.LastName  = "Brock";
            player1.Position  = "OF";
            player1.HomeRuns  = 149;
            player1.Average   = 0.293M;

            ShowMessage("Name: " + player1.FirstName + " " + player1.LastName +
                        "\nPosition: "  + player1.Position +
                        "\nHome Runs: " + player1.HomeRuns.ToString() +
                        "\nAverage: "   + player1.Average.ToString("n3"),
                        "PLAYER1 STATS");

            //  Instantiate a new baseball player called
            //  player1 using the defaul constructor.
            BaseballPlayer player2 = new BaseballPlayer("Albert", "Pujols");
            ShowMessage("Name: "        + player2.FirstName + " " + player2.LastName +
                        "\nPosition: "  + player2.Position  +
                        "\nHome Runs: " + player2.HomeRuns.ToString() +
                        "\nAverage: "   + player2.Average.ToString("n3"),
                        "PLAYER2 STATS");

            player2.Position = "1B";
            player2.HomeRuns = 703;
            player2.Average = 0.296M;

            ShowMessage("Name: "        + player2.FirstName + " " + player2.LastName +
                        "\nPosition: "  + player2.Position  +
                        "\nHome Runs: " + player2.HomeRuns.ToString() +
                        "\nAverage: "   + player2.Average.ToString("n3"),
                        "PLAYER2 STATS");

            BaseballPlayer player3 = new BaseballPlayer("Stan", "Musial", "1B/OF", 475, .331M);

            ShowMessage("Name: " + player3.FirstName + " " + player3.LastName +
                  "\nPosition: " + player3.Position  +
                 "\nHome Runs: " + player3.HomeRuns.ToString() +
                   "\nAverage: " + player3.Average.ToString("n3"),
                  "PLAYER3 STATS");

            outputStr += "\nName: "     + player1.FirstName + " " + player1.LastName +
                        "\nPosition: "  + player1.Position  +
                        "\nHome Runs: " + player1.HomeRuns.ToString()    +
                        "\nAverage: "   + player1.Average.ToString("n3") +
                         "\n\nName: "   + player2.FirstName + " " + player2.LastName +
                        "\nPosition: "  + player2.Position  +
                        "\nHome Runs: " + player2.HomeRuns.ToString()    +
                        "\nAverage: "   + player2.Average.ToString("n3") +
                        "\n\nName: "    + player3.FirstName + " " + player3.LastName +
                        "\nPosition: "  + player3.Position  +
                        "\nHome Runs: " + player3.HomeRuns.ToString()    +
                        "\nAverage: "   + player3.Average.ToString("n3");

            lblStatistics.Text = outputStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblStatistics.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
