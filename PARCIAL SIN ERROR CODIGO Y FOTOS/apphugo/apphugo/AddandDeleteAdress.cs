using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace apphugo
{
    public partial class AddandDeleteAdress : UserControl
    {
        public AddandDeleteAdress()
        {
            InitializeComponent();
        }

        private void addAddressButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var iduser = Conexion.realizarConsulta("select iduser from appuser where username= '" + textBox1.Text + "';");

            var dt = iduser.Rows[0];
            var userid = Convert.ToInt32(dt[0].ToString());
            

        if (textBox1.Text.Equals("")|| textBox2.Text.Equals(""))
           { 
               MessageBox.Show("No puede dejar casillas en blanco.");
           }
           else 
           { 
               try 
               { 
                   Conexion.realizarAccion("INSERT INTO public.ADDRESS(iduser, address) VALUES('"+userid+"', '"+textBox2.Text+"')");
           
                   MessageBox.Show("Ha sido registrado");
               } 
               catch (Exception ex)
               {
                   MessageBox.Show("Ha ocurrido un error", ex.ToString());
               }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt= Conexion.realizarConsulta("select address from ADDRESS;");

            foreach (DataRow dr in dt.Rows) 
            { 
                comboBox1.Items.Add(dr["address"].ToString());
            }
        }


        private void DeleteAddressButton_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "delete from ADDRESS where address= '" + comboBox1.Text + "';";
                Conexion.realizarAccion(sql);
                MessageBox.Show("Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

        }
    }
}