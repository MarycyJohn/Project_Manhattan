using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektMaster
{
    public partial class Glow : Form
    {
        List<Autko> autko = new List<Autko>();
        public Glow()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            Okno_search.DataSource = autko;
            Okno_search.DisplayMember = "FullInfo";
        }


        private void Search_button_Click(object sender, EventArgs e)
        {
            Dostep db = new Dostep();

            autko = db.GetAutko(Okno_search.Text);
            UpdateBinding();

        }

        private void Glow_Load(object sender, EventArgs e)
        {

        }
    }
}
