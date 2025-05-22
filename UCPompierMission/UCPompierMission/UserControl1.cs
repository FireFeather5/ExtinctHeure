using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCPompierMission
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(string Engin, string pompier)
        {
            InitializeComponent();

            lblEng.Text = Engin;
            lblPomp.Text = pompier;
        }
    }
}
