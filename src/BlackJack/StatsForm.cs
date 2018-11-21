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
            textBox1.Text = Statistic.GetDealerWins().ToString(); //Побед дилера
            textBox2.Text = Statistic.GetPlayerWins().ToString(); //Побед игрока
            textBox3.Text = Statistic.GetDraws().ToString(); //Ничьих
           
        }
       
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statistic.resetStat();
            textBox1.Text = "0"; textBox2.Text = "0"; textBox3.Text = "0";
            MessageBox.Show("Статистика сброшена!");
            

        }
    }
}
