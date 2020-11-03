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
    public partial class AddQuote : Form
    {
        private Form _mainMenue;

        public AddQuote(Form mainMenue)
        {
            InitializeComponent();

            _mainMenue = mainMenue;

            //populate serfacematerial combo box
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                .Cast<DesktopMaterial>()
                .ToList();

            ServiceMaterial.DataSource = materials;

            //set default value to empty
            ServiceMaterial.SelectedIndex = -1;


        }

       /* private void SaveQuote_Click(object sender, EventArgs e)
        {
            var newDesk = new Desk();

            newDesk.depth = numDeskDepth.Value;
            newDesk.depth = numDeskWidth.Value;

        }*/

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenue.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
