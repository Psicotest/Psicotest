﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psihotest
{
    public partial class DZ10_2 : Form
    {
        public DZ10_2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DZ10_1 DZ10_1 = new DZ10_1();
            DZ10_1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadacha10 zadacha10 = new Zadacha10();
            zadacha10.Show();
            this.Close();
        }
    }
}
