using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apphugo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            Loginfrm loginfrm = new Loginfrm();
            this.Hide();
            loginfrm.Show();
        }

        private void REGISTRARSE_Click(object sender, EventArgs e)
        {
            Registerfrm registerfrm = new Registerfrm();
            this.Hide();
            registerfrm.Show();
        }
    }
}