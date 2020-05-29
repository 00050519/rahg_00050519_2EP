using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace apphugo
{
    public partial class MakeOrder : UserControl
    {
        public MakeOrder()
        {
            InitializeComponent();
            cargarnegocios();
        }

        public void cargarnegocios()
        {
            NpgsqlConnection con = new NpgsqlConnection("Server = 127.0.0.1; Port = 5432; userId = postgres;   password = A$APMOB; Database = hugodatabase;");
            con.Open();
            
            NpgsqlCommand cmd = new NpgsqlCommand("select idbusiness, name from BUSINESS;",con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
             DataRow fila = dt.NewRow();
             con.Close();
                         fila["name"] = "selecciona un negocio";
                         dt.Rows.InsertAt(fila,0);
             
                         comboBox1.ValueMember = "idbusiness";
                         comboBox1.DisplayMember = "name";
                         comboBox1.DataSource = dt;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select idbusiness from BUSINESS where name = '" + comboBox1.Text + "'";

            var dt = Conexion.realizarConsulta(sql);
            var dr = dt.Rows[0];
            var idbusiness = Convert.ToInt32(dr[0].ToString());
            

            string sql2 = "select name from PRODUCT where idbusiness = '"+idbusiness+"' ;";
            var product =Conexion.realizarConsulta(sql2);

            var combo3product = new List<string>();

            foreach (DataRow dr2 in product.Rows)
            {
                combo3product.Add(dr2[0].ToString());
            }

            comboBox3.DataSource = combo3product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select iduser from APPUSER where username = '" + textBox1.Text + "';";
            var dt =Conexion.realizarConsulta(sql);
            var dr = dt.Rows[0];
            var iduser = Convert.ToInt32(dr[0].ToString());

            string sql2 = "select address from ADDRESS where iduser = '" + iduser + "';";
            var direccion = Conexion.realizarConsulta(sql2);
            
            var combo4direccion = new List<string>();

            foreach (DataRow dr2 in direccion.Rows)
            {
                combo4direccion.Add(dr2[0].ToString());
            }

            comboBox4.DataSource = combo4direccion;



        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = $"select idaddress from address where address = '{comboBox4.SelectedItem.ToString()}'";
                    
            

            
            var dt = Conexion.realizarConsulta(sql);
            var dr = dt.Rows[0];
            var idaddress = Convert.ToInt32(dr[0].ToString());

            string sql2 =
                $"select idproduct from PRODUCT where name = '{comboBox3.SelectedItem.ToString()}'";
            var dt2 = Conexion.realizarConsulta(sql2);
                         var dt3 = dt2.Rows[0];
                         var productid = Convert.ToInt32(dt3[0].ToString());
                         
                         DateTimePicker date2 = new DateTimePicker();
                         
             
                         //string sql3 = String.Format();
                         Conexion.realizarAccion($"INSERT INTO APPORDER( createdate, idproduct, idaddress) VALUES (" +
                                                 $"'{dateTimePicker1.Value}' ," +
                                                 $"'{productid}' ," +
                                                 $"{idaddress})");

                         MessageBox.Show("pedido exitoso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("pedido exitoso");
            }

            
            
            
        }
    }
}