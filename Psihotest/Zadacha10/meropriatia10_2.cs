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
    public partial class meropriatia10_2 : Form
    {
        public meropriatia10_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadacha10 zadacha10 = new Zadacha10();
            zadacha10.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meropriatia10_1 meropriatia10_1 = new meropriatia10_1();
            meropriatia10_1.Show();
            this.Close();
        }
    }
}
