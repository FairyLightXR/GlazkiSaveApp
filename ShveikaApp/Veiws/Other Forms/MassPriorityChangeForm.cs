using ShveikaApp.Model;
using ShveikaApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShveikaApp.Veiws.Other_Forms
{
    public partial class MassPriorityChangeForm : Form
    {
        public MassPriorityChangeForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int TxtBoxValue = Convert.ToInt32(textBox1.Text);
            foreach (AgentCard agentCard in MainForm.Selectedcards)
            {
                Agent ag = (DbContext.Model.Agent.First(a => a.ID == Convert.ToInt32(agentCard.IDLbl.Text)));
                ag.Priority = TxtBoxValue;

            }

            try
            {
                DbContext.Model.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
            }
            MainForm.Selectedcards.Clear();
        }

        private void CamcelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            MainForm.Selectedcards.Clear();
        }

        private void MassPriorityChangeForm_Load(object sender, EventArgs e)
        {
            int max = 0;
            foreach (AgentCard prior in MainForm.Selectedcards)
            {
                int priority = int.Parse(prior.PriorityLbl.Text);
                if (priority>max)
                {
                    max = priority;
                }
            }
            textBox1.Text = max.ToString();

        }
    }
}
