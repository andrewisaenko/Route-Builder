using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route_builder
{
    public partial class Form2 : Form
    {
        private MyDelegate d;
        public Form2(MyDelegate sender)
        {
            InitializeComponent();
            
            d = sender;
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            if (CPnumberTB.Text != "" && Convert.ToInt32(CPnumberTB.Text) > 9 && Convert.ToInt32(CPnumberTB.Text) < 1000)
            {                
                d(CPnumberTB.Text);
                Close();
            }
            else if(Convert.ToInt32(CPnumberTB.Text) < 10 || Convert.ToInt32(CPnumberTB.Text) > 999 || CPnumberTB.Text == "")
            {
                MessageBox.Show("CP number must be two-digit or three-digit");
            }
        }
        private void setCPnumber_but_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)setCPnumber_but.PerformClick();            
        }
    }
}
