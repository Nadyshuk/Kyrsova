namespace ScheduleCreator
{
	partial class CreateScheduleForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateScheduleForm));
			this.schedulegrid = new System.Windows.Forms.DataGridView();
			this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.closeapp_button = new System.Windows.Forms.Button();
			this.add_lesson_button = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.delete_lesson_button = new System.Windows.Forms.Button();
			this.clear_button = new System.Windows.Forms.Button();
			this.programName_label1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.DayChoice_selector = new System.Windows.Forms.ComboBox();
			this.TimeChoice_selector = new System.Windows.Forms.ComboBox();
			this.LessonBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.schedulegrid)).BeginInit();
			this.SuspendLayout();
			// 
			// schedulegrid
			// 
			this.schedulegrid.AllowUserToAddRows = false;
			this.schedulegrid.AllowUserToDeleteRows = false;
			this.schedulegrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
			this.schedulegrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.schedulegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.schedulegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday});
			this.schedulegrid.GridColor = System.Drawing.Color.Black;
			this.schedulegrid.Location = new System.Drawing.Point(292, 71);
			this.schedulegrid.Name = "schedulegrid";
			this.schedulegrid.RowTemplate.Height = 25;
			this.schedulegrid.Size = new System.Drawing.Size(643, 293);
			this.schedulegrid.TabIndex = 0;
			this.schedulegrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedulegrid_CellContentClick);
			// 
			// Time
			// 
			this.Time.HeaderText = "Час";
			this.Time.Name = "Time";
			this.Time.ReadOnly = true;
			this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// monday
			// 
			this.monday.HeaderText = "Пн";
			this.monday.Name = "monday";
			this.monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Tuesday
			// 
			this.Tuesday.HeaderText = "Вт";
			this.Tuesday.Name = "Tuesday";
			this.Tuesday.ReadOnly = true;
			this.Tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Wednesday
			// 
			this.Wednesday.HeaderText = "Ср";
			this.Wednesday.Name = "Wednesday";
			this.Wednesday.ReadOnly = true;
			this.Wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Thursday
			// 
			this.Thursday.HeaderText = "Чт";
			this.Thursday.Name = "Thursday";
			this.Thursday.ReadOnly = true;
			this.Thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Friday
			// 
			this.Friday.HeaderText = "Пт";
			this.Friday.Name = "Friday";
			this.Friday.ReadOnly = true;
			this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// closeapp_button
			// 
			this.closeapp_button.BackColor = System.Drawing.Color.Transparent;
			this.closeapp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.closeapp_button.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.closeapp_button.ForeColor = System.Drawing.Color.Black;
			this.closeapp_button.Location = new System.Drawing.Point(926, 12);
			this.closeapp_button.Name = "closeapp_button";
			this.closeapp_button.Size = new System.Drawing.Size(33, 28);
			this.closeapp_button.TabIndex = 1;
			this.closeapp_button.Text = "X";
			this.closeapp_button.UseVisualStyleBackColor = false;
			this.closeapp_button.Click += new System.EventHandler(this.closeapp_button_Click);
			this.closeapp_button.MouseEnter += new System.EventHandler(this.closeapp_button_MouseEnter);
			this.closeapp_button.MouseHover += new System.EventHandler(this.closeapp_button_MouseLeave);
			// 
			// add_lesson_button
			// 
			this.add_lesson_button.BackColor = System.Drawing.Color.RebeccaPurple;
			this.add_lesson_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.add_lesson_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.add_lesson_button.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.add_lesson_button.Location = new System.Drawing.Point(589, 466);
			this.add_lesson_button.Name = "add_lesson_button";
			this.add_lesson_button.Size = new System.Drawing.Size(176, 45);
			this.add_lesson_button.TabIndex = 4;
			this.add_lesson_button.Text = "Добавити предмет";
			this.add_lesson_button.UseVisualStyleBackColor = false;
			this.add_lesson_button.Click += new System.EventHandler(this.add_lesson_button_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.button1.Location = new System.Drawing.Point(95, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 45);
			this.button1.TabIndex = 5;
			this.button1.Text = "Експортувати в .xls";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// delete_lesson_button
			// 
			this.delete_lesson_button.BackColor = System.Drawing.Color.RebeccaPurple;
			this.delete_lesson_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.delete_lesson_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.delete_lesson_button.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.delete_lesson_button.Location = new System.Drawing.Point(771, 466);
			this.delete_lesson_button.Name = "delete_lesson_button";
			this.delete_lesson_button.Size = new System.Drawing.Size(176, 45);
			this.delete_lesson_button.TabIndex = 6;
			this.delete_lesson_button.Text = "Видалити предмет";
			this.delete_lesson_button.UseVisualStyleBackColor = false;
			this.delete_lesson_button.Click += new System.EventHandler(this.delete_lesson_button_Click);
			// 
			// clear_button
			// 
			this.clear_button.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.clear_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.clear_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.clear_button.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.clear_button.Location = new System.Drawing.Point(129, 89);
			this.clear_button.Name = "clear_button";
			this.clear_button.Size = new System.Drawing.Size(142, 45);
			this.clear_button.TabIndex = 7;
			this.clear_button.Text = "Стерти";
			this.clear_button.UseVisualStyleBackColor = false;
			this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
			// 
			// programName_label1
			// 
			this.programName_label1.AutoSize = true;
			this.programName_label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.programName_label1.ForeColor = System.Drawing.Color.Black;
			this.programName_label1.Location = new System.Drawing.Point(12, 455);
			this.programName_label1.Name = "programName_label1";
			this.programName_label1.Size = new System.Drawing.Size(83, 20);
			this.programName_label1.TabIndex = 8;
			this.programName_label1.Text = "Вибір дня";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(196, 455);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Вибір часу";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(424, 455);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Предмет";
			// 
			// DayChoice_selector
			// 
			this.DayChoice_selector.FormattingEnabled = true;
			this.DayChoice_selector.Items.AddRange(new object[] {
            "Понеділок",
            "Вівторок",
            "Середа",
            "Четверг",
            "П\'ятниця"});
			this.DayChoice_selector.Location = new System.Drawing.Point(12, 478);
			this.DayChoice_selector.Name = "DayChoice_selector";
			this.DayChoice_selector.Size = new System.Drawing.Size(163, 23);
			this.DayChoice_selector.TabIndex = 11;
			// 
			// TimeChoice_selector
			// 
			this.TimeChoice_selector.FormattingEnabled = true;
			this.TimeChoice_selector.Items.AddRange(new object[] {
            "8:30 - 9:50",
            "10:00 - 11:20",
            "11:30 - 12:50",
            "13:10 - 14:30",
            "14:40 - 16:00"});
			this.TimeChoice_selector.Location = new System.Drawing.Point(196, 478);
			this.TimeChoice_selector.Name = "TimeChoice_selector";
			this.TimeChoice_selector.Size = new System.Drawing.Size(151, 23);
			this.TimeChoice_selector.TabIndex = 12;
			// 
			// LessonBox
			// 
			this.LessonBox.Location = new System.Drawing.Point(370, 478);
			this.LessonBox.Name = "LessonBox";
			this.LessonBox.Size = new System.Drawing.Size(189, 23);
			this.LessonBox.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(526, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 30);
			this.label3.TabIndex = 14;
			this.label3.Text = "Розклад";
			// 
			// CreateScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(169)))), ((int)(((byte)(203)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(959, 520);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LessonBox);
			this.Controls.Add(this.TimeChoice_selector);
			this.Controls.Add(this.DayChoice_selector);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.programName_label1);
			this.Controls.Add(this.clear_button);
			this.Controls.Add(this.delete_lesson_button);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.add_lesson_button);
			this.Controls.Add(this.closeapp_button);
			this.Controls.Add(this.schedulegrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CreateScheduleForm";
			this.Text = "CreateScheduleForm";
			this.Load += new System.EventHandler(this.CreateScheduleForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateScheduleForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateScheduleForm_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.schedulegrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView schedulegrid;
		private Button closeapp_button;
		private Button add_lesson_button;
		private Button button1;
		private Button delete_lesson_button;
		private Button clear_button;
		private Label programName_label1;
		private Label label1;
		private Label label2;
		private ComboBox DayChoice_selector;
		private ComboBox TimeChoice_selector;
		private TextBox LessonBox;
		private Label label3;
		private DataGridViewTextBoxColumn Time;
		private DataGridViewTextBoxColumn monday;
		private DataGridViewTextBoxColumn Tuesday;
		private DataGridViewTextBoxColumn Wednesday;
		private DataGridViewTextBoxColumn Thursday;
		private DataGridViewTextBoxColumn Friday;
	}
}