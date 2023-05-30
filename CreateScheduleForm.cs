using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleCreator
{
	public partial class CreateScheduleForm : Form
	{
		// Змінна для часу
		string day, time, lesson_name;

		public CreateScheduleForm(){
			InitializeComponent();
		}

		/* Перетягування вікна */
		Point lastpoint;
		private void CreateScheduleForm_MouseMove(object sender, MouseEventArgs e){
			if (e.Button == MouseButtons.Left){
				this.Left += e.X - lastpoint.X;
				this.Top += e.Y - lastpoint.Y;
			}
		}
		private void CreateScheduleForm_MouseDown(object sender, MouseEventArgs e){
			lastpoint = new Point(e.X, e.Y);
		}

		/* Створюємо стандартні часи*/
		private void CreateScheduleForm_Load(object sender, EventArgs e){
			/* Додаємо час */
			schedulegrid.Rows.Add("8:30 - 9:50");
			schedulegrid.Rows.Add("10:00 - 11:20");
			schedulegrid.Rows.Add("11:30 - 12:50");
			schedulegrid.Rows.Add("13:10 - 14:30");
			schedulegrid.Rows.Add("14:40 - 16:00");
			
		}
		/* Закрити вікно */
		private void closeapp_button_Click(object sender, EventArgs e){
			Form.ActiveForm.Close();
		}
		// Якщо курсор знаходиться на вікні, вона підсвічується червоним
		private void closeapp_button_MouseEnter(object sender, EventArgs e){
			closeapp_button.ForeColor = Color.Red;
		}

		/* Експорт розкладу в .xls*/
		private void button1_Click(object sender, EventArgs e){
			// Створюємо Excel программу
			Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
			// Створюємо новий файл Excel
			Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
			// Створюємо новий лист Excel
			Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
			// Створюємо запуск програми
			app.Visible = true;
			worksheet = workbook.Sheets["Лист1"];
			worksheet = workbook.ActiveSheet;
			// Змінюємо ім'я активного листа
			worksheet.Name = "Лист1";
			// Рахуємо кількість комірок розкладу
			for (int i = 1; i < schedulegrid.Columns.Count + 1; i++){
				worksheet.Cells[1, i] = schedulegrid.Columns[i - 1].HeaderText;
			}
			// Експортуємо його в Excel
			for (int i = 0; i < schedulegrid.Rows.Count; i++){
				for (int j = 0; j < schedulegrid.Columns.Count; j++){
					if (schedulegrid.Rows[i].Cells[j].Value != null){
						worksheet.Cells[i + 2, j + 1] = schedulegrid.Rows[i].Cells[j].Value.ToString();
					}
				}
			}
			// Зберігаємо на робочій стіл
			workbook.SaveAs($"C:\\Users\\{Environment.UserName}\\Desktop\\YourFile", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			// Виходим с вікна експортування 
			MessageBox.Show("Розклад успішно експортировано!");
			app.Quit();
		}

		// Кнопка на зачистку комірки від предмета
		private void clear_button_Click(object sender, EventArgs e){
			for(int i = 1; i <= 5; i++){
				for(int j = 0; j <= 4; j++){
					schedulegrid[i, j].Value = "";
				}
			}
		}

		
		private void delete_lesson_button_Click(object sender, EventArgs e)
		{
			int cell_x = 0, cell_y = 1;
			// Коректировка по дню (x)
			try
			{
				switch (DayChoice_selector.Text){
					case "Понеділок": cell_x = 1; break;
					case "Вівторок": cell_x = 2; break;
					case "Середа": cell_x = 3; break;
					case "Четверг": cell_x = 4; break;
					case "П'ятниця": cell_x = 5; break;
				}
			}
			catch (Exception){
				MessageBox.Show("Не вибрано день!"); throw;
			}
			// Коректировка по часу (y)
			try{
				switch (TimeChoice_selector.Text){
					case "8:30 - 9:50": cell_y = 0; break;
					case "10:00 - 11:20": cell_y = 1; break;
					case "11:30 - 12:50": cell_y = 2; break;
					case "13:10 - 14:30": cell_y = 3; break;
					case "14:40 - 16:00": cell_y = 4; break;
				}
			}
			catch (Exception){
				MessageBox.Show("Не вибран час!"); throw;
			}
			try{
				schedulegrid[cell_x, cell_y].Value = "";
			}
			catch (Exception){
				MessageBox.Show("Не вибран предмет!"); throw;
				throw;
			}
		}

		private void schedulegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		// Якщо курсор виходить с зони кнопки, то вона повертає свій кольор
		private void closeapp_button_MouseLeave(object sender, EventArgs e){
			closeapp_button.ForeColor = Color.Black;
		}

		/* Додавання предмета в комірку */
		private void add_lesson_button_Click(object sender, EventArgs e){
			int cell_x = 0, cell_y = 1;
			// Коректировка по дню (x)
			try{
				switch (DayChoice_selector.Text)
				{
					case "Понеділок": cell_x = 1; break;
					case "Вівторок": cell_x = 2; break;
					case "Середа": cell_x = 3; break;
					case "Четверг": cell_x = 4; break;
					case "П'ятниця": cell_x = 5; break;
				}
			}
			catch (Exception){
				MessageBox.Show("Не выбрано день!"); throw;
			}
			// Коректировка по часу (y)
			try{
				switch (TimeChoice_selector.Text){
					case "8:30 - 9:50": cell_y = 0; break;
					case "10:00 - 11:20": cell_y = 1; break;
					case "11:30 - 12:50": cell_y = 2; break;
					case "13:10 - 14:30": cell_y = 3; break;
					case "14:40 - 16:00": cell_y = 4; break;
				}
			}
			catch (Exception){
				MessageBox.Show("Не вибран час!"); throw;
			}
			try{
				// Установка предмета
				schedulegrid[cell_x, cell_y].Value = LessonBox.Text;
			}
			catch (Exception){
				MessageBox.Show("Не вибран предмет!"); throw;
				throw;
			}
			// P.S: TryCatch() для відстежування помилок користувача
		}
	}
}
