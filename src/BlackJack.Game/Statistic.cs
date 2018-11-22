namespace BlackJack
{
    public class Statistic
    { 
        //Статистика  
        private static int dealerWins = 0;
        private static int playerWins = 0;
        private static int draws = 0;

        /// <summary> 
        /// Сброс статистики 
        /// </summary>
        public static void resetStat() 
        {
            dealerWins = 0;
            playerWins = 0; 
            draws = 0;
        }
         
        public static int GetDealerWins()
        {
            return dealerWins;
        }  

        public static int GetPlayerWins()
        {
            return playerWins; 
        }
        public static int GetDraws()
        {
            return draws; 
        }

        public static void AddPlayerWin()
        {
            playerWins++;
        } 
        public static void AddDealerWin()
        { 
            dealerWins++; 
        }
        public static void AddDraw()
        {
            draws++;
        }
  
    }
}