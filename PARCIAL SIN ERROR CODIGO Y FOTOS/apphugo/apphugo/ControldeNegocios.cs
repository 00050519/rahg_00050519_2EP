using System;
using System.Windows.Forms;

namespace apphugo
{
    public partial class ControldeNegocios : UserControl
    {
        public ControldeNegocios()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
                {if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                                     {
                                         MessageBox.Show("No puede dejar casillas en blanco.");
                                     }
                                     else
                                     {
                                         try
                                         {
                                             Conexion.realizarAccion("INSERT INTO public.business(name, description)" +
                                                                     "VALUES('" + textBox1.Text + "','" + textBox2.Text + "')");
                         
                                             MessageBox.Show("Ha sido registrado");
                                         }
                                         catch (Exception ex)
                                         {
                                             MessageBox.Show("Ha ocurrido un error");
                                         }
                                     }
                }

                private void button2_Click_1(object sender, EventArgs e)
                {
                    string sql = String.Format("delete from business where name = '" + textBox3.Text + "';");
                                                    Conexion.realizarAccion(sql);
                }
    }
}