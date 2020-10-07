using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Willits
{
    public partial class MegaDesk : Form
    {
        public MegaDesk()
        {
            InitializeComponent();
        }

        private void MegaDesk_Load(object sender, EventArgs e)
        {

        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            var addQuote = new AddQuote(this);
            addQuote.Show();

            this.Hide();
            
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            var viewAllQuotes = new ViewAllQuotes(this);
            viewAllQuotes.Show();

            this.Hide();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
