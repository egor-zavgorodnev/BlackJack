using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class BlackJack : Form 
    {
        public BlackJack()
        { 
            InitializeComponent(); 
        }

        Game blackjack = new Game();
        private void BlackJack_Load(object sender, EventArgs e)
        {

        }
         
        private void newGame_Click(object sender, EventArgs e)
        {
            // очищаем label с тузом  
            labelHasA.Text = ""; 
            blackjack.EndGame();   
            blackjack.GameStart(); 

            buttonSplit.Visible = false;
            if (blackjack.SplitCheck())
            {
                buttonSplit.Visible = true;
            }
                


            //выводим на форму первые 2 карты дилера и игрока 
            D1.Text = blackjack.DealerCards;                    
            textboxPlayerCards.Text = blackjack.PlayerCards;
            // их очки
            playerScore.Text = blackjack.GetTotalPlayer().ToString();
            dealerScore.Text = blackjack.GetTotalDealer().ToString();
              
            //скрываем label с текстом Jack и выводим кнопки hit и stand 
            invisLabel.Visible = false;
            HitButton.Visible = true;  
            StandButton.Visible = true;

            if (blackjack.HasA()) //если в картах игрока имеется туз
            {
                labelHasA.Text = "A(1 или 11)"; //выводим соотв текст 
            }   
             
            info.Text = "Берите карты или остановитесь"; //проверка на 21 после начала игры 
            if (blackjack.GetTotalPlayer() == 21) HitButton.Visible = false;
        } 

        private void HitButton_Click(object sender, EventArgs e)
        {
            blackjack.Hit();

            if (blackjack.HasA()) //если в картах игрока имеется туз
            {
                labelHasA.Text = "A(1 или 11)"; //выводим соотв текст 
            }

            if (buttonSplit.Visible == true) 
                buttonSplit.Visible = false;

            if (blackjack.IsOverflow()) //если перебор у игрока 
            { 
                // присуждаем победу дилеру, заканчиваем игру 
                //dealersWinsText.Text = Statistic.GetDealerWins().ToString(); 
                info.Text = "Победа дилера! Перебор у игрока"; 
                HitButton.Visible = false;
                StandButton.Visible = false;  
            }  
             // записываем новую карту 
            playerScore.Text = blackjack.GetTotalPlayer().ToString(); 
            textboxPlayerCards.Text = blackjack.PlayerCards;
            if (blackjack.GetTotalPlayer() == 21) HitButton.Visible = false;
        }
         
        private void StandButton_Click(object sender, EventArgs e)
        { 
            blackjack.DealerMove(); 
            //выводим очки и карты дилера
            dealerScore.Text = blackjack.GetTotalDealer().ToString();
            D1.Text = blackjack.DealerCards;
            //сообщение о конце игры
            info.Text = blackjack.EndMessage();   
            // очищаем label с тузом  
            labelHasA.Text = "";   
            // скрываем кнопки  
            HitButton.Visible = false;   
            StandButton.Visible = false;

        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            Split f = new Split();
            f.Owner = this; 
            f.ShowDialog();

        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Побед дилера: " + Statistic.GetDealerWins().ToString() + "\n" +
               "Побед игрока: " + Statistic.GetPlayerWins().ToString() + "\n" +
               "Ничьих: " + Statistic.GetDraws().ToString() + "\n"+
               "Нажмите Отмена, чтобы сбросить",
               "Статистика",  
               MessageBoxButtons.OKCancel); 

            if (result == DialogResult.Cancel) 
            { 
                Statistic.resetStat();
                MessageBox.Show("Статистика сброшена!");
            }
                 
        }  
    }       
} 
   