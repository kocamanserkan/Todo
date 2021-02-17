
namespace Todo
{
    partial class EntryList
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
            this.grbOperationList = new System.Windows.Forms.GroupBox();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.btnAllList = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnUncompleted = new System.Windows.Forms.Button();
            this.btnCancelled = new System.Windows.Forms.Button();
            this.grbOperationList.SuspendLayout();
            this.grbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOperationList
            // 
            this.grbOperationList.Controls.Add(this.btnCancelled);
            this.grbOperationList.Controls.Add(this.btnUncompleted);
            this.grbOperationList.Controls.Add(this.btnCompleted);
            this.grbOperationList.Controls.Add(this.btnAllList);
            this.grbOperationList.Location = new System.Drawing.Point(0, 12);
            this.grbOperationList.Name = "grbOperationList";
            this.grbOperationList.Size = new System.Drawing.Size(200, 359);
            this.grbOperationList.TabIndex = 0;
            this.grbOperationList.TabStop = false;
            this.grbOperationList.Text = "Operation List";
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dataGridview1);
            this.grbList.Location = new System.Drawing.Point(225, 12);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(698, 575);
            this.grbList.TabIndex = 1;
            this.grbList.TabStop = false;
            this.grbList.Text = "To Do List!";
            // 
            // dataGridview1
            // 
            this.dataGridview1.AllowUserToAddRows = false;
            this.dataGridview1.AllowUserToDeleteRows = false;
            this.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridview1.Location = new System.Drawing.Point(3, 18);
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.ReadOnly = true;
            this.dataGridview1.RowHeadersWidth = 51;
            this.dataGridview1.RowTemplate.Height = 24;
            this.dataGridview1.Size = new System.Drawing.Size(692, 554);
            this.dataGridview1.TabIndex = 0;
            this.dataGridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview1_CellContentClick);
            // 
            // btnAllList
            // 
            this.btnAllList.Location = new System.Drawing.Point(26, 44);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(152, 38);
            this.btnAllList.TabIndex = 1;
            this.btnAllList.Text = "All To Do!";
            this.btnAllList.UseVisualStyleBackColor = true;
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(26, 88);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(152, 38);
            this.btnCompleted.TabIndex = 1;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUncompleted
            // 
            this.btnUncompleted.Location = new System.Drawing.Point(26, 148);
            this.btnUncompleted.Name = "btnUncompleted";
            this.btnUncompleted.Size = new System.Drawing.Size(152, 38);
            this.btnUncompleted.TabIndex = 1;
            this.btnUncompleted.Text = "Uncompleted";
            this.btnUncompleted.UseVisualStyleBackColor = true;
            this.btnUncompleted.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelled
            // 
            this.btnCancelled.Location = new System.Drawing.Point(26, 204);
            this.btnCancelled.Name = "btnCancelled";
            this.btnCancelled.Size = new System.Drawing.Size(152, 38);
            this.btnCancelled.TabIndex = 1;
            this.btnCancelled.Text = "Cancelled";
            this.btnCancelled.UseVisualStyleBackColor = true;
            this.btnCancelled.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 631);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.grbOperationList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EntryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do! List";
            this.Load += new System.EventHandler(this.EntryList_Load);
            this.grbOperationList.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOperationList;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.DataGridView dataGridview1;
        private System.Windows.Forms.Button btnCancelled;
        private System.Windows.Forms.Button btnUncompleted;
    }
}