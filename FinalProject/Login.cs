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
            string file;
            string line;
            string username = textBox1.Text;
            SharedInfoAndFunctions.Users = new User(username);
            file = $"{username}.txt";
            if (File.Exists(file))
            {
                using (StreamReader file1 = new StreamReader(file))
                {
                    do
                    {
                        line = file1.ReadLine();
                        if (line != null)
                        {
                            string[] parts = line.Split(',');
                        }
                    } while (line != null) ;
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
                    User user = new User(username);
                    File.CreateText(file);

                    MessageBox.Show("Creating a new user.");
                    Hide();
                    Home home = new Home();
                    home.ShowDialog();
                    
                }
            }
        }
    }
}
