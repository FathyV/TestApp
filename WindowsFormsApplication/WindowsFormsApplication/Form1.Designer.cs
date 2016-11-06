namespace WindowsFormsApplication
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
            this.btnDoTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoTask
            // 
            this.btnDoTask.Location = new System.Drawing.Point(12, 12);
            this.btnDoTask.Name = "btnDoTask";
            this.btnDoTask.Size = new System.Drawing.Size(88, 34);
            this.btnDoTask.TabIndex = 0;
            this.btnDoTask.Text = "Do Task";
            this.btnDoTask.UseVisualStyleBackColor = true;
            this.btnDoTask.Click += new System.EventHandler(this.btnDoTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDoTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoTask;
    }
}

