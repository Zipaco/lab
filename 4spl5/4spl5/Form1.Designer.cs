namespace _4spl5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnIntegrate = new System.Windows.Forms.Button();
            this.Coeff_Equation1 = new System.Windows.Forms.TextBox();
            this.Coeff_Equation2 = new System.Windows.Forms.TextBox();
            this.Coeff_Equation3 = new System.Windows.Forms.TextBox();
            this.Integration_Board2 = new System.Windows.Forms.TextBox();
            this.Integration_Board1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(305, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(463, 354);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(305, 395);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(101, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Построить график";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click_1);
            // 
            // btnIntegrate
            // 
            this.btnIntegrate.Location = new System.Drawing.Point(584, 395);
            this.btnIntegrate.Name = "btnIntegrate";
            this.btnIntegrate.Size = new System.Drawing.Size(101, 23);
            this.btnIntegrate.TabIndex = 1;
            this.btnIntegrate.Text = "Интегрировать";
            this.btnIntegrate.UseVisualStyleBackColor = true;
            this.btnIntegrate.Click += new System.EventHandler(this.btnIntegrate_Click_1);
            // 
            // Coeff_Equation1
            // 
            this.Coeff_Equation1.Location = new System.Drawing.Point(41, 24);
            this.Coeff_Equation1.Name = "Coeff_Equation1";
            this.Coeff_Equation1.Size = new System.Drawing.Size(100, 20);
            this.Coeff_Equation1.TabIndex = 2;
            // 
            // Coeff_Equation2
            // 
            this.Coeff_Equation2.Location = new System.Drawing.Point(41, 50);
            this.Coeff_Equation2.Name = "Coeff_Equation2";
            this.Coeff_Equation2.Size = new System.Drawing.Size(100, 20);
            this.Coeff_Equation2.TabIndex = 2;
            // 
            // Coeff_Equation3
            // 
            this.Coeff_Equation3.Location = new System.Drawing.Point(41, 76);
            this.Coeff_Equation3.Name = "Coeff_Equation3";
            this.Coeff_Equation3.Size = new System.Drawing.Size(100, 20);
            this.Coeff_Equation3.TabIndex = 2;
            // 
            // Integration_Board2
            // 
            this.Integration_Board2.Location = new System.Drawing.Point(41, 166);
            this.Integration_Board2.Name = "Integration_Board2";
            this.Integration_Board2.Size = new System.Drawing.Size(100, 20);
            this.Integration_Board2.TabIndex = 2;
            // 
            // Integration_Board1
            // 
            this.Integration_Board1.Location = new System.Drawing.Point(41, 140);
            this.Integration_Board1.Name = "Integration_Board1";
            this.Integration_Board1.Size = new System.Drawing.Size(100, 20);
            this.Integration_Board1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Коэффициенты уравнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Границы интеграла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Integration_Board2);
            this.Controls.Add(this.Integration_Board1);
            this.Controls.Add(this.Coeff_Equation3);
            this.Controls.Add(this.Coeff_Equation2);
            this.Controls.Add(this.Coeff_Equation1);
            this.Controls.Add(this.btnIntegrate);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnIntegrate;
        private System.Windows.Forms.TextBox Coeff_Equation1;
        private System.Windows.Forms.TextBox Coeff_Equation2;
        private System.Windows.Forms.TextBox Coeff_Equation3;
        private System.Windows.Forms.TextBox Integration_Board2;
        private System.Windows.Forms.TextBox Integration_Board1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

