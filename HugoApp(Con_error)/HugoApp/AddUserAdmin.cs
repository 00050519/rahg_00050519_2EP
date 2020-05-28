using System;
using System.Windows.Forms;

namespace HugoApp
{
    public partial class AddUserAdmin : UserControl
    {
        public AddUserAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                textBox1.Text.Equals("") || 
                textBox2.Text.Equals("") ||
                comboBox1.Text.Equals("")) 
            {
                MessageBox.Show("No puede dejar casillas en blanco.");
            }
            else
            {
                try
                {
                    Conexion.realizarAccion("INSERT INTO public.appuser(fullname, username, password, userType)" + "VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox2.Text +
                                            "','" +
                                            comboBox1.Text + "')");
                    MessageBox.Show("Ha sido registrado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}