namespace BlackJack
{
    public class Statistic
    { 
        //Статистика  

        public static int DealerWins { get; private set; } = 0;
        public static int PlayerWins { get; private set; } = 0;
        public static int Draws { get; private set; } = 0;


        /// <summary>         
        /// Сброс статистики     
        /// </summary>  
        public static void resetStat()   
        {
            DealerWins = 0;
            PlayerWins = 0; 
            Draws = 0;
        }
          
        public static void AddPlayerWin()
        {
            PlayerWins++;
        } 
        public static void AddDealerWin() 
        { 
            DealerWins++;  
        }
        public static void AddDraw()
        {
            Draws++;
        }
  
    }
} 