using System.Diagnostics.Metrics;
using System.Drawing.Text;
using wg = WordGenerator;

namespace FamilyGameNight
{
    public partial class Form1 : Form
    {
        private const int MAX_INCORRECT_GUESSES = 6;

        //list of words:
        private string[] words;
        //private List<string> word2 = new List<string>();


        //dictionary of reused words
        private Dictionary<int, bool> WordUseTracker = new Dictionary<int, bool>();


        private int currentNumberOfIncorrectGuesses = 0;

        //dictionary for guessed letters

        // check if guessed letters contains all letters from the word

        private const string ALL_LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private Dictionary<string, bool> GuessTracker = new Dictionary<string, bool>();
        private Random r;

        public Form1()
        {
            InitializeComponent();
            var wordGenerator = new wg.WordGenerator();
            r = new Random();
            words = wordGenerator.GetWords();
            ResetHangman();

        }

        private void LoadWordList()
        {
            //populate all the possible words for the game
            words[0] = "airplane";
            words[1] = "gypsy";
            words[2] = "abruptly";
            words[3] = "helicopter";
            words[4] = "layrnx";
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetHangman();


            //set it into a global setting



        }

        private void ResetHangman()
        {
            // get a new word
            lblSecretWord.Text = words[r.Next(words.Length - 1)];
            //reset current number of incorrect guesses to 0
            currentNumberOfIncorrectGuesses = 0;
            //BuildBoxes();
            ResetBoxes();
            //enable boxes
            SetBoxes();
            ResetIncorrectGuessBoxes();


            ResetGuessTracker();

            EnableGame(true);
        }

        private void ResetIncorrectGuessBox(TextBox t)
        {
            t.Text = string.Empty;
            t.BackColor = Color.ForestGreen;
            t.ForeColor = Color.White;
            t.Enabled = true;
            t.ReadOnly = false;
        }
        private void ResetIncorrectGuessBoxes()
        {
            ResetIncorrectGuessBox(txtRemainingGuess1);
            ResetIncorrectGuessBox(txtRemainingGuess2);
            ResetIncorrectGuessBox(txtRemainingGuess3);
            ResetIncorrectGuessBox(txtRemainingGuess4);
            ResetIncorrectGuessBox(txtRemainingGuess5);
            ResetIncorrectGuessBox(txtRemainingGuess6);
        }

        private void ResetGuessTracker()
        {
            GuessTracker = new Dictionary<string, bool>();
            foreach (var c in ALL_LETTERS)
            {
                GuessTracker.Add(c.ToString(), false);
            }

        }



        private void ResetBoxes()
        {
            ResetTextBoxes(txtLetter1);
            ResetTextBoxes(txtLetter2);
            ResetTextBoxes(txtLetter3);
            ResetTextBoxes(txtLetter4);
            ResetTextBoxes(txtLetter5);
            ResetTextBoxes(txtLetter6);
            ResetTextBoxes(txtLetter7);
            ResetTextBoxes(txtLetter8);
            ResetTextBoxes(txtLetter9);
            ResetTextBoxes(txtLetter10);
        }
        private void SetBoxes()
        {
            for (int i = 1; i <= lblSecretWord.Text.Length; i++)
            {
                switch (i)
                {
                    case 1:
                        SetBoxForGameplay(txtLetter1);
                        break;
                    case 2:
                        SetBoxForGameplay(txtLetter2);
                        break;
                    case 3:
                        SetBoxForGameplay(txtLetter3);
                        break;
                    case 4:
                        SetBoxForGameplay(txtLetter4);
                        break;
                    case 5:
                        SetBoxForGameplay(txtLetter5);
                        break;
                    case 6:
                        SetBoxForGameplay(txtLetter6);
                        break;
                    case 7:
                        SetBoxForGameplay(txtLetter7);
                        break;
                    case 8:
                        SetBoxForGameplay(txtLetter8);
                        break;
                    case 9:
                        SetBoxForGameplay(txtLetter9);
                        break;
                    case 10:
                        SetBoxForGameplay(txtLetter10);
                        break;

                    default:
                        break;
                }
            }
        }
        private void SetBoxForGameplay(TextBox t)
        {
            t.Visible = true;
        }

