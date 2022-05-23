namespace Inventory_Tracker
{
    partial class WelecomePg
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
            this.loadData = new System.Windows.Forms.Button();
            this.newData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(54, 369);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(206, 164);
            this.loadData.TabIndex = 0;
            this.loadData.Text = "Load Data";
            this.loadData.UseVisualStyleBackColor = true;
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(829, 376);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(278, 157);
            this.newData.TabIndex = 1;
            this.newData.Text = "New Data";
            this.newData.UseVisualStyleBackColor = true;
            this.newData.Click += new System.EventHandler(this.newData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welecome to inventory tracker!";
            // 
            // WelecomePg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 723);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newData);
            this.Controls.Add(this.loadData);
            this.Name = "WelecomePg";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Button newData;
        private System.Windows.Forms.Label label1;
    }
}

