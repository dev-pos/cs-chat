﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeChat
{
    public partial class ucMain : UserControl
    {
        public ucMain()
        {
            InitializeComponent();
        }

        private void listOnline_Click(object sender, EventArgs e)
        {
            frmSend frm = new frmSend();
            frm.Show();
        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {
            UpdateProfile up2 = new UpdateProfile();
            up2.Show();
        }
    }
}
