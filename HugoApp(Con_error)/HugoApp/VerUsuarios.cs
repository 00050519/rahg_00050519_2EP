﻿using System;
using System.Data;
using System.Windows.Forms;

namespace HugoApp
{
    public partial class VerUsuarios : UserControl
    {
        public VerUsuarios()
        {
            InitializeComponent();
        }

       private void VerUsuarios_Load(object sender, EventArgs e)
        {
            /*string sql = "SELECT * FROM APPUSER;";

            var dt= Conexion.realizarConsulta(sql);*/
            
            try
            {
                var dt =Conexion.realizarConsulta($"SELECT fullname, username, usertype " +
                                                                   "FROM APPUSER");
                dataGridView1.DataSource = dt;
                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }
            
        }
    }
}