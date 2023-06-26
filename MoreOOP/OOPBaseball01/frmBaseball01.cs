using System;
using System.Windows.Forms;

namespace OOPBaseball01
{
    public partial class frmBaseball01 : Form
    {
        public frmBaseball01()
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
            ShowMessage("Name: " + player1.GetFirstName()       + " " + player1.GetLastName() +
                        "\nPosition: "  + player1.GetPosition() +
                        "\nHome Runs: " + player1.GetHomeRuns().ToString() +
                        "\nAverage: " + player1.GetAverage().ToString("n3"),
                        "PLAYER1 STATS");

            //  Fill up player 1 using the
            //  programmer-created Set methods.
            player1.SetFirstName("Lou");
            player1.SetLastName("Brock");
            player1.SetPosition("OF");
            player1.SetHomeRuns(149);
            player1.SetAveragee(0.293M);

            ShowMessage("Name: " + player1.GetFirstName() + " " + player1.GetLastName() +
            "\nPosition: " + player1.GetPosition() +
            "\nHome Runs: " + player1.GetHomeRuns().ToString() +
            "\nAverage: " + player1.GetAverage().ToString("n3"),
            "PLAYER1 STATS");

            //  Instantiate a new baseball player called
            //  player1 using the defaul constructor.
            BaseballPlayer player2 = new BaseballPlayer("Albert", "Pujols");
            ShowMessage("Name: " + player2.GetFirstName()       + " " + player2.GetLastName() +
                        "\nPosition: "  + player2.GetPosition() +
                        "\nHome Runs: " + player2.GetHomeRuns().ToString() +
                        "\nAverage: "   + player2.GetAverage().ToString("n3"),
                        "PLAYER1 STATS");

            player2.SetPosition("1B");
            player2.SetHomeRuns(703);
            player2.SetAveragee(0.296M);

            ShowMessage("Name: " + player2.GetFirstName() + " " + player2.GetLastName() +
                  "\nPosition: " + player2.GetPosition()  +
                 "\nHome Runs: " + player2.GetHomeRuns().ToString() +
                   "\nAverage: " + player2.GetAverage().ToString("n3"),
                  "PLAYER2 STATS");


            BaseballPlayer player3 = new BaseballPlayer("Stan", "Musial", "1B/OF", 475, .331M);

            ShowMessage("Name: " + player3.GetFirstName() + " " + player3.GetLastName() +
                  "\nPosition: " + player3.GetPosition()  +
                 "\nHome Runs: " + player3.GetHomeRuns().ToString() +
                   "\nAverage: " + player3.GetAverage().ToString("n3"),
                  "PLAYER3 STATS");

            outputStr += "\nName: " + player1.GetFirstName() + " " + player1.GetLastName() +
                        "\nPosition: "  + player1.GetPosition()    +
                        "\nHome Runs: " + player1.GetHomeRuns().ToString() +
                        "\nAverage: "   + player1.GetAverage().ToString("n3") +
                         "\n\nName: "   + player2.GetFirstName()   + " " + player2.GetLastName() +
                        "\nPosition: "  + player2.GetPosition()    +
                        "\nHome Runs: " + player2.GetHomeRuns().ToString() +
                        "\nAverage: "   + player2.GetAverage().ToString("n3") +
                        "\n\nName: "    + player3.GetFirstName()   + " " + player3.GetLastName() +
                        "\nPosition: "  + player3.GetPosition()    +
                        "\nHome Runs: " + player3.GetHomeRuns().ToString() +
                        "\nAverage: "   + player3.GetAverage().ToString("n3");

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
