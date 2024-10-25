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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.deltasks);
            this.panel1.Controls.Add(this.comptasks);
            this.panel1.Controls.Add(this.mainpage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
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
            this.pageLabel.Location = new System.Drawing.Point(435, 3);
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
            this.createtasks.Location = new System.Drawing.Point(862, 6);
            this.createtasks.Name = "createtasks";
            this.createtasks.Size = new System.Drawing.Size(150, 41);
            this.createtasks.TabIndex = 3;
            this.createtasks.Text = "Create new task";
            this.createtasks.UseVisualStyleBackColor = false;
            this.createtasks.Click += new System.EventHandler(this.createtasks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 643);
            this.Controls.Add(this.createtasks);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
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
    }
}

