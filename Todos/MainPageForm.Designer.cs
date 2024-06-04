namespace Todos
{
	partial class MainPageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
			this.Create_Label = new System.Windows.Forms.Label();
			this.enter_label = new System.Windows.Forms.Label();
			this.Kategori_label = new System.Windows.Forms.Label();
			this.priority_label = new System.Windows.Forms.Label();
			this.enter_text = new System.Windows.Forms.TextBox();
			this.Save_button = new System.Windows.Forms.Button();
			this.category_cmbx = new System.Windows.Forms.ComboBox();
			this.priority_cmbx = new System.Windows.Forms.ComboBox();
			this.due_date = new System.Windows.Forms.DateTimePicker();
			this.due_label = new System.Windows.Forms.Label();
			this.todo_grpbx = new System.Windows.Forms.GroupBox();
			this.todo_datagrd = new System.Windows.Forms.DataGridView();
			this.todo_grpbx.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.todo_datagrd)).BeginInit();
			this.SuspendLayout();
			// 
			// Create_Label
			// 
			this.Create_Label.AutoSize = true;
			this.Create_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Create_Label.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Create_Label.Location = new System.Drawing.Point(352, 23);
			this.Create_Label.Name = "Create_Label";
			this.Create_Label.Size = new System.Drawing.Size(223, 34);
			this.Create_Label.TabIndex = 0;
			this.Create_Label.Text = "CREATE TO DO";
			// 
			// enter_label
			// 
			this.enter_label.AutoSize = true;
			this.enter_label.Location = new System.Drawing.Point(45, 100);
			this.enter_label.Name = "enter_label";
			this.enter_label.Size = new System.Drawing.Size(125, 16);
			this.enter_label.TabIndex = 1;
			this.enter_label.Text = "Enter Description:";
			// 
			// Kategori_label
			// 
			this.Kategori_label.AutoSize = true;
			this.Kategori_label.Location = new System.Drawing.Point(45, 133);
			this.Kategori_label.Name = "Kategori_label";
			this.Kategori_label.Size = new System.Drawing.Size(69, 16);
			this.Kategori_label.TabIndex = 2;
			this.Kategori_label.Text = "Category:";
			// 
			// priority_label
			// 
			this.priority_label.AutoSize = true;
			this.priority_label.Location = new System.Drawing.Point(485, 100);
			this.priority_label.Name = "priority_label";
			this.priority_label.Size = new System.Drawing.Size(60, 16);
			this.priority_label.TabIndex = 3;
			this.priority_label.Text = "Priority:";
			// 
			// enter_text
			// 
			this.enter_text.Location = new System.Drawing.Point(233, 100);
			this.enter_text.Name = "enter_text";
			this.enter_text.Size = new System.Drawing.Size(211, 23);
			this.enter_text.TabIndex = 4;
			// 
			// Save_button
			// 
			this.Save_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Save_button.BackColor = System.Drawing.Color.Lavender;
			this.Save_button.Cursor = System.Windows.Forms.Cursors.Default;
			this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Save_button.Location = new System.Drawing.Point(404, 208);
			this.Save_button.Name = "Save_button";
			this.Save_button.Size = new System.Drawing.Size(95, 35);
			this.Save_button.TabIndex = 5;
			this.Save_button.Text = "Save";
			this.Save_button.UseVisualStyleBackColor = true;
			this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
			// 
			// category_cmbx
			// 
			this.category_cmbx.FormattingEnabled = true;
			this.category_cmbx.Location = new System.Drawing.Point(233, 133);
			this.category_cmbx.Name = "category_cmbx";
			this.category_cmbx.Size = new System.Drawing.Size(211, 24);
			this.category_cmbx.TabIndex = 6;
			// 
			// priority_cmbx
			// 
			this.priority_cmbx.FormattingEnabled = true;
			this.priority_cmbx.Location = new System.Drawing.Point(673, 99);
			this.priority_cmbx.Name = "priority_cmbx";
			this.priority_cmbx.Size = new System.Drawing.Size(211, 24);
			this.priority_cmbx.TabIndex = 7;
			// 
			// due_date
			// 
			this.due_date.CustomFormat = "dd/MM/yyyy HH:mm";
			this.due_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.due_date.Location = new System.Drawing.Point(673, 136);
			this.due_date.Name = "due_date";
			this.due_date.Size = new System.Drawing.Size(211, 23);
			this.due_date.TabIndex = 8;
			// 
			// due_label
			// 
			this.due_label.AutoSize = true;
			this.due_label.Location = new System.Drawing.Point(485, 141);
			this.due_label.Name = "due_label";
			this.due_label.Size = new System.Drawing.Size(70, 16);
			this.due_label.TabIndex = 9;
			this.due_label.Text = "Due Date:";
			// 
			// todo_grpbx
			// 
			this.todo_grpbx.Controls.Add(this.todo_datagrd);
			this.todo_grpbx.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.todo_grpbx.Location = new System.Drawing.Point(30, 261);
			this.todo_grpbx.Name = "todo_grpbx";
			this.todo_grpbx.Size = new System.Drawing.Size(902, 347);
			this.todo_grpbx.TabIndex = 10;
			this.todo_grpbx.TabStop = false;
			this.todo_grpbx.Text = "To-do";
			// 
			// todo_datagrd
			// 
			this.todo_datagrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.todo_datagrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.todo_datagrd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.todo_datagrd.Location = new System.Drawing.Point(3, 16);
			this.todo_datagrd.Name = "todo_datagrd";
			this.todo_datagrd.Size = new System.Drawing.Size(896, 328);
			this.todo_datagrd.TabIndex = 0;
			// 
			// MainPageForm
			// 
			this.AcceptButton = this.Save_button;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(957, 620);
			this.Controls.Add(this.todo_grpbx);
			this.Controls.Add(this.due_label);
			this.Controls.Add(this.due_date);
			this.Controls.Add(this.priority_cmbx);
			this.Controls.Add(this.category_cmbx);
			this.Controls.Add(this.Save_button);
			this.Controls.Add(this.enter_text);
			this.Controls.Add(this.priority_label);
			this.Controls.Add(this.Kategori_label);
			this.Controls.Add(this.enter_label);
			this.Controls.Add(this.Create_Label);
			this.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainPageForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create To-do";
			this.Load += new System.EventHandler(this.MainPage_Load);
			this.todo_grpbx.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.todo_datagrd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Create_Label;
		private System.Windows.Forms.Label enter_label;
		private System.Windows.Forms.Label Kategori_label;
		private System.Windows.Forms.Label priority_label;
		private System.Windows.Forms.TextBox enter_text;
		private System.Windows.Forms.Button Save_button;
		private System.Windows.Forms.ComboBox category_cmbx;
		private System.Windows.Forms.ComboBox priority_cmbx;
		private System.Windows.Forms.DateTimePicker due_date;
		private System.Windows.Forms.Label due_label;
		private System.Windows.Forms.GroupBox todo_grpbx;
		private System.Windows.Forms.DataGridView todo_datagrd;
	}
}

