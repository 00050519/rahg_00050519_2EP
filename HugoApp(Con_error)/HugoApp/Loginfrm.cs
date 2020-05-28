using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace HugoApp
{
    public partial class Loginfrm : Form
    {
        DataTable dt = new DataTable();

        public Loginfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM appuser WHERE username ='" + textBox1.Text + "'and password ='" +
                         textBox2.Text + "'";
            dt = Conexion.realizarConsulta(sql);


            if (dt.Rows.Count > 0)
            {
                string utype = dt.Rows[0][4].ToString();
                /*string passw = dt.Rows[0][3].ToString();
                if (passw == textBox2.Text)
                {*/
                
                    if (utype == "true")
                    {
                          OrdenesCliente ordenesCliente = new OrdenesCliente();
                          this.Hide();
                          ordenesCliente.Show();
                    }
                    else
                    {
                       this.Hide();
                        AdminPanel adminPanel = new AdminPanel(); 
                        adminPanel.Show();
                    }
            }
            else
            { 
                MessageBox.Show("revise sus datos e ingrese de nuevo");
            } 
        }
    }
}