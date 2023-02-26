using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ParentForm : Form
    {
        public const int Width_Danger = 505;
        public const int Height_Danger = 208;
        public ParentForm()
        {
            InitializeComponent();
        }

        private void btnSizeUp_Click(object sender, EventArgs e)
        {
            this.Height = this.Height + 10;
            this.Width = this.Width + 10;
        }

        private void buttonSIzeDown_Click(object sender, EventArgs e)
        {
            if (((this.Height - 10) > Height_Danger) && ((this.Width - 10) > Width_Danger))
            {
                this.Height = this.Height - 10;
                this.Width = this.Width - 10;
            }
        }
    }
}
