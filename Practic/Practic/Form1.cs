using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic
{
    public partial class Form1 : Form
    {
        ProgressBar[] pb;
      
        public Form1()
        {
            
            InitializeComponent();
            pb = new ProgressBar[]
            {
                progressBar1,
                progressBar2,
                progressBar3

            };
            Text = "Бронирование столиков";

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tableNumvber = Convert.ToInt32(btn.Tag.ToString());
            ProgressBar table = pb[tableNumvber];
            if (table.Value != table.Maximum)
            {
                table.Value++;
                label1.Text = "За столиком " + (tableNumvber + 1).ToString()
                                + " осталось " + (table.Maximum - table.Value).ToString() 
                                + " мест";
                button4.Enabled = true;
            }
            else
            {
                label1.Text = "Весь стол занят";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            foreach (var item in pb)
            {
                
                item.Value = 0;
            }
            button4.Enabled = false;
        }
    }
}
