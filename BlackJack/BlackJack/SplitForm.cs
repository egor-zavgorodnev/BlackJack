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
    public partial class Split : Form
    {
        public Split() 
        { 
            InitializeComponent();
        }
         
        Game game1 = new Game();
        Game game2 = new Game();

        private void Split_Load(object sender, EventArgs e)
        {
            game1.GameStartForPlayer();

            //выводим на форму первые 2 карты игрока  
            textboxPlayerCards.Text = game1.PlayerCards; 
            // его очки
            playerScore.Text = game1.GetTotalPlayer().ToString();
              
            //выводим кнопки hit и stand 
            HitButton1.Visible = true;
            StandButton1.Visible = true; 

            if (game1.HasA()) //если в картах игрока имеется туз
            {
                labelHasA1.Text = "A(1 или 11)"; //выводим соотв текст 
            } 
              
        }

        private void HitButton1_Click(object sender, EventArgs e)
        {
            game1.Hit();

            if (game1.HasA()) //если в картах игрока имеется туз
            {
                labelHasA1.Text = "A(1 или 11)"; //выводим соотв текст 
            }

            if (game1.IsOverflow()) //если перебор у игрока 
            {
                // присуждаем победу дилеру, заканчиваем игру 
                //dealersWinsText.Text = Statistic.GetDealerWins().ToString(); 
                info1.Text = "Победа дилера! Перебор у игрока";
                 
                game2.GameStart(); 

                //выводим на форму первые 2 карты игрока и дилера 
                textboxPlayerCards2.Text = game2.PlayerCards; 
                D1.Text = game1.DealerCards;
                // их очки  
                playerScore2.Text = game2.GetTotalPlayer().ToString();
                dealerScore.Text = game1.GetTotalDealer().ToString();

                //выводим кнопки hit2 и stand2    
                HitButton2.Visible = true;
                StandButton2.Visible = true;

                // очищаем label с тузом  
                labelHasA1.Text = "";

                //скрываем hit1 и stand1
                HitButton1.Visible = false;
                StandButton1.Visible = false;

                if (game2.HasA()) //если в картах игрока имеется туз
                {
                    labelHasA2.Text = "A(1 или 11)"; //выводим соотв текст 
                } 
            }
 
            // записываем новую карту 
            playerScore.Text = game1.GetTotalPlayer().ToString();
            textboxPlayerCards.Text = game1.PlayerCards; 
        }

        private void StandButton1_Click(object sender, EventArgs e)
        {
            game2.GameStart(); 
               
            //выводим на форму первые 2 карты игрока и дилера 
            textboxPlayerCards2.Text = game2.PlayerCards;
            D1.Text = game1.DealerCards;
            // их очки  
            playerScore2.Text = game2.GetTotalPlayer().ToString();
            dealerScore.Text = game1.GetTotalDealer().ToString();

            //выводим кнопки hit2 и stand2    
            HitButton2.Visible = true;
            StandButton2.Visible = true;

            // очищаем label с тузом  
            labelHasA1.Text = "";
 
            //скрываем hit1 и stand1
            HitButton1.Visible = false; 
            StandButton1.Visible = false;

            if (game2.HasA()) //если в картах игрока имеется туз
            {
                labelHasA2.Text = "A(1 или 11)"; //выводим соотв текст 
            }
  
        } 

        private void HitButton2_Click(object sender, EventArgs e)
        {
            game2.Hit();
             
            if (game2.HasA()) //если в картах игрока имеется туз
            {
                labelHasA2.Text = "A(1 или 11)"; //выводим соотв текст 
            }
              
            if (game2.IsOverflow()) //если перебор у игрока 
            {
                game2.SplitDealerMove();
                //выводим очки и карты дилера
                dealerScore.Text = game2.GetTotalDealer().ToString();
                D1.Text = game2.DealerCards;
                //сообщение о конце игры 
                info2.Text = game2.EndMessage();
                // очищаем label с тузом  
                labelHasA.Text = "";
                // скрываем кнопки  
                HitButton2.Visible = false;
                StandButton2.Visible = false;

                // делаем totaldealer общим для двух игр 
                game1.totaldealer = game2.totaldealer;
                game1.EndCheck();
                info1.Text = game1.EndMessage();

                buttonClose.Visible = true; 
            } 

            // записываем новую карту 
            playerScore2.Text = game2.GetTotalPlayer().ToString();
            textboxPlayerCards2.Text = game2.PlayerCards;

        } 

        private void StandButton2_Click(object sender, EventArgs e)
        { 
            game2.SplitDealerMove(); 
            //выводим очки и карты дилера
            dealerScore.Text = game2.GetTotalDealer().ToString();
            D1.Text = game2.DealerCards;
            //сообщение о конце игры 
            info2.Text = game2.EndMessage();
            // очищаем label с тузом  
            labelHasA.Text = ""; 
            // скрываем кнопки  
            HitButton2.Visible = false; 
            StandButton2.Visible = false; 

            // делаем totaldealer общим для двух игр 
            game1.totaldealer = game2.totaldealer;
            game1.EndCheck(); 
            info1.Text = game1.EndMessage();

            buttonClose.Visible = true;
             
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            BlackJack main = Owner as BlackJack;
            if (main != null)
            { 
                main.HitButton.Visible = false;
                main.StandButton.Visible = false;
                main.buttonSplit.Visible = false;
            }

            Close();
        }
    }    
}    
  