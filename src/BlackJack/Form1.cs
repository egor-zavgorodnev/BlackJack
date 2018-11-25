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


        private static int startXPos = 259; //Стартовая позиция карт игрока (можно(нужно) менять)
        private static int playerCardYPos = 200; // y-координата карт игрока 
        private int playerCardXPos = startXPos;// Позиция карт игрока, в который будт отрисоваться каты (Егор не трогай!)

        private static int dealerStartXPos = 400;//Стартовая позиция карт дилера (можно(нужно) менять)
        private static int dealerCardYPos = 18; // y-координата карт дилера 
        private int dealerCardXPos = dealerStartXPos;// Позиция карт дилера, в который будт отрисоваться каты (Егор не трогай!)

        private string[] PlayerCardUpdate { get { string[] param = textboxPlayerCards.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); return param; } }//Заносим в массив все карты игрока
        private string[] DealerCardUpdate { get { string[] param = D1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); return param; } }//Заносим в массив все карты игрока

        public List<PictureBox> playerCardsToDisplay; // Объявляем лист  карт для игрока
        public List<PictureBox> dealerCardsToDisplay; // Объявляем лист  карт для дилера
        

        public int totaldealerwithbolckcard = 0;//очки дилера с блокированной картой

        public BlackJack()
        {
            InitializeComponent();
            playerCardsToDisplay = new List<PictureBox>(); // создаем Лист , чтобы заносить рисунки карт игрока
            dealerCardsToDisplay = new List<PictureBox>(); // Создаем Лист , чтобы заносить рисунки карт дилера
            
        }

        Game blackjack = new Game();
        private void BlackJack_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Костыль что бы получить очки только первой карты дилера 
        /// </summary>
        /// <returns></returns>
        public int gettotaldealerwithbolckcard()
        {
            return blackjack.GetTotalDealer() - Game.DealerSecondCard.GetValue(); ;
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            PlayerCardsRemoveAndBackToStartPosition(); DealerCardsRemoveAndBackToStartPosition(); //Очишаем лист с картами игрка  и дилера !!Востанавливаем позицию появления карт игрока и дилера
   
            // Показать все элементы после старта игры
            buttonStatistics.Visible = true;
            label1.Visible = true;
            buttonStatistics.Visible = true;
            label2.Visible = true;
            dealerScore.Visible = true;
            label4.Visible = true;
            dealerScore.Visible = true;
            label6.Visible = true;
            info.Visible = true;
            playerScore.Visible = true;
            labelTitle.Visible = false;
            labelSubtitle.Visible = false;


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
            //Теперь очки только перывой карты дилера 
            dealerScore.Text = gettotaldealerwithbolckcard().ToString();


            HitButton.Visible = true;
            StandButton.Visible = true;

            if (blackjack.PlayerHasA()) //если в картах игрока имеется туз
            {
                labelHasA.Text = "A(1 или 11)"; //выводим соотв текст 
            }

            info.Text = "Берите карты или остановитесь"; //проверка на 21 после начала игры 
            if (blackjack.GetTotalPlayer() == 21) HitButton.Visible = false;

            //Рисуем карты в начале игры
            PlayerCardDraw();
            DealerCardDraw();

            DrawBlockedDealer();

        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            // очищаем label с тузом   
            labelHasA.Text = "";

            blackjack.Hit(Game.PlayerCardsList);

            if (blackjack.PlayerHasA()) //если в картах игрока имеется туз
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
                //Проводим операции над картами дилера 
                DealerCardsRemoveAndBackToStartPosition();
                DealerCardDraw();
                dealerScore.Text = blackjack.GetTotalDealer().ToString();
            }
            // записываем новую карту 
            playerScore.Text = blackjack.GetTotalPlayer().ToString();

            textboxPlayerCards.Text = blackjack.PlayerCards;
            if (blackjack.GetTotalPlayer() == 21) HitButton.Visible = false;

            // При хите отрисововаем карты
            PlayerCardsRemoveAndBackToStartPosition();//Очишаем лист с картами игрка !!Востанавливаем позицию появления карт игрока
            PlayerCardDraw();// Рисуем
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

            // При стенде отрисововаем карты
            DealerCardsRemoveAndBackToStartPosition();//Очишаем лист с картами дилера//!!Востанавливаем позицию появления карт дилера
            DealerCardDraw(); // Рисуем
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Split f = new Split();
            f.Owner = this;
            f.ShowDialog();
            buttonSplit.Visible = false;
            // Я решил сделать по другому , тупо кнопки скрывать при нажатии на сплит(сверхразум) #VS Chat ♥ ♥ ♥
            buttonStatistics.Visible = false;
            HitButton.Visible = false; 
            StandButton.Visible = false;   
            //DealerCardsRemoveAndBackToStartPosition(); // Егор если сделашь, чтоб при сплите закрывалась основная форма , то убери коменты   ♥#VS Chat 20!8♥
            //DealerCardDraw();
             
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            StatsForm f = new StatsForm();
            f.Owner = this;
            f.ShowDialog();             
        }  
         
        /// <summary>
        /// Функция для отрисовки карт
        /// </summary>
        /// <param name="card">передаем карту, которую хотим отрисовать</param>
        private void DrawPlayer(String card)// 
        {
            playerCardXPos += 35;//Расстояние между картами 
            PictureBox newCard = new PictureBox();//Создаем объект класса PictureBox
            Image img = Image.FromFile("../../CardsSprites/" + card + ".png"); //берем саму картинку из папки проекта , пердворительно узнав ее названия
            newCard.Image = img;//присваиваем картинку
            newCard.Location = new System.Drawing.Point(playerCardXPos, playerCardYPos);//Расположение  картинки  менять по можно по Игрик координат
            newCard.Name = "newCard";//хз
            newCard.Size = new System.Drawing.Size(72, 99);// Размер картинки
            this.Controls.Add(newCard);//хз
            newCard.BringToFront();// на верх всего
            playerCardsToDisplay.Add(newCard);//добавляем в лист
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
        /// Функция для отрисовки карт игрока на форму 
        /// </summary>
        private void PlayerCardDraw()
        {
            string[] cardUpdate = PlayerCardUpdate;// заносим в данные в массив
            for (int i = 0; i < cardUpdate.Length; i = i + 2)// циклом берм из массива имена нужных карт и рисуем их
            {
                string card;
                card = cardUpdate[i] + cardUpdate[i + 1];
                DrawPlayer(card);
            }
        }  

        /// <summary>
        /// Функция для отрисовки карт
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
        /// Функция для отрисовки карт на форму 
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
        /// Ну ты понял ;-) чтою вместо двух строк кода, одну писать оптимизация
        /// </summary>
        private void PlayerCardsRemoveAndBackToStartPosition()
        {
            RemoveCards(playerCardsToDisplay);//Очишаем лист с картами игрка 
            playerCardXPos = startXPos;//!!Востанавливаем позицию появления карт игрока
        }
       
        /// <summary>
        /// Ну ты понял ;-) чтою вместо двух строк кода, одну писать оптимизация
        /// </summary>
        private void DealerCardsRemoveAndBackToStartPosition()
        {
            RemoveCards(dealerCardsToDisplay);
            dealerCardXPos = dealerStartXPos;
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
    }
}
   //                                               ♥ We Love Anime♥