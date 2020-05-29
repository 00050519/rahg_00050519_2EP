using System;
using System.Windows.Forms;

namespace apphugo
{
    public partial class dgvPersonas : UserControl
    {
        public dgvPersonas()
        {
            InitializeComponent();
            Conexion.cargarPersonas(dgv);
        }


        
    }
}