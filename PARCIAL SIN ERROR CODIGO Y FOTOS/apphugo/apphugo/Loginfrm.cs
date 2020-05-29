using System;
using System.Data;
using System.Windows.Forms;

namespace apphugo
{
    public partial class Loginfrm : Form
    {
        DataTable dt = new DataTable();
        public Loginfrm()
        {
            InitializeComponent();
            
        }
        
         
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM appuser WHERE username ='" + textBox1.Text + "'and password ='" +
                                             textBox2.Text + "'";
            dt = Conexion.realizarConsulta(sql);
                    
                    
            if (dt.Rows.Count > 0)
            {
                
                string type = dt.Rows[0][4].ToString().Trim();
                
                if (type == "true")
                {
                     this.Hide();
                     AdminPanel adminPanel = new AdminPanel(); 
                    adminPanel.Show();
                }
                else
                {
                   OrdenesCliente ordenesCliente = new OrdenesCliente();
                    this.Hide(); 
                    ordenesCliente.Show();
                }
            }else 
            { 
                MessageBox.Show("revise sus datos e ingrese de nuevo");
            } 
            
        }
    }
}
