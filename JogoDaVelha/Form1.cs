using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        private bool playerX = true;
        private int moves = 0;
        private Button[,] board;
        private int round = 1;
        private int playerXwins = 0;
        private int playerOwins = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeBoard();
            UpdateStatusLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeBoard()
        {
            board = new Button[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = new Button();
                    board[row, col].Size = new System.Drawing.Size(50, 50);
                    board[row, col].Location = new System.Drawing.Point(50 * col, 50 * row);
                    board[row, col].Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    board[row, col].Click += new EventHandler(Button_Click);
                    Controls.Add(board[row, col]);
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "" && moves < 9)
            {
                button.Text = playerX ? "X" : "O";
                playerX = !playerX;
                moves++;
                CheckWinner();
                if (moves == 9)
                {
                    MessageBox.Show("Empate", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    round++;
                    ResetBoard();
                    UpdateStatusLabel();
                }
            }
        }

        private void CheckWinner()
        {
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0].Text != "" && board[row, 0].Text == board[row,1].Text && board[row, 1].Text == board[row, 2].Text)
                {
                    MessageBox.Show(board[row, 0].Text + " Ganhou!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (board[row, 0].Text == "X")
                    {
                        playerXwins++;
                    }
                    else
                    {
                        playerOwins++;
                    }
                    round++;
                    ResetBoard();
                    UpdateStatusLabel();
                    return;
                }
            }
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col].Text != "" && board[0, col].Text == board[1, col].Text && board[1, col].Text == board[2, col].Text)
                {
                    MessageBox.Show(board[0, col].Text + " Ganhou!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (board[0, col].Text == "X")
                    {
                        playerXwins++;
                    }
                    else
                    {
                        playerOwins++;
                    }
                    round++;
                    ResetBoard();
                    UpdateStatusLabel();
                    return;
                }
            }
            if (board[0, 0].Text != "" && board[0, 0].Text == board[1, 1].Text && board[1, 1].Text == board[2, 2].Text)
            {
                MessageBox.Show(board[0, 0].Text + " Ganhou!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (board[0, 0].Text == "X")
                {
                    playerXwins++;
                }
                else
                {
                    playerOwins++;
                }
                round++;
                ResetBoard();
                UpdateStatusLabel();
                return;
            }
            if (board[0, 2].Text != "" && board[0, 2].Text == board[1, 1].Text && board[1, 1].Text == board[2, 0].Text)
            {
                MessageBox.Show(board[0, 2].Text + " Ganhou!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (board[0, 2].Text == "X")
                {
                    playerXwins++;
                }
                else
                {
                    playerOwins++;
                }
                round++;
                ResetBoard();
                UpdateStatusLabel();
                return;
            }
        }


        private void ResetBoard()
        {
            foreach (Button button in board)
            {
                button.Text = "";
            }
            playerX = true;
            moves = 0;

        }
        private void UpdateStatusLabel()
        {
            label1.Text = $"Round: {round}, Palyer X wins: {playerXwins}, Player O Winds: {playerOwins}";
        }

    }
}
