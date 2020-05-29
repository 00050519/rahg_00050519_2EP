using System;
using System.Windows.Forms;

namespace apphugo
{
    public partial class Registerfrm : Form
    {
        public Registerfrm()
        {
            InitializeComponent();
        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                comboBox1.Text.Equals("")
            )
            {
                MessageBox.Show("No puede dejar casillas en blanco.");
            }
            else
            {
                try
                {
                    Conexion.realizarAccion("INSERT INTO public.APPUSER(fullname, username, password, userType)" +
                                            "VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +
                                            "','" +
                                            comboBox1.Text + "')");

                    MessageBox.Show("Ha sido registrado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error", ex.ToString());
                }
            }
        }
    }
}