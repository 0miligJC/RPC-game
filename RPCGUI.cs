using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPC_game.Properties; 

namespace RPC_game
{
    public partial class RPCGUI : Form
    {
        private Dictionary<string, Image> imagePaths; 
        private string[] moves = { "Rock", "Paper", "Scissor" };
        private int currentIndex;
        private Random rnd;

        public RPCGUI()
        {
            InitializeComponent();
            InitializeImagePaths();
            rnd = new Random();
        }

        private void InitializeImagePaths()
        {
           
            imagePaths = new Dictionary<string, Image>()
            {
                { "Rock", Resources.Rock },   
                { "Paper", Resources.Paper },
                { "Scissor", Resources.Scissor }
            };
        }

        private void StartRolling()
        {
            currentIndex = 0; 
            Timer timer = new Timer
            {
                Interval = 100 // Change image every 100 milliseconds
            };
            timer.Tick += (sender, e) =>
            {
                // Set the image from the moves array using the Image from the dictionary
                Npc.Image = imagePaths[moves[currentIndex]];

                // Update the index to show the next image
                currentIndex++;
                if (currentIndex >= moves.Length)
                {
                    currentIndex = 0; // Loop back to the first image
                }
            };

            timer.Start(); 

           
            Task.Delay(2000).ContinueWith(_ =>
            {
                timer.Stop(); // Stop the timer after 2 seconds
                SetNpcMove(); // Show the final move
            });
        }

        private void SetNpcMove()
        {
            string npcMove = moves[rnd.Next(moves.Length)]; // Get a random move
            plyrChoice.Text = plyrChoice.Text.ToUpper(); // Ensure player choice is uppercase

            // Check if the move exists in the imagePaths dictionary
            if (imagePaths.TryGetValue(npcMove, out Image image))
            {
                Npc.Image = image; // Directly set the image
                DetermineWinner(npcMove); // Call the method to determine the winner
            }
            else
            {
                MessageBox.Show("Invalid move!");
            }
        }

        private void DetermineWinner(string npcMove)
        {
            string playerChoice = plyrChoice.Text;

            // Determine the result
            string resultMessage;
            if (playerChoice == npcMove.ToUpper())
            {
                resultMessage = "DRAW!";
            }
            else if ((playerChoice == "ROCK" && npcMove == "Scissor") ||
                     (playerChoice == "SCISSOR" && npcMove == "Paper") ||
                     (playerChoice == "PAPER" && npcMove == "Rock"))
            {
                resultMessage = "YOU WIN!";
            }
            else
            {
                resultMessage = "YOU LOST";
            }

            // Update the RESULTS label with the game result on the UI thread
            if (RESULTS.InvokeRequired)
            {
                RESULTS.Invoke(new Action(() => this.RESULTS.Text = resultMessage));
            }
            else
            {
                this.RESULTS.Text = resultMessage;
            }
        }

        private void rockBt_Click(object sender, EventArgs e)
        {
            plyrChoice.Text = "ROCK";
            StartRolling();
        }

        private void paperBt_Click(object sender, EventArgs e)
        {
            plyrChoice.Text = "PAPER";
            StartRolling();
        }

        private void scissorBt_Click(object sender, EventArgs e)
        {
            plyrChoice.Text = "SCISSOR";
            StartRolling();
        }
    }
}
