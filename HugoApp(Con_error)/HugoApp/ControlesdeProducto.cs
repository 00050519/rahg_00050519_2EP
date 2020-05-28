using System;
using System.Windows.Forms;

namespace HugoApp
{
    public partial class ControlesdeProducto : UserControl
    {
        public ControlesdeProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (businessIdTextbox.Text.Equals("")|| pnameTextbox.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar casillas en blanco.");
            }
            else
            {
                try
                {
                    
                    Conexion.realizarAccion("INSERT INTO public.product(idbusiness, name)" +
                                            "VALUES('"+Int32.Parse(businessIdTextbox.Text)+"','"+pnameTextbox.Text+"');");
            
                    MessageBox.Show("Ha sido registrado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("delete from product where name = '"+pnameTextbox.Text+
                                           "' and idbusiness = '"+Int32.Parse(businessIdTextbox.Text)+"';");
                    Conexion.realizarAccion(sql);

                MessageBox.Show("borrado exitoso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ha ocurrido un error", ex.ToString());
            }
        }
    }
}