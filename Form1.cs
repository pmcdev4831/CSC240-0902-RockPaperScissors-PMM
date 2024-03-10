using System.Collections;

namespace CSC240_0902_RockPaperScissors_PMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int player_wins = 0, computer_wins = 0;

        ArrayList list = new ArrayList();

        Random random = new Random();

        Bitmap rock = Properties.Resources.rock;
        Bitmap paper = Properties.Resources.paper;
        Bitmap scissors = Properties.Resources.scissors;
        Bitmap random_picture;
        private void Form1_Load(object sender, EventArgs e)
        {
            UxRock.Image = Properties.Resources.rock;
            UxPaper.Image = Properties.Resources.paper;
            UxScissor.Image = Properties.Resources.scissors;

            list.Add(rock);
            list.Add(paper);
            list.Add(scissors);
        }



        private void UxRock_Click(object sender, EventArgs e)
        {
            UxPlayerPictureBox.Image = rock;
            random_picture = (Bitmap)list[random.Next(list.Count)];

            UxComputerPictureBox.Image = random_picture;

            getWinner(rock, random_picture);
            
           
        }

        private void UxPaper_Click(object sender, EventArgs e)
        {
            UxPlayerPictureBox.Image = paper;
            random_picture = (Bitmap)list[random.Next(list.Count)];

            UxComputerPictureBox.Image = random_picture;

            getWinner(paper, random_picture);
        }

        private void UxScissor_Click(object sender, EventArgs e)
        {
            UxPlayerPictureBox.Image = scissors;
            random_picture = (Bitmap)list[random.Next(list.Count)];

            UxComputerPictureBox.Image = random_picture;

            getWinner(scissors, random_picture);
        }

        public void getWinner(Bitmap player, Bitmap computer)
        {
            if (player.Equals(computer)) 
            {
            
            }
            else if (player.Equals(rock)) 
            {
                if(computer.Equals(scissors)) 
                {
                    player_wins++;
                    UxPlayerScore.Text = player_wins.ToString();
                }
                else
                {
                    computer_wins++;
                    UxComputerScore.Text = computer_wins.ToString();
                }
            }
            else if (player.Equals(scissors))
            {
                if (computer.Equals(rock))
                {
                    player_wins++;
                    UxPlayerScore.Text = player_wins.ToString();
                }
                else 
                {
                    computer_wins++;
                    UxComputerScore.Text = computer_wins.ToString();
                }
            }
            else if (player.Equals(paper))
            {
                if(computer.Equals(scissors))
                {
                    player_wins++;
                    UxPlayerScore.Text = player_wins.ToString();
                }
                else
                {
                    computer_wins++;
                    UxComputerScore.Text = computer_wins.ToString();
                }
            }
        }
    }
}
