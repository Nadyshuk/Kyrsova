namespace ScheduleCreator
{
	public partial class Form1 : Form
	{
		public Form1(){
			InitializeComponent();
		}

		/* ������� ������� ���� */
		private void closeapp_button_Click(object sender, EventArgs e){
			Form.ActiveForm.Close();
		}
		// ���� ������ ���������� �� ������, ���� ��������� ��������
		private void closeapp_button_MouseEnter(object sender, EventArgs e){
			closeapp_button.ForeColor = Color.Red;
		}
		// ���� ������ �������� � ������ ������, ���� ������� ��� ����������� ����
		private void closeapp_button_MouseLeave(object sender, EventArgs e){
			closeapp_button.ForeColor = Color.Black;
		}

		/* ������� ���� �� ��������� ������� */
		Point lastpoint;
		private void Form1_MouseMove(object sender, MouseEventArgs e){
			if(e.Button== MouseButtons.Left){
				this.Left += e.X - lastpoint.X;
				this.Top += e.Y - lastpoint.Y;
			}
		}
		private void Form1_MouseDown(object sender, MouseEventArgs e){
			lastpoint = new Point(e.X, e.Y);
		}

		/* ��������� � ���� ��������� */
		private void create_schedule_button_Click(object sender, EventArgs e)
		{
			Form CreateScheduleForm = new CreateScheduleForm();
			CreateScheduleForm.Show();
		}
		/*������� � ���� �����������*/
		private void edit_schedule_button_Click(object sender, EventArgs e)
		{
			Form EditSchedule = new EditScheduleForm();
			EditSchedule.Show();
		}
	}
}