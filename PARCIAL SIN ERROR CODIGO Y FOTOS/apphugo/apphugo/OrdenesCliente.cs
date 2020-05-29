using System;
using System.Windows.Forms;

namespace apphugo
{
    public partial class OrdenesCliente : Form
    {
        private UserControl current;
        public OrdenesCliente()
        {
            InitializeComponent();
        }

        private void Direcciones_Click(object sender, EventArgs e)
        {
            AddandDeleteAdress addandDeleteAdress = new AddandDeleteAdress();
            tableLayoutPanel1.Controls.Remove(current); 
            current = addandDeleteAdress; 
            current.Dock=DockStyle.Fill; 
            current.AutoSizeMode=AutoSizeMode.GrowAndShrink; 
            tableLayoutPanel1.Controls.Add(current,1,1); 
            tableLayoutPanel1.SetColumnSpan(current,1);
        }

        private void RealizarPedidoButton_Click(object sender, EventArgs e)
        {
            MakeOrder makeOrder = new MakeOrder();
            tableLayoutPanel1.Controls.Remove(current); 
            current = makeOrder; 
            current.Dock=DockStyle.Fill; 
            current.AutoSizeMode=AutoSizeMode.GrowAndShrink; 
            tableLayoutPanel1.Controls.Add(current,1,1);
            tableLayoutPanel1.SetColumnSpan(current,1);
        }
    } 
}