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
    public partial class DZ7_2 : Form
    {
        public DZ7_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadacha7 zadacha7 = new Zadacha7();
            zadacha7.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DZ7_1 dZ7_1 = new DZ7_1();
            dZ7_1.Show();
            this.Close();
        }
    }
}
