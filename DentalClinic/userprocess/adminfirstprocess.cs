﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.userprocess
{
    public partial class adminfirstprocess : MetroFramework.Forms.MetroForm
    {
        public adminfirstprocess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diagnosis d = new Diagnosis();
            d.ShowDialog();
        }
    }
}
