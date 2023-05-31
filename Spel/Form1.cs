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
            int maxNumber = Convert.ToInt32(comboBox1.Text);
            secretNumber = random.Next(0, maxNumber + 1); // skapar slumpmässigt tal

            MessageBox.Show("Ett hemligt tal har slumpats fram. Börja gissa!");
            guessTextBox.Enabled = true;
            guessButton.Enabled = true;
            startButton.Enabled = false;





        }

        public void guessButton_Click(object sender, EventArgs e)
        {
            int userGuess = Convert.ToInt32(guessTextBox.Text);

            if (userGuess == secretNumber)
            {
                textBox1.Text = "Grattis du gissade rätt tal";
                ResetGame(sender);
                textBox3.Text = secretNumber.ToString();
                startaom.Enabled = true;
                listBox1.Items.Add("Användarn vann");


            }
            else if (userGuess < secretNumber)
            {
                textBox1.Text = ("För lågt! Försök igen.");
                textBox3.Text = secretNumber.ToString();
                startaom.Enabled = true;
                listBox1.Items.Add("Datorn vann");

            }
            else
            {
                textBox1.Text = ("För högt! Försök igen.");
                textBox3.Text = secretNumber.ToString();
                startaom.Enabled = true;
                listBox1.Items.Add("Datorn vann");
            }



            guessTextBox.Clear();


        }
        public void ResetGame(object sender)
        {
            guessTextBox.Clear();
            guessTextBox.Enabled = false;
            guessButton.Enabled = false;
            startButton.Enabled = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            guessTextBox.Clear();
            guessTextBox.Enabled = false;
            guessButton.Enabled = false;
            startButton.Enabled = true;
        }
    }
}
