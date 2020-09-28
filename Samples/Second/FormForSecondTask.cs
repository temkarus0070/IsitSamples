/*
 * Created by SharpDevelop.
 * User: pretkov_a_i
 * Date: 24.09.2020
 * Time: 13:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Samples.Second
{
	/// <summary>
	/// Description of FormForSecondTask.
	/// </summary>
	public partial class FormForSecondTask : Form
	{
		private string path;
		
		public FormForSecondTask()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void OpenBtnClick(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName!="")
				path = openFileDialog1.FileName;
				
		}
		void SaveBtnClick(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			if(saveFileDialog1.FileName!="")
				Second.StringWorker(path,saveFileDialog1.FileName)
		}
	}
}
