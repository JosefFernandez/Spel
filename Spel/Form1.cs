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
            secretNumber = random.Next(0, maxNumber + 1); // skapar slumpm�ssigt tal

            MessageBox.Show("Ett hemligt tal har slumpats fram. B�rja gissa!");
            guessTextBox.Enabled = true;
            guessButton.Enabled = true;
            startButton.Enabled = false;




        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int userGuess = Convert.ToInt32(guessTextBox.Text);

            if (userGuess == secretNumber)
            {
                MessageBox.Show("Grattis! Du gissade r�tt!");
                ResetGame();

            }
            else if (userGuess < secretNumber)
            {
                MessageBox.Show("F�r h�gt! F�rs�k igen.");

            }
            else
            {
                MessageBox.Show("F�r h�gt! F�rs�k igen.");
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
