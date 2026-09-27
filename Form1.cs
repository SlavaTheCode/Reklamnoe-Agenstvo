using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Reklamnoe_Agenstvo
{
    public partial class Frm_First : Form
    {
        Thread thread;
        public Frm_First()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(open1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void open1() { Application.Run(new Frm_Admin()); }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(open2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void open2() { Application.Run(new Form2()); }
    }
}
