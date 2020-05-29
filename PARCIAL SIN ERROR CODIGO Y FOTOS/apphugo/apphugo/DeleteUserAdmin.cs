using System;
using System.Windows.Forms;

namespace apphugo
{
    public partial class DeleteUserAdmin : UserControl
    {
        public DeleteUserAdmin()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("delete from appuser where username = '" + textBox1.Text + "';");
         
                Conexion.realizarAccion(sql);
         
                MessageBox.Show("eliminado");
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
