using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
namespace FlowingIdeas.Presentation
{
    public partial class IdeasFlow : Form
    {
        public static IdeasFlow instance;
        public IdeasFlow()
        {
            InitializeComponent();
            instance = this;
        }
        private UserIdeaBusinessLogic userIdeaBusinessLogic = new UserIdeaBusinessLogic();
        private int editId = 0;

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            WritingYourIdeasHere formWriteIdeas = new WritingYourIdeasHere();
            formWriteIdeas.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdeasFlow_Load(object sender, EventArgs e)
        {

        }
    }
}
