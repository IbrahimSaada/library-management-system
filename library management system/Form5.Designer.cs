using System;

namespace library_management_system
{
    partial class Form5
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_manage = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_updatename = new System.Windows.Forms.TextBox();
            this.txt_updateauthor = new System.Windows.Forms.TextBox();
            this.txt_updateQTY = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_filtername = new System.Windows.Forms.TextBox();
            this.datagrid_books = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_bookauthor = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_decline = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_Issue = new System.Windows.Forms.DataGridView();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_books)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Issue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView_manage);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btn_delete);
            this.tabPage3.Controls.Add(this.btn_update);
            this.tabPage3.Controls.Add(this.txt_updatename);
            this.tabPage3.Controls.Add(this.txt_updateauthor);
            this.tabPage3.Controls.Add(this.txt_updateQTY);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(618, 368);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Books";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridView_manage
            // 
            this.dataGridView_manage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_manage.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_manage.Name = "dataGridView_manage";
            this.dataGridView_manage.Size = new System.Drawing.Size(485, 184);
            this.dataGridView_manage.TabIndex = 9;
            this.dataGridView_manage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_manage_CellContentClick);
            this.dataGridView_manage.SelectionChanged += new System.EventHandler(this.dataGridView_manage_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "BookAuthor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "BookName";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(228, 324);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(103, 324);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(119, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_updatename
            // 
            this.txt_updatename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_updatename.Location = new System.Drawing.Point(154, 193);
            this.txt_updatename.Name = "txt_updatename";
            this.txt_updatename.Size = new System.Drawing.Size(166, 20);
            this.txt_updatename.TabIndex = 3;
            this.txt_updatename.TextChanged += new System.EventHandler(this.txt_updatename_TextChanged);
            // 
            // txt_updateauthor
            // 
            this.txt_updateauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_updateauthor.Location = new System.Drawing.Point(154, 235);
            this.txt_updateauthor.Name = "txt_updateauthor";
            this.txt_updateauthor.Size = new System.Drawing.Size(166, 20);
            this.txt_updateauthor.TabIndex = 2;
            // 
            // txt_updateQTY
            // 
            this.txt_updateQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_updateQTY.Location = new System.Drawing.Point(154, 277);
            this.txt_updateQTY.Name = "txt_updateQTY";
            this.txt_updateQTY.Size = new System.Drawing.Size(166, 20);
            this.txt_updateQTY.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_refresh);
            this.tabPage2.Controls.Add(this.txt_filtername);
            this.tabPage2.Controls.Add(this.datagrid_books);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Books";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(236, 22);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 23);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_filtername
            // 
            this.txt_filtername.Location = new System.Drawing.Point(18, 22);
            this.txt_filtername.Name = "txt_filtername";
            this.txt_filtername.Size = new System.Drawing.Size(193, 20);
            this.txt_filtername.TabIndex = 2;
            this.txt_filtername.TextChanged += new System.EventHandler(this.txt_filtername_TextChanged);
            // 
            // datagrid_books
            // 
            this.datagrid_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_books.Location = new System.Drawing.Point(0, 49);
            this.datagrid_books.Name = "datagrid_books";
            this.datagrid_books.Size = new System.Drawing.Size(433, 323);
            this.datagrid_books.TabIndex = 0;
            this.datagrid_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_books_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txt_bookauthor);
            this.tabPage1.Controls.Add(this.txt_quantity);
            this.tabPage1.Controls.Add(this.txt_bookname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_bookauthor
            // 
            this.txt_bookauthor.Location = new System.Drawing.Point(120, 95);
            this.txt_bookauthor.Name = "txt_bookauthor";
            this.txt_bookauthor.Size = new System.Drawing.Size(153, 20);
            this.txt_bookauthor.TabIndex = 5;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(120, 144);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(153, 20);
            this.txt_quantity.TabIndex = 4;
            // 
            // txt_bookname
            // 
            this.txt_bookname.Location = new System.Drawing.Point(120, 45);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(153, 20);
            this.txt_bookname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_accept);
            this.tabPage4.Controls.Add(this.btn_decline);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.dataGridView_Issue);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(618, 368);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Issued Books Request";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(135, 262);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(117, 23);
            this.btn_accept.TabIndex = 7;
            this.btn_accept.Text = "Approve";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_decline
            // 
            this.btn_decline.Location = new System.Drawing.Point(324, 262);
            this.btn_decline.Name = "btn_decline";
            this.btn_decline.Size = new System.Drawing.Size(117, 23);
            this.btn_decline.TabIndex = 6;
            this.btn_decline.Text = "Decline";
            this.btn_decline.UseVisualStyleBackColor = true;
            this.btn_decline.Click += new System.EventHandler(this.btn_decline_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Allow User To Borrow Book";
            // 
            // dataGridView_Issue
            // 
            this.dataGridView_Issue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Issue.Location = new System.Drawing.Point(0, 3);
            this.dataGridView_Issue.Name = "dataGridView_Issue";
            this.dataGridView_Issue.Size = new System.Drawing.Size(618, 183);
            this.dataGridView_Issue.TabIndex = 0;
            this.dataGridView_Issue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Issue_CellContentClick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 396);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_books)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Issue)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_filtername;
        private System.Windows.Forms.DataGridView datagrid_books;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_bookauthor;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_updatename;
        private System.Windows.Forms.TextBox txt_updateauthor;
        private System.Windows.Forms.TextBox txt_updateQTY;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView_Issue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_decline;
        private System.Windows.Forms.DataGridView dataGridView_manage;
        private System.Windows.Forms.Button btn_refresh;
    }
}