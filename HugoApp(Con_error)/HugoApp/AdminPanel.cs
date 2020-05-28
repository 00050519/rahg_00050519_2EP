﻿using System;
using System.Windows.Forms;

namespace HugoApp
{
    public partial class AdminPanel : Form
    {
        private UserControl current;
        public AdminPanel()
        {
            InitializeComponent();
            AddUserAdmin addUserAdmin = new AddUserAdmin();
            current = addUserAdmin;

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
                        current = new AddUserAdmin();
                        current.Dock=DockStyle.Fill;
                        current.AutoSizeMode=AutoSizeMode.GrowAndShrink;
                        tableLayoutPanel1.Controls.Add(current,1,1);
                        tableLayoutPanel1.SetColumnSpan(current,1);
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
        
    }
}