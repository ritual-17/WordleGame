namespace Wordle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Guess34_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Count.counter = 0;
            WinStatus.won = false;
            Generated.gen = true;
            
            Random rnd = new Random();
            int num = rnd.Next(0, Word.words.Length);
            Word.word = Word.words[num];
            
            WinText.Text = "";
            Guesser.Text = "";

            //assigning each label square to a Guess List
            Guesses.guessOne = new Label[] { Guess11, Guess12, Guess13, Guess14, Guess15 };
            Guesses.guessTwo = new Label[] { Guess21, Guess22, Guess23, Guess24, Guess25 };
            Guesses.guessThree = new Label[] { Guess31, Guess32, Guess33, Guess34, Guess35 };
            Guesses.guessFour = new Label[] { Guess41, Guess42, Guess43, Guess44, Guess45 };
            Guesses.guessFive = new Label[] { Guess51, Guess52, Guess53, Guess54, Guess55 };
            Guesses.guessSix = new Label[] { Guess61, Guess62, Guess63, Guess64, Guess65 };



            Label[][] allGuesses = new Label[][] { Guesses.guessOne, Guesses.guessTwo, Guesses.guessThree, Guesses.guessFour, Guesses.guessFive, Guesses.guessSix };

            foreach (Label[] guess in allGuesses)
            {
                foreach (Label square in guess)
                {
                    square.BackColor = Color.DarkGray;
                    square.Text = "   ";
                }
            }
            
                

        }

        private void Guesser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (Guesser.Text.Length == 5 && WinStatus.won == false && Generated.gen == true)
            {
                Count.counter++;
                
                string word = Word.word;
                char[] wordGuess = Guesser.Text.ToUpper().ToCharArray();
                
                
                Label[] thisGuess = Guesses.guessOne;

                switch (Count.counter)
                {
                    case 1:
                        thisGuess = Guesses.guessOne;
                        break;
                    case 2:
                        thisGuess = Guesses.guessTwo;
                        break;
                    case 3:
                        thisGuess = Guesses.guessThree;
                        break;
                    case 4:
                        thisGuess = Guesses.guessFour;
                        break;
                    case 5:
                        thisGuess = Guesses.guessFive;
                        break;
                    case 6:
                        thisGuess = Guesses.guessSix;
                        break;


                }


                if (word[0] == wordGuess[0])
                {
                    thisGuess[0].BackColor = Color.LimeGreen;
                }
                else
                {
                    if (word.Contains(wordGuess[0]))
                    {
                        thisGuess[0].BackColor = Color.Gold;
                    }

                }
                if (word[1] == wordGuess[1])
                {
                    thisGuess[1].BackColor = Color.LimeGreen;
                }
                else
                {
                    if (word.Contains(wordGuess[1]))
                    {
                        thisGuess[1].BackColor = Color.Gold;
                    }

                }
                if (word[2] == wordGuess[2])
                {
                    thisGuess[2].BackColor = Color.LimeGreen;
                }
                else
                {
                    if (word.Contains(wordGuess[2]))
                    {
                        thisGuess[2].BackColor = Color.Gold;
                    }
                }

                if (word[3] == wordGuess[3])
                {
                    thisGuess[3].BackColor = Color.LimeGreen;
                }
                else
                {
                    if (word.Contains(wordGuess[3]))
                    {
                        thisGuess[3].BackColor = Color.Gold;
                    }

                }
                if (word[4] == wordGuess[4])
                {
                    thisGuess[4].BackColor = Color.LimeGreen;
                }
                else
                {
                    if (word.Contains(wordGuess[4]))
                    {
                        thisGuess[4].BackColor = Color.Gold;
                    }

                }

                thisGuess[0].Text = wordGuess[0].ToString();
                thisGuess[1].Text = wordGuess[1].ToString();
                thisGuess[2].Text = wordGuess[2].ToString();
                thisGuess[3].Text = wordGuess[3].ToString();
                thisGuess[4].Text = wordGuess[4].ToString();

                if (word == Guesser.Text.ToUpper())
                {
                    WinText.Text = "You Win";
                    WinStatus.won = true;
                }
                else if (word != Guesser.Text.ToUpper() && Count.counter == 6)
                {
                    WinText.Text = $"Word: {Word.word}";
                }
                Guesser.Text = "";
            }
            else if (WinStatus.won || Generated.gen == false)
            {
                WinText.Text = "Generate New Word!";
            }
            else
            {
                Guesser.Text = "Enter a 5 Letter Word";
            }
            
        }

        private void Guess11_Click(object sender, EventArgs e)
        {

        }

        private void WinText_Click(object sender, EventArgs e)
        {

        }

        private void Guess14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Guess15_Click(object sender, EventArgs e)
        {

        }
    }
}