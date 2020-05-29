using System;
using System.Windows.Forms;
using Npgsql;

namespace apphugo
{
    public partial class AdminPanel : Form
    {


        private UserControl current;
                public AdminPanel()
                { 
                    InitializeComponent();
                    AddUserAdmin addUserAdmin = new AddUserAdmin();
                    current = addUserAdmin;
                    this.Show(addUserAdmin);
                }
                
                private void deleteButton_Click(object sender, EventArgs e)
                {
                    DeleteUserAdmin deleteUserAdmin = new DeleteUserAdmin();
                    
                    tableLayoutPanel1.Controls.Remove(current);
                    current = deleteUserAdmin; 
                    current.Dock=DockStyle.Fill; 
                    current.AutoSizeMode=AutoSizeMode.GrowAndShrink; 
                    tableLayoutPanel1.Controls.Add(current,1,1); 
                    tableLayoutPanel1.SetColumnSpan(current,1);
                }
        
        
                private void businessControls_Click(object sender, EventArgs e)
                {
                    ControldeNegocios controldeNegocios = new ControldeNegocios();
                    
                    tableLayoutPanel1.Controls.Remove(current);
                    current = controldeNegocios; 
                    current.Dock=DockStyle.Fill; 
                    current.AutoSizeMode=AutoSizeMode.GrowAndShrink; 
                    tableLayoutPanel1.Controls.Add(current,1,1); 
                    tableLayoutPanel1.SetColumnSpan(current,1);
                }
        
                private void productControlsbutton_Click(object sender, EventArgs e)
                {
                    ControlesdeProducto controlesdeProducto = new ControlesdeProducto();
                    
                    tableLayoutPanel1.Controls.Remove(current);
                    current = controlesdeProducto; 
                    current.Dock=DockStyle.Fill; 
                    current.AutoSizeMode=AutoSizeMode.GrowAndShrink; 
                    tableLayoutPanel1.Controls.Add(current,1,1); 
                    tableLayoutPanel1.SetColumnSpan(current,1);
                }


                private void addUserButton_Click(object sender, EventArgs e)
                {
                    AddUserAdmin addUserAdmin = new AddUserAdmin();                 
                    tableLayoutPanel1.Controls.Remove(current); 
                    current = addUserAdmin; 
                    current.Dock=DockStyle.Fill; 
                    current.AutoSizeMode = AutoSizeMode.GrowAndShrink; 
                    tableLayoutPanel1.Controls.Add(current,1,1); 
                    tableLayoutPanel1.SetColumnSpan(current,1);
                }

                private void ViewDatabutton_Click(object sender, EventArgs e)
                {
                    dgvPersonas dgvPersonas = new dgvPersonas();                
                    tableLayoutPanel1.Controls.Remove(current); 
                    current = dgvPersonas; 
                    current.Dock=DockStyle.Fill; 
                    current.AutoSizeMode = AutoSizeMode.GrowAndShrink; 
                    tableLayoutPanel1.Controls.Add(current,1,1);
                    tableLayoutPanel1.SetColumnSpan(current,1);
                    

                }
    }
}