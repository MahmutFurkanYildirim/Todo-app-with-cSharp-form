namespace Todos
{
	partial class UpdateTodoForm
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
			this.due_label_update = new System.Windows.Forms.Label();
			this.due_date_update = new System.Windows.Forms.DateTimePicker();
			this.priority_cmbx_update = new System.Windows.Forms.ComboBox();
			this.category_cmbx_update = new System.Windows.Forms.ComboBox();
			this.save_button_update = new System.Windows.Forms.Button();
			this.enter_text_update = new System.Windows.Forms.TextBox();
			this.priority_label_update = new System.Windows.Forms.Label();
			this.category_label_update = new System.Windows.Forms.Label();
			this.enter_label_update = new System.Windows.Forms.Label();
			this.Create_Label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// due_label_update
			// 
			this.due_label_update.AutoSize = true;
			this.due_label_update.Location = new System.Drawing.Point(56, 147);
			this.due_label_update.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.due_label_update.Name = "due_label_update";
			this.due_label_update.Size = new System.Drawing.Size(70, 15);
			this.due_label_update.TabIndex = 20;
			this.due_label_update.Text = "Due Date:";
			// 
			// due_date_update
			// 
			this.due_date_update.CustomFormat = "dd/MM/yyyy HH:mm";
			this.due_date_update.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.due_date_update.Location = new System.Drawing.Point(242, 140);
			this.due_date_update.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.due_date_update.Name = "due_date_update";
			this.due_date_update.Size = new System.Drawing.Size(279, 23);
			this.due_date_update.TabIndex = 19;
			// 
			// priority_cmbx_update
			// 
			this.priority_cmbx_update.FormattingEnabled = true;
			this.priority_cmbx_update.Location = new System.Drawing.Point(242, 106);
			this.priority_cmbx_update.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.priority_cmbx_update.Name = "priority_cmbx_update";
			this.priority_cmbx_update.Size = new System.Drawing.Size(279, 23);
			this.priority_cmbx_update.TabIndex = 18;
			// 
			// category_cmbx_update
			// 
			this.category_cmbx_update.FormattingEnabled = true;
			this.category_cmbx_update.Location = new System.Drawing.Point(242, 65);
			this.category_cmbx_update.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.category_cmbx_update.Name = "category_cmbx_update";
			this.category_cmbx_update.Size = new System.Drawing.Size(279, 23);
			this.category_cmbx_update.TabIndex = 17;
			// 
			// save_button_update
			// 
			this.save_button_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.save_button_update.BackColor = System.Drawing.Color.Lavender;
			this.save_button_update.Cursor = System.Windows.Forms.Cursors.Default;
			this.save_button_update.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.save_button_update.Location = new System.Drawing.Point(314, 204);
			this.save_button_update.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.save_button_update.Name = "save_button_update";
			this.save_button_update.Size = new System.Drawing.Size(127, 41);
			this.save_button_update.TabIndex = 16;
			this.save_button_update.Text = "Save";
			this.save_button_update.UseVisualStyleBackColor = true;
			// 
			// enter_text_update
			// 
			this.enter_text_update.Location = new System.Drawing.Point(242, 28);
			this.enter_text_update.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.enter_text_update.Name = "enter_text_update";
			this.enter_text_update.Size = new System.Drawing.Size(279, 23);
			this.enter_text_update.TabIndex = 15;
			// 
			// priority_label_update
			// 
			this.priority_label_update.AutoSize = true;
			this.priority_label_update.Location = new System.Drawing.Point(56, 106);
			this.priority_label_update.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.priority_label_update.Name = "priority_label_update";
			this.priority_label_update.Size = new System.Drawing.Size(54, 15);
			this.priority_label_update.TabIndex = 14;
			this.priority_label_update.Text = "Priority:";
			// 
			// category_label_update
			// 
			this.category_label_update.AutoSize = true;
			this.category_label_update.Location = new System.Drawing.Point(56, 65);
			this.category_label_update.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.category_label_update.Name = "category_label_update";
			this.category_label_update.Size = new System.Drawing.Size(68, 15);
			this.category_label_update.TabIndex = 13;
			this.category_label_update.Text = "Category:";
			// 
			// enter_label_update
			// 
			this.enter_label_update.AutoSize = true;
			this.enter_label_update.Location = new System.Drawing.Point(56, 28);
			this.enter_label_update.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.enter_label_update.Name = "enter_label_update";
			this.enter_label_update.Size = new System.Drawing.Size(120, 15);
			this.enter_label_update.TabIndex = 12;
			this.enter_label_update.Text = "Enter Description:";
			// 
			// Create_Label
			// 
			this.Create_Label.AutoSize = true;
			this.Create_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Create_Label.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Create_Label.Location = new System.Drawing.Point(375, -79);
			this.Create_Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.Create_Label.Name = "Create_Label";
			this.Create_Label.Size = new System.Drawing.Size(223, 34);
			this.Create_Label.TabIndex = 11;
			this.Create_Label.Text = "CREATE TO DO";
			// 
			// UpdateTodoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(582, 270);
			this.Controls.Add(this.due_label_update);
			this.Controls.Add(this.due_date_update);
			this.Controls.Add(this.priority_cmbx_update);
			this.Controls.Add(this.category_cmbx_update);
			this.Controls.Add(this.save_button_update);
			this.Controls.Add(this.enter_text_update);
			this.Controls.Add(this.priority_label_update);
			this.Controls.Add(this.category_label_update);
			this.Controls.Add(this.enter_label_update);
			this.Controls.Add(this.Create_Label);
			this.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.MaximizeBox = false;
			this.Name = "UpdateTodoForm";
			this.Text = "UpdateTodoForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label due_label_update;
		private System.Windows.Forms.DateTimePicker due_date_update;
		private System.Windows.Forms.ComboBox priority_cmbx_update;
		private System.Windows.Forms.ComboBox category_cmbx_update;
		private System.Windows.Forms.Button save_button_update;
		private System.Windows.Forms.TextBox enter_text_update;
		private System.Windows.Forms.Label priority_label_update;
		private System.Windows.Forms.Label category_label_update;
		private System.Windows.Forms.Label enter_label_update;
		private System.Windows.Forms.Label Create_Label;
	}
}