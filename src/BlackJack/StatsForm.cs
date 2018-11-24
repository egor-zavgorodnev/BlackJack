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
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        } 

       

        private void StatsForm_Load(object sender, EventArgs e)
        {
            labelDW.Text = Statistic.DealerWins.ToString(); //Побед дилера
            labelPW.Text = Statistic.PlayerWins.ToString(); //Побед игрока
            labelDraws.Text = Statistic.Draws.ToString(); //Ничьих
        } 
            
         
          
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Statistic.resetStat();

            labelDW.Text = String.Empty;
            labelPW.Text = String.Empty;
            labelDraws.Text = String.Empty;

            MessageBox.Show("Статистика сброшена!");
 
        }
    }
}
