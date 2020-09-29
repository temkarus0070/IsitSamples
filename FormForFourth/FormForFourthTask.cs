using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fourth;

namespace Fourth
{
    public partial class FormForFourthTask : Form
    {
        public FormForFourthTask()
        {
            InitializeComponent();
        }

        private void CallQFromSatelitePlateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SatelitePlate satelitePlate = new SatelitePlate(double.Parse(dFromSatelitePlateTextBox.Text),mFromSatelitePlateTextBox.Text,double.Parse(pFromSatelitePlateTextBox.Text));
                MessageBox.Show(satelitePlate.GetQ().ToString());
            }
            catch(Exception ex)
            {
                
            }
        }

        private void CallQFunctionFromPlateWithSuspensionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var index = suspensionTypeListBox.Items.IndexOf(suspensionTypeListBox.CheckedItems[0]);
                SuspensionType typeForPlate = (SuspensionType)index;
                SatelitePlateWithSuspension satelitePlate = new SatelitePlateWithSuspension(typeForPlate,double.Parse(dForPlateWithSuspensionTextBox.Text), mForPlateWithSuspensionTextBox.Text, double.Parse(pForPlateWithSuspensionTextBox.Text));
                MessageBox.Show(satelitePlate.Q().ToString());
            }
            catch (Exception ex)
            {

            }
        }
    }
}
