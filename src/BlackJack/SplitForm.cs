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


        private static int Game1startXPos = 59; //Стартовая позиция карт Game1 игрока (можно(нужно) менять)
        private static int Game1playerCardYPos = 250; // y-координата карт Game1 игрока 
        private int Game1playerCardXPos = Game1startXPos;// Позиция карт Game1 игрока, в который будт отрисоваться каты (Егор не трогай!)

        private static int Game2startXPos = 400; //Стартовая позиция карт Game2 игрока (можно(нужно) менять)
        private static int Game2playerCardYPos = 250; // y-координата карт Game2 игрока 
        private int Game2playerCardXPos = Game2startXPos;// Позиция карт Game2 игрока, в который будт отрисоваться каты (Егор не трогай!)


        private static int dealerStartXPos = 400;//Стартовая позиция карт дилера (можно(нужно) менять)
        private static int dealerCardYPos = 18; // y-координата карт дилера 
        private int dealerCardXPos = dealerStartXPos;// Позиция карт дилера, в который будт отрисоваться каты (Егор не трогай!)

        private string[] Game1PlayerCardUpdate { get { string[] param = textboxPlayerCards.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); return param; } }//Заносим в массив все карты игрока
        private string[] Game2PlayerCardUpdate { get { string[] param = textboxPlayerCards2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); return param; } }//Заносим в массив все карты игрока
        private string[] DealerCardUpdate { get { string[] param = D1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); return param; } }//Заносим в массив все карты дилера

        public List<PictureBox> Game1playerCardsToDisplay; // Объявляем лист  карт для Game1 игрока
        public List<PictureBox> Game2playerCardsToDisplay; // Объявляем лист  карт для Game2 игрока

        public List<PictureBox> dealerCardsToDisplay; // Объявляем лист  карт для дилера
         

        public Split()
        {
            InitializeComponent();
            Game1playerCardsToDisplay = new List<PictureBox>(); // создаем Лист , чтобы заносить рисунки карт Game1 игрока
            Game2playerCardsToDisplay = new List<PictureBox>(); // создаем Лист , чтобы заносить рисунки карт Game2 игрока
            dealerCardsToDisplay = new List<PictureBox>(); // Создаем Лист , чтобы заносить рисунки карт дилера

        }

        SplitGame game1 = new SplitGame();
        SplitGame game2 = new SplitGame();

        /// <summary>
        /// Костыль что бы получить очки только первой карты дилера 
        /// </summary>
        /// <returns></returns>
        public int gettotaldealerwithbolckcard()
        {
            return game2.GetTotalDealer() - Game.DealerSecondCard.GetValue(); ;
        }

        /// <summary>
        /// Инициализация при загрузке формы  
        /// </summary>  
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void Split_Load(object sender, EventArgs e)
        {


            // Начало 1 и второй игры 
            game1.SplitGame1Start();

            game2.SplitGame2Start();

            // очки игрока (игра 1)
            playerScore.Text = game1.GetTotalPlayer().ToString();
            textboxPlayerCards.Text = game1.PlayerCards;

            // очки игрока (игра 2) 
            playerScore2.Text = game2.GetTotalPlayer().ToString();
            textboxPlayerCards2.Text = game2.PlayerCards;

            // выводим очки дилера 
            dealerScore.Text = gettotaldealerwithbolckcard().ToString();
            D1.Text = game2.DealerCards;


            //выводим кнопки hit и stand 
            HitButton1.Visible = true;
            StandButton1.Visible = true;

            if (game1.PlayerHasA()) //если в картах игрока имеется туз
            {
                labelHasA1.Text = "A(1 или 11)"; //выводим соотв текст 
            }

            //Рисуем ууууу
            Game1PlayerCardDraw();
            Game2PlayerCardDraw();
            DealerCardDraw();
            DrawBlockedDealer();

        }

        private void HitButton1_Click_1(object sender, EventArgs e)
        {
            game1.Hit(game1.PlayerCardsList_Split1);

            // очищаем label с тузом  
            labelHasA.Text = "";

            if (game1.PlayerHasA()) //если в картах игрока имеется туз
            {
                labelHasA1.Text = "A(1 или 11)"; //выводим соотв текст 
            }

            if (game1.IsOverflow()) //если перебор у игрока 
            {
                // присуждаем победу дилеру, заканчиваем игру 
                //dealersWinsText.Text = Statistic.GetDealerWins().ToString(); 
                info1.Text = "Победа дилера! Перебор у игрока";

                //выводим на форму карты игрока 
                textboxPlayerCards2.Text = game2.PlayerCards;
                
                // и очки  
                playerScore2.Text = game2.GetTotalPlayer().ToString();
                

                //выводим кнопки hit2 и stand2    
                HitButton2.Visible = true;
                StandButton2.Visible = true;

                // очищаем label с тузом  
                labelHasA1.Text = "";

                //скрываем hit1 и stand1
                HitButton1.Visible = false;
                StandButton1.Visible = false;

                if (game2.PlayerHasA()) //если в картах игрока имеется туз
                {
                    labelHasA2.Text = "A(1 или 11)"; //выводим соотв текст 
                }
            }

            // записываем новую карту 
            playerScore.Text = game1.GetTotalPlayer().ToString();
            textboxPlayerCards.Text = game1.PlayerCards;
            // скрываем кнопку hit при 21 
            if (game1.GetTotalPlayer() == 21) HitButton1.Visible = false;

            //Комент
            Game1PlayerCardsRemoveAndBackToStartPosition();
            Game1PlayerCardDraw();
        }

        private void StandButton1_Click_1(object sender, EventArgs e)
        {

            //выводим кнопки hit2 и stand2     
            HitButton2.Visible = true;
            StandButton2.Visible = true;

            // очищаем label с тузом  
            labelHasA1.Text = "";
             
            //скрываем hit1 и stand1
            HitButton1.Visible = false;
            StandButton1.Visible = false;

            if (game2.PlayerHasA()) //если в картах игрока имеется туз
            {
                labelHasA2.Text = "A(1 или 11)"; //выводим соотв текст 
            }
            // скрываем кнопку hit при 21
            if (game2.GetTotalPlayer() == 21) HitButton2.Visible = false;

        }

        private void HitButton2_Click_1(object sender, EventArgs e)
        {
            game2.Hit(game2.PlayerCardsList_Split2);
             
            // очищаем label с тузом  
            labelHasA.Text = "";

            if (game2.PlayerHasA()) //если в картах игрока имеется туз
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

                // При стенде отрисововаем карты
                DealerCardsRemoveAndBackToStartPosition();//Очишаем лист с картами дилера//!!Востанавливаем позицию появления карт дилера
                DealerCardDraw(); // Рисуем

            }

            // записываем новую карту 
            playerScore2.Text = game2.GetTotalPlayer().ToString();
            textboxPlayerCards2.Text = game2.PlayerCards;
            // скрываем кнопку hit при 21 
            if (game2.GetTotalPlayer() == 21) HitButton2.Visible = false;

            //Комент
            Game2PlayerCardsRemoveAndBackToStartPosition();
            Game2PlayerCardDraw();
        }

        private void StandButton2_Click_1(object sender, EventArgs e)
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
            // При стенде отрисововаем карты
            DealerCardsRemoveAndBackToStartPosition();//Очишаем лист с картами дилера//!!Востанавливаем позицию появления карт дилера
            DealerCardDraw(); // Рисуем

        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            BlackJack main = Owner as BlackJack;
            if (main != null)
            {
                main.HitButton.Visible = false;
                main.StandButton.Visible = false;
                main.buttonSplit.Visible = false; 

                main.buttonStatistics.Visible = true;
                main.newGame.Visible = true;

            } 



            Close();
        }

        /// <summary>
        /// Функция для отрисовки карт Game1
        /// </summary>
        /// <param name="card">передаем карту, которую хотим отрисовать</param>
        private void Game1DrawPlayer(String card)// 
        {
            Game1playerCardXPos += 35;//Расстояние между картами 
            PictureBox newCard = new PictureBox();//Создаем объект класса PictureBox
            Image img = Image.FromFile("../../CardsSprites/" + card + ".png"); //берем саму картинку из папки проекта , пердворительно узнав ее названия
            newCard.Image = img;//присваиваем картинку
            newCard.Location = new System.Drawing.Point(Game1playerCardXPos, Game1playerCardYPos);//Расположение  картинки  менять по можно по Игрик координат
            newCard.Name = "newCard";//хз
            newCard.Size = new System.Drawing.Size(72, 99);// Размер картинки
            this.Controls.Add(newCard);//хз
            newCard.BringToFront();// на верх всего
            Game1playerCardsToDisplay.Add(newCard);//добавляем в лист
        }

        /// <summary>
        /// Функция для отрисовки карт Game1 игрока на форму 
        /// </summary>
        private void Game1PlayerCardDraw()
        {
            string[] cardUpdate = Game1PlayerCardUpdate;// заносим в данные в массив
            for (int i = 0; i < cardUpdate.Length; i = i + 2)// циклом берм из массива имена нужных карт и рисуем их
            {
                string card;
                card = cardUpdate[i] + cardUpdate[i + 1];
                Game1DrawPlayer(card);
            }
        }

        /// <summary>
        /// Функция для отрисовки карт Game2
        /// </summary>
        /// <param name="card">передаем карту, которую хотим отрисовать</param>
        private void Game2DrawPlayer(String card)// 
        {
            Game2playerCardXPos += 35;//Расстояние между картами 
            PictureBox newCard = new PictureBox();//Создаем объект класса PictureBox
            Image img = Image.FromFile("../../CardsSprites/" + card + ".png"); //берем саму картинку из папки проекта , пердворительно узнав ее названия
            newCard.Image = img;//присваиваем картинку
            newCard.Location = new System.Drawing.Point(Game2playerCardXPos, Game2playerCardYPos);//Расположение  картинки  менять по можно по Игрик координат
            newCard.Name = "newCard";//хз
            newCard.Size = new System.Drawing.Size(72, 99);// Размер картинки
            this.Controls.Add(newCard);//хз
            newCard.BringToFront();// на верх всего
            Game2playerCardsToDisplay.Add(newCard);//добавляем в лист
        }

        /// <summary>
        /// Функция для отрисовки карт Game2 игрока на форму 
        /// </summary>
        private void Game2PlayerCardDraw()
        {
            string[] cardUpdate = Game2PlayerCardUpdate;// заносим в данные в массив
            for (int i = 0; i < cardUpdate.Length; i = i + 2)// циклом берм из массива имена нужных карт и рисуем их
            {
                string card;
                card = cardUpdate[i] + cardUpdate[i + 1];
                Game2DrawPlayer(card);
            }
        }

        /// <summary>
        /// Функция для очистки карт с формы
        /// </summary>
        /// <param name="cardImages">передаем лист с картами который хотим убрать</param>
        private void RemoveCards(List<PictureBox> cardImages)
        {
            foreach (PictureBox box in cardImages)//удаляем все изоображения 
            {
                this.Controls.Remove(box);
            }
        }

        /// <summary>
        /// Функция для отрисовки карт дилера
        /// </summary>
        /// <param name="card">пердаем карту, которую хотим отрисовать</param>
        private void DrawDealer(string card)
        {
            dealerCardXPos -= 35;//Расстояние между картами 
            PictureBox newCard = new PictureBox();//Создаем объект класса PictureBox
            Image img = Image.FromFile("../../CardsSprites/" + card + ".png");//берем саму картинку из папки проекта , пердворительно узнав ее названия
            newCard.Image = img;//присваиваем картинку
            newCard.Location = new System.Drawing.Point(dealerCardXPos, dealerCardYPos);
            newCard.Name = "newCard";
            newCard.Size = new System.Drawing.Size(72, 99);// Размер картинки
            this.Controls.Add(newCard);
            newCard.BringToFront();// на верх всего
            dealerCardsToDisplay.Add(newCard);//добавляем в лист
        }

        /// <summary>
        /// Функция для отрисовки карт дилера на форму 
        /// </summary>
        private void DealerCardDraw()
        {
            string[] cardUpdate = DealerCardUpdate;// заносим в данные в массив
            for (int i = 0; i < cardUpdate.Length; i = i + 2)// циклом берем из массива имена нужных карт и рисуем их
            {
                string card;
                card = cardUpdate[i] + cardUpdate[i + 1];
                DrawDealer(card);
            }
        }


        /// <summary>
        /// Рисуем Закрытую карту 
        /// </summary>
        private void DrawBlockedDealer()
        {
            dealerCardXPos -= 35;//Расстояние между картами 
            PictureBox newCard = new PictureBox();//Создаем объект класса PictureBox
            Image img = Image.FromFile("../../CardsSprites/b2fv.png");//берем саму картинку из папки проекта , пердворительно узнав ее названия
            newCard.Image = img;//присваиваем картинку
            newCard.Location = new System.Drawing.Point(329, 18);
            newCard.Name = "newCard";
            newCard.Size = new System.Drawing.Size(72, 99);// Размер картинки
            this.Controls.Add(newCard);
            newCard.BringToFront();// на верх всего   
        }

        /// <summary>
        /// Ну ты понял ;-) чтою вместо двух строк кода, одну писать оптимизация
        /// </summary>
        private void Game1PlayerCardsRemoveAndBackToStartPosition()
        {
            RemoveCards(Game1playerCardsToDisplay);//Очишаем лист с картами игрка 
            Game1playerCardXPos = Game1startXPos;//!!Востанавливаем позицию появления карт игрока
        }

        /// <summary>
        /// Ну ты понял ;-) чтою вместо двух строк кода, одну писать оптимизация
        /// </summary>
        private void Game2PlayerCardsRemoveAndBackToStartPosition()
        {
            RemoveCards(Game2playerCardsToDisplay);//Очишаем лист с картами игрка 
            Game2playerCardXPos = Game2startXPos;//!!Востанавливаем позицию появления карт игрока
        }

        /// <summary>
        /// Ну ты понял ;-) чтою вместо двух строк кода, одну писать оптимизация
        /// </summary>
        private void DealerCardsRemoveAndBackToStartPosition()
        {
            RemoveCards(dealerCardsToDisplay);
            dealerCardXPos = dealerStartXPos;
        }

    }
}

