using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        const int refreshRate = 100;
        public Thread th1;
        public static int AllPW = 0;
        public static int PW = 0;
        public static int Addpoint = 1;
        public static int NeedPointToUpgClick = 1;

        public Form1()
        {
            InitializeComponent();
            th1 = new Thread(Refresh);
            th1.Start();

        }
        public void Refresh()
        {
            while (true)
            {
                this.All_Point.BeginInvoke((MethodInvoker)delegate () { this.All_Point.Text = AllPW.ToString(); });
                this.Point.BeginInvoke((MethodInvoker)delegate () { this.Point.Text = PW.ToString(); });
                Thread.Sleep(refreshRate);
            }
        }



        public void Click_Click(object sender, EventArgs e)
        {
            AllPW += Addpoint;
            PW += Addpoint;
            //All_Point.Text = AllPW.ToString();
            //Point.Text = PW.ToString();
            ShowAddPW.Text = Addpoint.ToString();

        }

        public void Upgrades_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            th1.Abort();
        }
    }
}
