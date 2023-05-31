namespace Spel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ResetGame = new Button();
            guessButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            startButton = new Button();
            tbxMinaResultat = new ComboBox();
            guessTextBox = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // ResetGame
            // 
            ResetGame.Location = new Point(282, 124);
            ResetGame.Name = "ResetGame";
            ResetGame.Size = new Size(85, 23);
            ResetGame.TabIndex = 1;
            ResetGame.Text = "Spela igen";
            ResetGame.UseVisualStyleBackColor = true;
           
            // 
            // guessButton
            // 
            guessButton.Location = new Point(240, 252);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(75, 23);
            guessButton.TabIndex = 2;
            guessButton.Text = "Gissa";
            guessButton.UseVisualStyleBackColor = true;
            guessButton.Click += guessButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Speldata";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 86);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Största talet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 169);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Spelet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 193);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Datorns Tal;";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 253);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "Gissa ett tal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 222);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 8;
            label6.Text = "Mina resultat";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // startButton
            // 
            startButton.Location = new Point(282, 82);
            startButton.Name = "startButton";
            startButton.Size = new Size(85, 23);
            startButton.TabIndex = 10;
            startButton.Text = "Starta spelet";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += button1_Click;
            // 
            // tbxMinaResultat
            // 
            tbxMinaResultat.Enabled = false;
            tbxMinaResultat.FormattingEnabled = true;
            tbxMinaResultat.Location = new Point(339, 253);
            tbxMinaResultat.Name = "tbxMinaResultat";
            tbxMinaResultat.Size = new Size(90, 23);
            tbxMinaResultat.TabIndex = 11;
            // 
            // guessTextBox
            // 
            guessTextBox.Location = new Point(122, 250);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(100, 23);
            guessTextBox.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 297);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(guessTextBox);
            Controls.Add(tbxMinaResultat);
            Controls.Add(startButton);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guessButton);
            Controls.Add(ResetGame);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResetGame;
        private Button guessButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Button startButton;
        private ComboBox tbxMinaResultat;
        private TextBox guessTextBox;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}