namespace TODO_app
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deltasks = new System.Windows.Forms.Button();
            this.comptasks = new System.Windows.Forms.Button();
            this.mainpage = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.createtasks = new System.Windows.Forms.Button();
            this.todoList = new System.Windows.Forms.DataGridView();
            this.label_inptxt = new System.Windows.Forms.Label();
            this.title_inp = new System.Windows.Forms.TextBox();
            this.desc_inptxt = new System.Windows.Forms.Label();
            this.desc_input = new System.Windows.Forms.RichTextBox();
            this.set_to_deleted = new System.Windows.Forms.Button();
            this.set_to_complete = new System.Windows.Forms.Button();
            this.deleted_tasks = new System.Windows.Forms.DataGridView();
            this.completed_tasks = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleted_tasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completed_tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.deltasks);
            this.panel1.Controls.Add(this.comptasks);
            this.panel1.Controls.Add(this.mainpage);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 47);
            this.panel1.TabIndex = 0;
            // 
            // deltasks
            // 
            this.deltasks.BackColor = System.Drawing.Color.Transparent;
            this.deltasks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deltasks.Location = new System.Drawing.Point(262, 3);
            this.deltasks.Name = "deltasks";
            this.deltasks.Size = new System.Drawing.Size(130, 41);
            this.deltasks.TabIndex = 2;
            this.deltasks.Text = "Deleted tasks";
            this.deltasks.UseVisualStyleBackColor = false;
            this.deltasks.Click += new System.EventHandler(this.deltasks_Click);
            // 
            // comptasks
            // 
            this.comptasks.BackColor = System.Drawing.Color.Transparent;
            this.comptasks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comptasks.Location = new System.Drawing.Point(126, 3);
            this.comptasks.Name = "comptasks";
            this.comptasks.Size = new System.Drawing.Size(130, 41);
            this.comptasks.TabIndex = 1;
            this.comptasks.Text = "Completed tasks";
            this.comptasks.UseVisualStyleBackColor = false;
            this.comptasks.Click += new System.EventHandler(this.comptasks_Click);
            // 
            // mainpage
            // 
            this.mainpage.BackColor = System.Drawing.Color.Transparent;
            this.mainpage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainpage.Location = new System.Drawing.Point(3, 3);
            this.mainpage.Name = "mainpage";
            this.mainpage.Size = new System.Drawing.Size(117, 41);
            this.mainpage.TabIndex = 0;
            this.mainpage.Text = "Mainpage";
            this.mainpage.UseVisualStyleBackColor = false;
            this.mainpage.Click += new System.EventHandler(this.mainpage_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pageLabel.Location = new System.Drawing.Point(452, 3);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(172, 42);
            this.pageLabel.TabIndex = 1;
            this.pageLabel.Text = "Main page";
            // 
            // createtasks
            // 
            this.createtasks.BackColor = System.Drawing.Color.Black;
            this.createtasks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createtasks.ForeColor = System.Drawing.Color.White;
            this.createtasks.Location = new System.Drawing.Point(831, 364);
            this.createtasks.Name = "createtasks";
            this.createtasks.Size = new System.Drawing.Size(164, 41);
            this.createtasks.TabIndex = 3;
            this.createtasks.Text = "Create new task";
            this.createtasks.UseVisualStyleBackColor = false;
            this.createtasks.Click += new System.EventHandler(this.createtasks_Click);
            // 
            // todoList
            // 
            this.todoList.AllowUserToOrderColumns = true;
            this.todoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todoList.Location = new System.Drawing.Point(13, 68);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(797, 563);
            this.todoList.TabIndex = 4;
            // 
            // label_inptxt
            // 
            this.label_inptxt.AutoSize = true;
            this.label_inptxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_inptxt.Location = new System.Drawing.Point(827, 90);
            this.label_inptxt.Name = "label_inptxt";
            this.label_inptxt.Size = new System.Drawing.Size(43, 19);
            this.label_inptxt.TabIndex = 5;
            this.label_inptxt.Text = "Label";
            // 
            // title_inp
            // 
            this.title_inp.BackColor = System.Drawing.Color.Silver;
            this.title_inp.Location = new System.Drawing.Point(831, 112);
            this.title_inp.Name = "title_inp";
            this.title_inp.Size = new System.Drawing.Size(164, 20);
            this.title_inp.TabIndex = 6;
            // 
            // desc_inptxt
            // 
            this.desc_inptxt.AutoSize = true;
            this.desc_inptxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.desc_inptxt.Location = new System.Drawing.Point(827, 156);
            this.desc_inptxt.Name = "desc_inptxt";
            this.desc_inptxt.Size = new System.Drawing.Size(78, 19);
            this.desc_inptxt.TabIndex = 7;
            this.desc_inptxt.Text = "Description";
            // 
            // desc_input
            // 
            this.desc_input.BackColor = System.Drawing.Color.Silver;
            this.desc_input.Location = new System.Drawing.Point(831, 178);
            this.desc_input.Name = "desc_input";
            this.desc_input.Size = new System.Drawing.Size(164, 180);
            this.desc_input.TabIndex = 9;
            this.desc_input.Text = "";
            // 
            // set_to_deleted
            // 
            this.set_to_deleted.BackColor = System.Drawing.Color.Black;
            this.set_to_deleted.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.set_to_deleted.ForeColor = System.Drawing.Color.White;
            this.set_to_deleted.Location = new System.Drawing.Point(831, 590);
            this.set_to_deleted.Name = "set_to_deleted";
            this.set_to_deleted.Size = new System.Drawing.Size(164, 41);
            this.set_to_deleted.TabIndex = 10;
            this.set_to_deleted.Text = "Delete selected task";
            this.set_to_deleted.UseVisualStyleBackColor = false;
            this.set_to_deleted.Click += new System.EventHandler(this.set_to_deleted_Click);
            // 
            // set_to_complete
            // 
            this.set_to_complete.BackColor = System.Drawing.Color.Black;
            this.set_to_complete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.set_to_complete.ForeColor = System.Drawing.Color.White;
            this.set_to_complete.Location = new System.Drawing.Point(831, 543);
            this.set_to_complete.Name = "set_to_complete";
            this.set_to_complete.Size = new System.Drawing.Size(164, 41);
            this.set_to_complete.TabIndex = 11;
            this.set_to_complete.Text = "Mark task as completed";
            this.set_to_complete.UseVisualStyleBackColor = false;
            this.set_to_complete.Click += new System.EventHandler(this.set_to_complete_Click);
            // 
            // deleted_tasks
            // 
            this.deleted_tasks.AllowUserToOrderColumns = true;
            this.deleted_tasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deleted_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleted_tasks.Location = new System.Drawing.Point(15, 68);
            this.deleted_tasks.Name = "deleted_tasks";
            this.deleted_tasks.Size = new System.Drawing.Size(797, 563);
            this.deleted_tasks.TabIndex = 12;
            // 
            // completed_tasks
            // 
            this.completed_tasks.AllowUserToOrderColumns = true;
            this.completed_tasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.completed_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completed_tasks.Location = new System.Drawing.Point(15, 68);
            this.completed_tasks.Name = "completed_tasks";
            this.completed_tasks.Size = new System.Drawing.Size(797, 563);
            this.completed_tasks.TabIndex = 13;
            this.completed_tasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 643);
            this.Controls.Add(this.completed_tasks);
            this.Controls.Add(this.deleted_tasks);
            this.Controls.Add(this.set_to_complete);
            this.Controls.Add(this.set_to_deleted);
            this.Controls.Add(this.desc_input);
            this.Controls.Add(this.desc_inptxt);
            this.Controls.Add(this.title_inp);
            this.Controls.Add(this.label_inptxt);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.createtasks);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleted_tasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completed_tasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mainpage;
        private System.Windows.Forms.Button comptasks;
        private System.Windows.Forms.Button deltasks;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button createtasks;
        private System.Windows.Forms.DataGridView todoList;
        private System.Windows.Forms.Label label_inptxt;
        private System.Windows.Forms.TextBox title_inp;
        private System.Windows.Forms.Label desc_inptxt;
        private System.Windows.Forms.RichTextBox desc_input;
        private System.Windows.Forms.Button set_to_deleted;
        private System.Windows.Forms.Button set_to_complete;
        private System.Windows.Forms.DataGridView deleted_tasks;
        private System.Windows.Forms.DataGridView completed_tasks;
    }
}

