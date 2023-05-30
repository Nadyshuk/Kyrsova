namespace ScheduleCreator
{
	partial class EditScheduleForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditScheduleForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtFileName = new System.Windows.Forms.Label();
			this.closeapp_button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(239, 102);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(586, 288);
			this.dataGridView1.TabIndex = 0;
			// 
			// txtFileName
			// 
			this.txtFileName.AutoSize = true;
			this.txtFileName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.txtFileName.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txtFileName.Location = new System.Drawing.Point(267, 73);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(120, 26);
			this.txtFileName.TabIndex = 9;
			this.txtFileName.Text = "Ваш файл";
			// 
			// closeapp_button
			// 
			this.closeapp_button.BackColor = System.Drawing.Color.Transparent;
			this.closeapp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.closeapp_button.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.closeapp_button.ForeColor = System.Drawing.Color.Black;
			this.closeapp_button.Location = new System.Drawing.Point(792, 12);
			this.closeapp_button.Name = "closeapp_button";
			this.closeapp_button.Size = new System.Drawing.Size(33, 28);
			this.closeapp_button.TabIndex = 10;
			this.closeapp_button.Text = "X";
			this.closeapp_button.UseVisualStyleBackColor = false;
			this.closeapp_button.Click += new System.EventHandler(this.closeapp_button_Click);
			this.closeapp_button.MouseEnter += new System.EventHandler(this.closeapp_button_MouseEnter);
			this.closeapp_button.MouseLeave += new System.EventHandler(this.closeapp_button_MouseLeave);
			// 
			// EditScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(837, 465);
			this.Controls.Add(this.closeapp_button);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.dataGridView1);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EditScheduleForm";
			this.Text = "EditSchedule";
			this.Load += new System.EventHandler(this.EditScheduleForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dataGridView1;
		private Button clear_button;
		private Label txtFileName;
		private Button closeapp_button;
	}
}