        private void ResetTextBoxes(TextBox t)
        {
            t.Text = string.Empty;
            t.Visible = false;
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;

        }

        //private void BuildBoxes()
        //{
        //    //get the word
        //    var word = lblSecretWord.Text;
        //    //number of boxes
        //    var wordLength = word.Length;
        //    //font
        //    var font = new Font("Verdana", 20);

        //    int i = 0;
        //    var offset = 56;
        //    var start = 210;


        //    foreach (char c in word)
        //    {
        //        var left = start + (offset * i);
        //        //create box
        //        TextBox txtBox = new TextBox();
        //        //set it's properties
        //        txtBox.Name = $"txtCharacter{i}";

        //        txtBox.Font = font;
        //        txtBox.TextAlign = HorizontalAlignment.Center;
        //        var point = new Point();
        //        point.X = 210;
        //        point.Y = 56;
        //        txtBox.Location = point;

        //        txtBox.Width = 35;


        //        //add to form
        //        this.Controls.Add(txtBox);
        //        i++;
        //    }
        //}

        private void EnableGame(bool enable)
        {
            txtGuessLetter.Enabled = enable;
            btnSubmitLetter.Enabled = enable;

        }
        private void DisableGame(bool disable)
        {
            txtGuessLetter.Enabled = disable;
            btnSubmitLetter.Enabled = disable;
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here is how you play....");
        }
        private void btnHelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblSecretWord.Visible = !lblSecretWord.Visible;
            }
            if (e.KeyCode == Keys.F2)
            {
                lblSecretWord.Visible = false;
            }
        }


        private void btnSubmitLetter_Click(object sender, EventArgs e)
        {
            //get the letter they are guessing
            //TODO: Constrain the text box to only take one letter
            //      or just take the first letter
            var nextGuess = txtGuessLetter.Text;
            if (string.IsNullOrWhiteSpace(nextGuess))
            {
                MessageBox.Show("You entered a bad guess, please enter A-Z only!");
                return;
            }
            var nextGuessCharacter = nextGuess.Substring(0, 1);



            //MessageBox.Show($"You guessed : {nextGuessCharacter}");



            //Capitalize it
            nextGuessCharacter = nextGuessCharacter.ToUpper();
            //the input should be between A-Z
            var min = 65;
            var max = 90;
            //var nextGuessCharacterAsciiValue = Convert.ToInt32(Convert.ToChar(nextGuessCharacter));
            //if (nextGuessCharacterAsciiValue >= min && nextGuessCharacterAsciiValue <= max)
            //{
            //    MessageBox.Show("You entered a good value!");
            //}
            //else
            //{
            //    MessageBox.Show("You entered a bad value!");
            //}
            if ((Convert.ToChar(nextGuessCharacter) < 'A' && Convert.ToChar(nextGuessCharacter) > 'Z'))
            {
                MessageBox.Show("You entered a bad value! Try Something A-Z");
                return;
            }


            //if (Convert.ToChar(nextGuessCharacter) >= 'A' && Convert.ToChar(nextGuessCharacter) <= 'Z')
            //{
            //    MessageBox.Show("You entered a good value!");
            //}


            //update guess tracker to true
            GuessTracker[nextGuessCharacter] = true;


            //check if it is part of the word
            var secretword = lblSecretWord.Text;
            if (secretword.Contains(nextGuessCharacter, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You got lucky! You correctly guessed a correct letter!");
                DisplayCorrectLetter(nextGuessCharacter);
            }
            else
            {
                MessageBox.Show($"ARRR Matey only land lovers would choose ||{nextGuessCharacter}||! You are one step closer to the plank!");
                RecordIncorrectGuess(nextGuessCharacter);
            }

            txtGuessLetter.Text = string.Empty;
            //TODO: Display
            //if it is part of the word, display letter in the correct place of word

        }
        private void RecordIncorrectGuess(string letter)
        {
            //determine what number of guess that is incorrect this was
            currentNumberOfIncorrectGuesses++;

            // affect appropriate box of incorrect
            MarkIncorrectGuess(letter);

            //is out of guesses display end game (loss)
            if (currentNumberOfIncorrectGuesses == MAX_INCORRECT_GUESSES)
            {
                EndGame(false);
            }

        }
        private void EndGame(bool isWin)
        {
            //disable everything
            EnableGame(false);

            //display a message (win/loss)
            if (isWin)
            {
                //throw a party
                MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //fill in boxes
                FillMissingBoxes();

                //funeral procession
                MessageBox.Show("You Lose!", "Into the Water ye go! Land Lover!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void FillMissingBoxes()
        {

            //what the word is
            int i = 1;
            foreach (var c in lblSecretWord.Text)
            {
                var guessKey = c.ToString().ToUpper();
                var isGuessed = GuessTracker[guessKey];

                if (!isGuessed)
                {
                    UpdateCorrectLetter(guessKey, i, false);
                }
                i++;
            }

            //what they have guessed


            //what letters are missing

        }

        private void MarkIncorrectGuess(string letter)
        {
            switch (currentNumberOfIncorrectGuesses)
            {

                case 1:
                    SetIncorrectTextBox(txtRemainingGuess1, letter);
                    break;
                case 2:
                    SetIncorrectTextBox(txtRemainingGuess2, letter);
                    break;
                case 3:
                    SetIncorrectTextBox(txtRemainingGuess3, letter);
                    break;
                case 4:
                    SetIncorrectTextBox(txtRemainingGuess4, letter);
                    break;
                case 5:
                    SetIncorrectTextBox(txtRemainingGuess5, letter);
                    break;
                case 6:
                    SetIncorrectTextBox(txtRemainingGuess6, letter);
                    break;
            }

        }
        private void SetIncorrectTextBox(TextBox t, string letter)
        {
            //need to fill out color and letter then call to above method
            t.Text = letter;
            t.ForeColor = Color.White;
            t.BackColor = Color.Red;
        }
        private void DisplayCorrectLetter(string letter)
        {
            //find all matches in current word
            int i = 1;
            foreach (var c in lblSecretWord.Text)
            {
                //for each match,
                if (c.ToString().Equals(letter, StringComparison.OrdinalIgnoreCase))
                {

                    UpdateCorrectLetter(letter, i);

                }
                //set the correct box with the letter as text


                i++;
            }
            CheckWinCondtion();
        }
        private void CheckWinCondtion()
        {
            //has each letter in answer been marked as guessed
            for (int i = 0; i < lblSecretWord.Text.Length; i++)
            {
                var isGuessed = GuessTracker[lblSecretWord.Text[i].ToString().ToUpper()];
                if (!isGuessed)
                {
                    return;
                }

                //foreach (string k in GuessTracker.Keys)
                //{
                //    if (k == lblSecretWord.Text[i].ToString())
                //    {
                //        //is the value false?
                //        var isGuessed = GuessTracker[k];
                //        if (!isGuessed)
                //        {

                //        }
                //    }
                //}
            }
            //won
            EndGame(true);

        }
        private void UpdateCorrectLetter(string letter, int boxNumber, bool wasCorrect = true)
        {
            var box = new TextBox();
            switch (boxNumber)
            {

                case 1:
                    box = txtLetter1;
                    break;
                case 2:
                    box = txtLetter2;
                    break;
                case 3:
                    box = txtLetter3;
                    break;
                case 4:
                    box = txtLetter4;
                    break;
                case 5:
                    box = txtLetter5;
                    break;
                case 6:
                    box = txtLetter6;
                    break;
                case 7:
                    box = txtLetter7;
                    break;
                case 8:
                    box = txtLetter8;
                    break;
                case 9:
                    box = txtLetter9;
                    break;
                case 10:
                    box = txtLetter10;
                    break;

                default:
                    break;
            }
            box.Text = letter;
            if (!wasCorrect)
            {
                box.BackColor = Color.Yellow;
                box.ForeColor = Color.Black;
                box.Enabled = true;
                box.ReadOnly = true;
            }
        }

        private void btnHelp_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblSecretWord.Visible = !lblSecretWord.Visible;
            }
            if (e.KeyCode == Keys.F2)
            {
                Solve();
            }
        }
        private void Solve()
        {
            //what the word is
            int i = 1;
            foreach (char c in lblSecretWord.Text)
            {
                UpdateCorrectLetter(c.ToString().ToUpper(), i);

                i++;
            }
        }
    }
}