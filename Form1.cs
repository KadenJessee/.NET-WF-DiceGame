using System;

namespace WinFormsApp1
{
    /// <summary>
    /// simulates a user guessing what side a dice roll will land on
    /// with stats to show
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// game played
        /// </summary>
        int gamesPlayed = 0;
        /// <summary>
        /// games won
        /// </summary>
        int gamesWon = 0;
        /// <summary>
        /// games loost
        /// </summary>
        int gamesLost = 0;

        /// <summary>
        /// array that holds frequency of each dice face
        /// helps with percentage
        /// </summary>
        int[] frequency = new int[6];
        /// <summary>
        /// keeps track of total rolls
        /// utilize for percentage
        /// </summary>
        int totalRolls;
        /// <summary>
        /// array that stores what user has guessed and updates
        /// </summary>
        int[] timesGuessed = new int[6];
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// accidentally made this, will mess up the forms if deleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblGuess_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// When user clicks on Roll, picture simulates the dice rolling
        /// Compares final dice number to user's input from textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRollDice_Click(object sender, EventArgs e)
        {
            int guessNum; //for taking in what the user guessed
            //check if user input is valid
            if (string.IsNullOrEmpty(txtGuessBox.Text)) //check if box is empty
            {
                MessageBox.Show("No guess has been entered. Guess a number between 1-6", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //check if between 1-6
            else if (!Int32.TryParse(txtGuessBox.Text, out guessNum) || (guessNum > 6 || guessNum < 1))
            {
                MessageBox.Show("Invalid entry. Please choose a number between 1 and 6.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {

                //create random object
                Random rnd = new Random();
                //allow for image to be stretched
                dicePicture.SizeMode = PictureBoxSizeMode.StretchImage;


                //create variable to show what number the dice will be
                int diceNum = 0;
                for (int i = 1; i < 7; i++)
                {
                    //get random number between 1-6
                    diceNum = rnd.Next(1, 7);
                    //show image of the dice
                    dicePicture.Image = Image.FromFile("die" + diceNum.ToString() + ".gif");
                    //refresh and thread
                    dicePicture.Refresh();
                    Thread.Sleep(300);

                }
                //insert diceNum into frequency
                frequency[diceNum - 1]++;
                totalRolls++; //update total rolls

                //update games played
                gamesPlayed++;
                lblCountPlayed.Text = gamesPlayed.ToString();

                //take user guess and put it in array
                timesGuessed[guessNum - 1]++;

                //determine if user won or lost
                if (Int32.TryParse(txtGuessBox.Text, out guessNum) == true)
                {
                    if (guessNum == diceNum)//update games won
                    {
                        gamesWon++;
                        lblCountWins.Text = gamesWon.ToString();
                    }
                    else //update games lost
                    {
                        gamesLost++;
                        lblCountLoss.Text = gamesLost.ToString();
                    }
                }

            }
            //to display rich text box data
            DisplayResults();
        }
        /// <summary>
        /// Sets Game Info and stats all back to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {   
            //reset labels back to 0
            gamesPlayed = 0;
            lblCountPlayed.Text = gamesPlayed.ToString(); //games played

            gamesWon = 0;
            lblCountWins.Text = gamesWon.ToString(); //games won

            gamesLost = 0;
            lblCountLoss.Text = gamesLost.ToString();  //games lost

            totalRolls = 0;//set rolls to 0

            //set frequency back to 0
            for(int i = 0; i < 6; i++)
            {
                frequency[i] = 0;
                timesGuessed[i] = 0;
            }
            //reset on display
            DisplayResults();
        }
        /// <summary>
        /// Displays the data for the dice roll, frequency, percentage, and 
        /// number of guesses for that dices side
        /// </summary>
        private void DisplayResults()
        {
            //clear display box
            dataTextBox.Clear();
            //append info on top line
            dataTextBox.AppendText("Side:" + "\t" + "\t" + "Frequency:" + "\t" + "\t" + "Percent:" + "\t" + 
                "Number of times guessed:" + "\n");

            
            //update the data
            for(int i = 0; i < 6; i++)
            {
                //calculate percentage
                double percentage = (frequency[i] / (double)totalRolls * 100);
                //display the information
                dataTextBox.AppendText((i + 1) + "\t" + "\t" + "\t" + frequency[i] + "\t" + "\t" + String.Format("{0:f2}", percentage) + "\t" + "\t" + "\t" + timesGuessed[i] + "\n");
            }
        }
    }
}