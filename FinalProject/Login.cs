using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string file1, file2;
            string line;
            string username = textBox1.Text;
            SharedInfoAndFunctions.Users = new User(username);
            file1 = $"{username}-group.txt";
            file2 = $"{username}.txt";
            if (File.Exists(file2))
            {
                using (StreamReader filex = new StreamReader(file1))
                {
                    do
                    {
                        line = filex.ReadLine();
                        if (line != null)
                        {
                            SharedInfoAndFunctions.Users.NewGroup(new Group(line));
                        }
                    } while (line != null);
                }
                Hide();
                Home home = new Home();
                home.ShowDialog();
            }
            else
            {
                DialogResult result = MessageBox.Show("Cant find a user with that name. \n Do you want to create a new user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Create a new user and associated files
                    User user = new User(username);
                    StreamWriter GSF = File.CreateText(file1);
                    GSF.Close();
                    StreamWriter SF = File.CreateText(file2);
                    SF.Close();

                    MessageBox.Show("Creating a new user.");
                    Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
            }
        }
    }
}
