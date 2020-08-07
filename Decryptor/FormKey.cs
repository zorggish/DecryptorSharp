using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Decryptor
{
    public partial class FormKey : Form
    {
        public FormKey()
        {
            InitializeComponent();
        }

        public string key;
        private void buttonApply_Click(object sender, EventArgs e)
        {
            key = keyTextBox.Text;
            this.Close();
        }
    }
}
