using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Spel
{
    public partial class Form1 : Form
    {
        private Random random;
        private int secretNumber;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int maxNumber = Convert.ToInt32(guessTextBox.Text);
            secretNumber = random.Next(0, maxNumber + 1); // skapar slumpmässigt tal

            MessageBox.Show("Ett hemligt tal har slumpats fram. Börja gissa!");
            guessTextBox.Enabled = true;
            guessButton.Enabled = true;
            startButton.Enabled = false;




        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int userGuess = Convert.ToInt32(guessTextBox.Text);

            if (userGuess == secretNumber)
            {
                MessageBox.Show("Grattis! Du gissade rätt!");
                ResetGame();

            }
            else if (userGuess < secretNumber)
            {
                MessageBox.Show("För högt! Försök igen.");

            }
            else
            {
                MessageBox.Show("För högt! Försök igen.");
            }



            guessTextBox.Clear();

            public void ResetGame()
            {
                guessTextBox.Clear();
                guessTextBox.Enabled = false;
                guessButton.Enabled = false;
                startButton.Enabled = true;


            }
        }

        
      
    }
}
