namespace CopyDirectory
{
    partial class Window
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
            this.Source = new System.Windows.Forms.TextBox();
            this.Target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogsList = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Source
            // 
            this.Source.Location = new System.Drawing.Point(59, 9);
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.Size = new System.Drawing.Size(351, 20);
            this.Source.TabIndex = 0;
            this.Source.Click += new System.EventHandler(this.Source_Click);
            // 
            // Target
            // 
            this.Target.Location = new System.Drawing.Point(59, 35);
            this.Target.Name = "Target";
            this.Target.ReadOnly = true;
            this.Target.Size = new System.Drawing.Size(270, 20);
            this.Target.TabIndex = 1;
            this.Target.Click += new System.EventHandler(this.Target_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target";
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(335, 33);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogsList);
            this.groupBox1.Location = new System.Drawing.Point(18, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 212);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // LogsList
            // 
            this.LogsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.LogsList.HideSelection = false;
            this.LogsList.Location = new System.Drawing.Point(6, 19);
            this.LogsList.Name = "LogsList";
            this.LogsList.Size = new System.Drawing.Size(380, 187);
            this.LogsList.TabIndex = 6;
            this.LogsList.UseCompatibleStateImageBehavior = false;
            this.LogsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Output";
            this.columnHeader.Width = 360;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 282);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.Source);
            this.Name = "Window";
            this.Text = "Copy Directories";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Source;
        private System.Windows.Forms.TextBox Target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView LogsList;
        private System.Windows.Forms.ColumnHeader columnHeader;
    }
}