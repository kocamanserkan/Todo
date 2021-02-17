namespace Todo
{
    partial class newEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImportanceDegree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBriefStatment = new System.Windows.Forms.TextBox();
            this.txtStatement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStage = new System.Windows.Forms.ComboBox();
            this.btnAddNewToDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtImportanceDegree
            // 
            this.txtImportanceDegree.Location = new System.Drawing.Point(177, 310);
            this.txtImportanceDegree.Name = "txtImportanceDegree";
            this.txtImportanceDegree.Size = new System.Drawing.Size(201, 22);
            this.txtImportanceDegree.TabIndex = 3;
            this.txtImportanceDegree.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtImportanceDegree.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Brief Statement";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Statement";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBriefStatment
            // 
            this.txtBriefStatment.Location = new System.Drawing.Point(177, 78);
            this.txtBriefStatment.Multiline = true;
            this.txtBriefStatment.Name = "txtBriefStatment";
            this.txtBriefStatment.Size = new System.Drawing.Size(201, 57);
            this.txtBriefStatment.TabIndex = 1;
            this.txtBriefStatment.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtBriefStatment.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // txtStatement
            // 
            this.txtStatement.Location = new System.Drawing.Point(177, 162);
            this.txtStatement.Multiline = true;
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.Size = new System.Drawing.Size(201, 129);
            this.txtStatement.TabIndex = 2;
            this.txtStatement.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtStatement.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Importance Degree";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(177, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(201, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stage";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbStage
            // 
            this.cmbStage.FormattingEnabled = true;
            this.cmbStage.Items.AddRange(new object[] {
            "Waiting",
            "Completed",
            "Uncompleted",
            "Cancelled",
            "Postponed"});
            this.cmbStage.Location = new System.Drawing.Point(177, 360);
            this.cmbStage.Name = "cmbStage";
            this.cmbStage.Size = new System.Drawing.Size(121, 24);
            this.cmbStage.TabIndex = 4;
            // 
            // btnAddNewToDo
            // 
            this.btnAddNewToDo.Location = new System.Drawing.Point(177, 409);
            this.btnAddNewToDo.Name = "btnAddNewToDo";
            this.btnAddNewToDo.Size = new System.Drawing.Size(201, 40);
            this.btnAddNewToDo.TabIndex = 5;
            this.btnAddNewToDo.Text = "Add To Do!";
            this.btnAddNewToDo.UseVisualStyleBackColor = true;
            this.btnAddNewToDo.Click += new System.EventHandler(this.btnAddNewToDo_Click);
            // 
            // newEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 492);
            this.Controls.Add(this.btnAddNewToDo);
            this.Controls.Add(this.cmbStage);
            this.Controls.Add(this.txtStatement);
            this.Controls.Add(this.txtBriefStatment);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtImportanceDegree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "newEntry";
            this.Text = "Adding To Do!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImportanceDegree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBriefStatment;
        private System.Windows.Forms.TextBox txtStatement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStage;
        private System.Windows.Forms.Button btnAddNewToDo;
    }
}