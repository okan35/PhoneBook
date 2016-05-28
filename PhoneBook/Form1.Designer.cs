namespace PhoneBook
{
    partial class Form1
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
            this.listviewdatabase = new System.Windows.Forms.ListView();
            this.column_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_phonenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_display = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.lbl_phonenumber = new System.Windows.Forms.Label();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listviewdatabase
            // 
            this.listviewdatabase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_id,
            this.column_name,
            this.column_surname,
            this.column_phonenumber});
            this.listviewdatabase.Location = new System.Drawing.Point(23, 284);
            this.listviewdatabase.Name = "listviewdatabase";
            this.listviewdatabase.Size = new System.Drawing.Size(431, 125);
            this.listviewdatabase.TabIndex = 0;
            this.listviewdatabase.UseCompatibleStateImageBehavior = false;
            this.listviewdatabase.View = System.Windows.Forms.View.Details;
            this.listviewdatabase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listviewdatabase_MouseClick);
            // 
            // column_id
            // 
            this.column_id.Text = "ID";
            // 
            // column_name
            // 
            this.column_name.Text = "NAME";
            this.column_name.Width = 68;
            // 
            // column_surname
            // 
            this.column_surname.Text = "SURNAME";
            this.column_surname.Width = 93;
            // 
            // column_phonenumber
            // 
            this.column_phonenumber.Text = "PHONENUMBER";
            this.column_phonenumber.Width = 114;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(29, 30);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SURNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(171, 27);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 5;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(171, 99);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 20);
            this.txt_surname.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(171, 65);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 7;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(147, 202);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_display
            // 
            this.button_display.Location = new System.Drawing.Point(32, 202);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(75, 23);
            this.button_display.TabIndex = 9;
            this.button_display.Text = "DISPLAY";
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(388, 202);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(265, 202);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // lbl_phonenumber
            // 
            this.lbl_phonenumber.AutoSize = true;
            this.lbl_phonenumber.Location = new System.Drawing.Point(29, 138);
            this.lbl_phonenumber.Name = "lbl_phonenumber";
            this.lbl_phonenumber.Size = new System.Drawing.Size(95, 13);
            this.lbl_phonenumber.TabIndex = 12;
            this.lbl_phonenumber.Text = "PHONE NUMBER";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(171, 135);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(100, 20);
            this.txt_phonenumber.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 421);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.lbl_phonenumber);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.listviewdatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewdatabase;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ColumnHeader column_id;
        private System.Windows.Forms.ColumnHeader column_name;
        private System.Windows.Forms.ColumnHeader column_surname;
        private System.Windows.Forms.ColumnHeader column_phonenumber;
        private System.Windows.Forms.Label lbl_phonenumber;
        private System.Windows.Forms.TextBox txt_phonenumber;
    }
}

