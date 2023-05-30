namespace ScheduleCreator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.closeapp_button = new System.Windows.Forms.Button();
			this.main_panel = new System.Windows.Forms.Panel();
			this.edit_schedule_button = new System.Windows.Forms.Button();
			this.create_schedule_button = new System.Windows.Forms.Button();
			this.programm_icon = new System.Windows.Forms.Panel();
			this.programName_label2 = new System.Windows.Forms.Label();
			this.programName_label1 = new System.Windows.Forms.Label();
			this.main_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// closeapp_button
			// 
			this.closeapp_button.BackColor = System.Drawing.Color.Transparent;
			this.closeapp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.closeapp_button.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.closeapp_button.ForeColor = System.Drawing.Color.Black;
			this.closeapp_button.Location = new System.Drawing.Point(755, 12);
			this.closeapp_button.Name = "closeapp_button";
			this.closeapp_button.Size = new System.Drawing.Size(33, 28);
			this.closeapp_button.TabIndex = 0;
			this.closeapp_button.Text = "X";
			this.closeapp_button.UseVisualStyleBackColor = false;
			this.closeapp_button.Click += new System.EventHandler(this.closeapp_button_Click);
			this.closeapp_button.MouseEnter += new System.EventHandler(this.closeapp_button_MouseEnter);
			this.closeapp_button.MouseLeave += new System.EventHandler(this.closeapp_button_MouseLeave);
			// 
			// main_panel
			// 
			this.main_panel.BackColor = System.Drawing.SystemColors.Window;
			this.main_panel.Controls.Add(this.edit_schedule_button);
			this.main_panel.Controls.Add(this.create_schedule_button);
			this.main_panel.Controls.Add(this.programm_icon);
			this.main_panel.Controls.Add(this.programName_label2);
			this.main_panel.Controls.Add(this.programName_label1);
			this.main_panel.Location = new System.Drawing.Point(-3, -1);
			this.main_panel.Name = "main_panel";
			this.main_panel.Size = new System.Drawing.Size(169, 434);
			this.main_panel.TabIndex = 1;
			// 
			// edit_schedule_button
			// 
			this.edit_schedule_button.BackColor = System.Drawing.Color.SlateBlue;
			this.edit_schedule_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.edit_schedule_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.edit_schedule_button.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.edit_schedule_button.Location = new System.Drawing.Point(15, 151);
			this.edit_schedule_button.Name = "edit_schedule_button";
			this.edit_schedule_button.Size = new System.Drawing.Size(144, 45);
			this.edit_schedule_button.TabIndex = 4;
			this.edit_schedule_button.Text = "Редагувати";
			this.edit_schedule_button.UseVisualStyleBackColor = false;
			this.edit_schedule_button.Click += new System.EventHandler(this.edit_schedule_button_Click);
			// 
			// create_schedule_button
			// 
			this.create_schedule_button.BackColor = System.Drawing.Color.SlateBlue;
			this.create_schedule_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.create_schedule_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.create_schedule_button.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.create_schedule_button.Location = new System.Drawing.Point(15, 100);
			this.create_schedule_button.Name = "create_schedule_button";
			this.create_schedule_button.Size = new System.Drawing.Size(144, 45);
			this.create_schedule_button.TabIndex = 3;
			this.create_schedule_button.Text = "Створити";
			this.create_schedule_button.UseVisualStyleBackColor = false;
			this.create_schedule_button.Click += new System.EventHandler(this.create_schedule_button_Click);
			// 
			// programm_icon
			// 
			this.programm_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("programm_icon.BackgroundImage")));
			this.programm_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.programm_icon.Location = new System.Drawing.Point(25, 36);
			this.programm_icon.Name = "programm_icon";
			this.programm_icon.Size = new System.Drawing.Size(37, 38);
			this.programm_icon.TabIndex = 2;
			// 
			// programName_label2
			// 
			this.programName_label2.AutoSize = true;
			this.programName_label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.programName_label2.ForeColor = System.Drawing.Color.Black;
			this.programName_label2.Location = new System.Drawing.Point(58, 44);
			this.programName_label2.Name = "programName_label2";
			this.programName_label2.Size = new System.Drawing.Size(98, 30);
			this.programName_label2.TabIndex = 1;
			this.programName_label2.Text = "Creator";
			// 
			// programName_label1
			// 
			this.programName_label1.AutoSize = true;
			this.programName_label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.programName_label1.ForeColor = System.Drawing.Color.Black;
			this.programName_label1.Location = new System.Drawing.Point(15, 13);
			this.programName_label1.Name = "programName_label1";
			this.programName_label1.Size = new System.Drawing.Size(120, 30);
			this.programName_label1.TabIndex = 0;
			this.programName_label1.Text = "Schedule";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 409);
			this.Controls.Add(this.main_panel);
			this.Controls.Add(this.closeapp_button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "ScheduleCreator";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.main_panel.ResumeLayout(false);
			this.main_panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Button closeapp_button;
		private Panel main_panel;
		private Button edit_schedule_button;
		private Button create_schedule_button;
		private Panel programm_icon;
		private Label programName_label2;
		private Label programName_label1;
	}
}