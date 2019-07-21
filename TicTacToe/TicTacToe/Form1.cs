using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public enum Player
        {                     //o clasa (enum) cu doua valori X si 0 
            X, O              //cu aceasta vom controla / schimba simbolurile jucatorilor
        }

        Player currentPlayer;
        List<Button> buttons;
        Random random = new Random();
        int playerWins = 0;
        int computerWins = 0;

       
        public Form1()
        {
            InitializeComponent();
            ResetGame();           //metoda care va reseta jocul atunci cand acesta va incepe
        }

        private void PlayerClick(object sender, EventArgs e)   //metoda Event a player-ului (Click pe buton)
        {
            var button = (Button)sender;                       //afla ce buton s-a apasat
            currentPlayer = Player.X;                          //seteaza playerul cu X
            button.Text = currentPlayer.ToString();            //schimba textul de pe buton cu X
            button.Enabled = false;                            //dezactiveaza butonul dupa ce s-a apasat
            button.BackColor = System.Drawing.Color.Cyan;      //schimba culoarea butonului apasat
            buttons.Remove(button);                         /*sterge butonul din lista de butoane pentru ca urmatorul 
                                                              player sa nu il poata apasa din nou*/
            Check();                                           //verifica daca playerul a castigat
            ComputerMoves.Start();                             //porneste Timer-ul pentru Computer (player2)
        }

        private void ComputerMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);  //genereaza un nr random din nr de butoane
                buttons[index].Enabled = false;          //asigneaza nr butonului
                currentPlayer = Player.O;                //seteaza computerul cu O
                buttons[index].Text = currentPlayer.ToString();  //scrie O pe buton
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon;  //schimba culoarea butonului dupa ce a fost apasat
                buttons.RemoveAt(index);                 //elimina butonul din lista
                Check();                                 //verifica daca computerul a castigat ceva
                ComputerMoves.Stop();                    //opreste timer-ul computerului
            }
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void LoadButtons()
        {
            buttons = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8 };
        }

        private void ResetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "?";
                    ((Button)X).BackColor = default(Color);
                }
            }
            LoadButtons();
        }

        private void Check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" 
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X" 
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                ComputerMoves.Stop();                   //opreste timer-ul
                MessageBox.Show("Player Wins!");        //afiseaza un mesaj
                playerWins++;                           //incrementeaza nr de victorii
                label1.Text = "Player Wins - " + playerWins;   //update player label
                ResetGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                ComputerMoves.Stop();                   //opreste timer-ul
                MessageBox.Show("Computer Wins!");        //afiseaza un mesaj
                computerWins++;                           //incrementeaza nr de victorii
                label2.Text = "Computer Wins - " + computerWins;   //update computer label
                ResetGame();
            }
        }
    }
}
