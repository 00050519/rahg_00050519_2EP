using System;
using System.Windows.Forms;

namespace HugoApp
{
    public partial class DeleteUserAdmin : UserControl
    {
        public DeleteUserAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = String.Format("delete from appuser where username = '" + textBox1.Text + "';");
            Conexion.realizarAccion(sql);
        }
    }
}