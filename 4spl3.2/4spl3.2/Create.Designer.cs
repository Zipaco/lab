namespace _4spl3._2
{
    partial class Create
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
            this.width = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.widthT = new System.Windows.Forms.TextBox();
            this.heightT = new System.Windows.Forms.TextBox();
            this.confirmB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(31, 38);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(46, 13);
            this.width.TabIndex = 0;
            this.width.Text = "Ширина";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(31, 75);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(45, 13);
            this.height.TabIndex = 0;
            this.height.Text = "Высота";
            // 
            // widthT
            // 
            this.widthT.Location = new System.Drawing.Point(104, 38);
            this.widthT.Name = "widthT";
            this.widthT.Size = new System.Drawing.Size(100, 20);
            this.widthT.TabIndex = 1;
            // 
            // heightT
            // 
            this.heightT.Location = new System.Drawing.Point(104, 75);
            this.heightT.Name = "heightT";
            this.heightT.Size = new System.Drawing.Size(100, 20);
            this.heightT.TabIndex = 1;
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(34, 128);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(75, 23);
            this.confirmB.TabIndex = 2;
            this.confirmB.Text = "Ок";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(129, 128);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 23);
            this.exitB.TabIndex = 2;
            this.exitB.Text = "Выход";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Создание нового холста";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(223, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.heightT);
            this.Controls.Add(this.widthT);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Create";
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox widthT;
        private System.Windows.Forms.TextBox heightT;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Label label1;
    }
}