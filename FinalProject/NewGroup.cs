using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class NewGroup : Form
    {
        
        public NewGroup()
        {
            InitializeComponent();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            bool found = false;
            if (name != "")
            {
                for(int i = 0; i < SharedInfoAndFunctions.Users.Groups.Count; i++)
                {
                    if (SharedInfoAndFunctions.Users.Groups[i].Name == name)
                    {
                        MessageBox.Show("This group already exists.");
                        i = SharedInfoAndFunctions.Users.Groups.Count;
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }
                if (!found)
                {
                    SharedInfoAndFunctions.Users.NewGroup(new Group(name));
                    Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("The name box can't be empty.");
            }
        }
        private void BTNCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
