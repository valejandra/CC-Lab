﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC_Lab
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void muestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMuestra().ShowDialog(this);
        }
    }
}
