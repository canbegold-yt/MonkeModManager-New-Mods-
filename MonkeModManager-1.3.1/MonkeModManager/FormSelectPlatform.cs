using System;
using System.Windows.Forms;

namespace MonkeModManager
{
    public partial class FormSelectPlatform : Form
    {
        new readonly FormMainBG Parent;
        public FormSelectPlatform(FormMainBG parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Parent.platformDetected = true;
            if (radioButtonOculus.Checked)
            {
                Parent.isSteam = false;
            }
            this.Close();
        }
    }
}
