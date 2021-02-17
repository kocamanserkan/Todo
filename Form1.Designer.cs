namespace Todo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlIslemList = new System.Windows.Forms.Panel();
            this.grpOperationList = new System.Windows.Forms.GroupBox();
            this.btnExitToDo = new System.Windows.Forms.Button();
            this.btnListToDo = new System.Windows.Forms.Button();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmr_Timing = new System.Windows.Forms.Timer(this.components);
            this.pnlIslemList.SuspendLayout();
            this.grpOperationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIslemList
            // 
            this.pnlIslemList.Controls.Add(this.grpOperationList);
            this.pnlIslemList.Controls.Add(this.pictureBox1);
            this.pnlIslemList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIslemList.Location = new System.Drawing.Point(0, 0);
            this.pnlIslemList.Name = "pnlIslemList";
            this.pnlIslemList.Size = new System.Drawing.Size(249, 685);
            this.pnlIslemList.TabIndex = 0;
            // 
            // grpOperationList
            // 
            this.grpOperationList.Controls.Add(this.btnExitToDo);
            this.grpOperationList.Controls.Add(this.btnListToDo);
            this.grpOperationList.Controls.Add(this.btnAddToDo);
            this.grpOperationList.Location = new System.Drawing.Point(31, 272);
            this.grpOperationList.Name = "grpOperationList";
            this.grpOperationList.Size = new System.Drawing.Size(185, 256);
            this.grpOperationList.TabIndex = 2;
            this.grpOperationList.TabStop = false;
            this.grpOperationList.Text = "Operations";
            // 
            // btnExitToDo
            // 
            this.btnExitToDo.Location = new System.Drawing.Point(39, 172);
            this.btnExitToDo.Name = "btnExitToDo";
            this.btnExitToDo.Size = new System.Drawing.Size(108, 44);
            this.btnExitToDo.TabIndex = 2;
            this.btnExitToDo.Text = "Exit";
            this.btnExitToDo.UseVisualStyleBackColor = true;
            this.btnExitToDo.Click += new System.EventHandler(this.btnExitToDo_Click);
            // 
            // btnListToDo
            // 
            this.btnListToDo.Location = new System.Drawing.Point(39, 108);
            this.btnListToDo.Name = "btnListToDo";
            this.btnListToDo.Size = new System.Drawing.Size(108, 44);
            this.btnListToDo.TabIndex = 2;
            this.btnListToDo.Text = "List To Do!";
            this.btnListToDo.UseVisualStyleBackColor = true;
            this.btnListToDo.Click += new System.EventHandler(this.btnListToDo_Click);
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(39, 43);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(108, 44);
            this.btnAddToDo.TabIndex = 2;
            this.btnAddToDo.Text = "Add To Do!";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTimer
            // 
            this.pnlTimer.Controls.Add(this.label1);
            this.pnlTimer.Controls.Add(this.lblTime);
            this.pnlTimer.Location = new System.Drawing.Point(685, 597);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(454, 66);
            this.pnlTimer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date-Time";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(3, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 29);
            this.lblTime.TabIndex = 0;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 685);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.pnlIslemList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "App To Do!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlIslemList.ResumeLayout(false);
            this.grpOperationList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIslemList;
        private System.Windows.Forms.GroupBox grpOperationList;
        private System.Windows.Forms.Button btnExitToDo;
        private System.Windows.Forms.Button btnListToDo;
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Timer tmr_Timing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
    }
}

