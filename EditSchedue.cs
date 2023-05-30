using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace ScheduleCreator
{
	public partial class EditScheduleForm : Form
	{
		public EditScheduleForm()
		{
			SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
			InitializeComponent();
		}

		/* Закрити вікно */
		private void closeapp_button_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.Close();
		}
		private void closeapp_button_MouseEnter(object sender, EventArgs e)
		{
			closeapp_button.ForeColor = Color.Red;
		}
		private void closeapp_button_MouseLeave(object sender, EventArgs e)
		{
			closeapp_button.ForeColor = Color.Black;
		}

		/* Перетягування вікна */
		Point lastpoint;
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left){
				this.Left += e.X - lastpoint.X;
				this.Top += e.Y - lastpoint.Y;
			}
		}
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			lastpoint = new Point(e.X, e.Y);
		}



		private void EditScheduleForm_Load(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog();
			openFileDialog.Filter =
				"XLS files (*.xls, *.xlt)|*.xls;*.xlt|" +
				"XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|" +
				"ODS files (*.ods, *.ots)|*.ods;*.ots|" +
				"CSV files (*.csv, *.tsv)|*.csv;*.tsv|" +
				"HTML files (*.html, *.htm)|*.html;*.htm";

			openFileDialog.FilterIndex = 2;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var workbook = ExcelFile.Load(openFileDialog.FileName);
				var worksheet = workbook.Worksheets.ActiveWorksheet;
				
				// From ExcelFile to DataGridView.
				DataGridViewConverter.ExportToDataGridView(
					worksheet,
					this.dataGridView1,
					new ExportToDataGridViewOptions() { ColumnHeaders = true });
			}

		}

		private void txtFileName_Click(object sender, EventArgs e)
		{

		}
	}
}
