using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Samples.First
{
    public  partial class FormForFirstTask:Form
    {
        private int rowCount = 0;
        private int colCount = 0;
        public DataGridView gridView { get; set; }
        public TextBox rowInputBox { get; set; }
        public TextBox colInputBox { get; set; }
        public FormForFirstTask()
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;

             gridView = new DataGridView();

             Button runBtn = new Button();
             runBtn.Click += runBtn_Click;
            Button setMatrixBtn = new Button();
            setMatrixBtn.Text = "ввести размеры матрицы";
            runBtn.Text = "Запустить";
            setMatrixBtn.Click += setMatrixBtn_Click;
            rowInputBox = new TextBox();
            colInputBox = new TextBox();
            Controls.Add(gridView);
            gridView.MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            rowInputBox.Location = new Point(0, gridView.Bottom);
            colInputBox.Location = new Point(rowInputBox.Right+30, gridView.Bottom);
            setMatrixBtn.Location = new Point(10, rowInputBox.Bottom);
            runBtn.Location = new Point(10, setMatrixBtn.Bottom+10);
   
            Controls.Add(rowInputBox);
            
            Controls.Add(colInputBox);
            Controls.Add(setMatrixBtn);
            Controls.Add(runBtn);
        }

        private void setMatrixBtn_Click(object sender, EventArgs args)
        {

            gridView.RowCount = int.Parse(rowInputBox.Text);
            gridView.ColumnCount = int.Parse(colInputBox.Text);
            rowCount = gridView.RowCount;
            colCount = gridView.ColumnCount;
        }

        private void runBtn_Click(object sender, EventArgs args)
        {
            int[,] matrix = new int[rowCount, colCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(gridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            string input = string.Format("Максимальный элемент из минимальных по столбцам = {0}", FirstTask.GetMaxFromMin(matrix));
            MessageBox.Show(input);
        }
    }
}
