﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        Tab tab;
        public Form2(Tab tab)
        {
            InitializeComponent();
            init();
            this.tab = tab;
        }
        void init()
        {
            this.TopMost = true;
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.No;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tab.Tabname = textBox1.Text;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}