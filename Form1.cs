using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExelApplication
{
    public partial class Form1 : Form
    {

        Data data;
        string OldTextBoxExpression = String.Empty;
        string currentFileName;
        public Form1()
        {
            InitializeComponent();
            data = new Data(dataGridView1);
            this.Text = "MyExcel";
        }

        internal Data Data
        {
            get => default(Data);
            set { }
        }

        


        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Value.ToString()))
            {
                data.ChangeData(e.Value.ToString(), e.RowIndex, e.ColumnIndex);
            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

    

        private void filetoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                var selectedCell = dataGridView1.SelectedCells[0];
                textBox1.Text = Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Expression;
                OldTextBoxExpression = textBox1.Text;


            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Data.cells[e.RowIndex][e.ColumnIndex].Expression != null)
                if (!String.IsNullOrEmpty(Data.cells[e.RowIndex][e.ColumnIndex].Error))
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Data.cells[e.RowIndex][e.ColumnIndex].Error;
                else
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Data.cells[e.RowIndex][e.ColumnIndex].Value.ToString();

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Data.cells[e.RowIndex][e.ColumnIndex].Expression;
        }

        private void Applybutton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                var selectedCell = dataGridView1.SelectedCells[0];
                if (textBox1.Text == String.Empty)
                {
                    Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Expression = null;
                    Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Value = 0;
                    dataGridView1.Rows[selectedCell.RowIndex].Cells[selectedCell.ColumnIndex].Value = "";
                }
                else
                {
                    data.ChangeData(textBox1.Text, selectedCell.RowIndex, selectedCell.ColumnIndex);
                    if (!String.IsNullOrEmpty(Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Error))
                        dataGridView1.Rows[selectedCell.RowIndex].Cells[selectedCell.ColumnIndex].Value = Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Error;
                    else
                        dataGridView1.Rows[selectedCell.RowIndex].Cells[selectedCell.ColumnIndex].Value = Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Value.ToString();
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;

            tb.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = ((TextBox)sender).Text;
            OldTextBoxExpression = textBox1.Text;
        }

        private void Clearbutton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = OldTextBoxExpression;
        }

        private void AddRowbutton3_Click(object sender, EventArgs e)
        {
            data.AddRow();
        }

        private void AddColumnbutton4_Click(object sender, EventArgs e)
        {
            data.AddColumn();
        }


        private void DeleteRowbutton5_Click(object sender, EventArgs e)
        {
            data.RemoveRow();
        }


        private void DeleteColumnbutton6_Click(object sender, EventArgs e)
        {
            data.RemoveColumn();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                data.SaveToFile(saveFileDialog1.FileName);
                currentFileName = saveFileDialog1.FileName;
                this.Text = currentFileName + "- MyExcel";
            }
        }

        private void opentoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                data = new Data(dataGridView1);
                data.OpenFile(openFileDialog1.FileName);
                data.FillData(Mode.Value);
                currentFileName = openFileDialog1.FileName;
                this.Text = currentFileName + "- MyExcel";

            }
        }

        private void exittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            data.FillData(Mode.Value);
        }
    }
}
