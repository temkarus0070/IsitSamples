﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using First;
using Second;

namespace Samples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunFirstBtn_Click(object sender, EventArgs e)
        {
            Win32.AllocConsole();
            Three.Runner.Run();
            Win32.FreeConsole();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            First.FormForFirstTask form = new First.FormForFirstTask();
            form.Show();
        }
		void SecondRunBtnClick(object sender, EventArgs e)
		{
				 FormForSecondTask form = new Second.FormForSecondTask();
			form.Show();
		}

        private void RunFourthBtn_Click(object sender, EventArgs e)
        {
            Fourth.FormForFourthTask form = new Fourth.FormForFourthTask();
            form.Show();
        }
    }
}
