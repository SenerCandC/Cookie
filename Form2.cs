using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        public void U_Clik_Click(object sender, EventArgs e)
        {
            if(Form1.PW>=Form1.NeedPointToUpgClick)
            {
                Form1.PW -= Form1.NeedPointToUpgClick;
                Form1.Addpoint += 1;
                Form1.NeedPointToUpgClick += 1;
                Form1.NeedPointToUpgClick *= 2;
                label1.Text = Form1.NeedPointToUpgClick.ToString();
                All_Point.Text = Form1.AllPW.ToString();
                Point.Text = Form1.PW.ToString();
            }
        }
    }
}
