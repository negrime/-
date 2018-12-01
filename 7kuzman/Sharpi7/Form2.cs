using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharpi7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


      
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }

        public string StudentFIO
        {
            get { return NewStudent.Text; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
}
