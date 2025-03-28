using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Group> groups = new List<Group>();
            for (int x = 1; x <= 15; x++)
            {
                string name = $"Group {x}";
                groups.Add(new Group(name));
            }
            foreach (Group group in groups)
            {
                Groups.Items.Add(group.Name);
            }
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();
            newTask.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
