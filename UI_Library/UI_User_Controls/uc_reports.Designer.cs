namespace Weka.UI_Library.UI_User_Controls
{
    partial class uc_reports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_reports));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuGauge1 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuGauge2 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuGauge3 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuProgressBar3 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 339);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(963, 245);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // bunifuGauge1
            // 
            this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
            this.bunifuGauge1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGauge1.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuGauge1.Location = new System.Drawing.Point(89, 59);
            this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuGauge1.Name = "bunifuGauge1";
            this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.Red;
            this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.Red;
            this.bunifuGauge1.Size = new System.Drawing.Size(236, 167);
            this.bunifuGauge1.TabIndex = 2;
            this.bunifuGauge1.Thickness = 30;
            this.bunifuGauge1.Value = 35;
            // 
            // bunifuGauge2
            // 
            this.bunifuGauge2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge2.BackgroundImage")));
            this.bunifuGauge2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGauge2.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuGauge2.Location = new System.Drawing.Point(370, 59);
            this.bunifuGauge2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuGauge2.Name = "bunifuGauge2";
            this.bunifuGauge2.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge2.ProgressColor1 = System.Drawing.Color.Red;
            this.bunifuGauge2.ProgressColor2 = System.Drawing.Color.Red;
            this.bunifuGauge2.Size = new System.Drawing.Size(236, 167);
            this.bunifuGauge2.TabIndex = 3;
            this.bunifuGauge2.Thickness = 30;
            this.bunifuGauge2.Value = 67;
            // 
            // bunifuGauge3
            // 
            this.bunifuGauge3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge3.BackgroundImage")));
            this.bunifuGauge3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGauge3.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuGauge3.Location = new System.Drawing.Point(666, 59);
            this.bunifuGauge3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuGauge3.Name = "bunifuGauge3";
            this.bunifuGauge3.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge3.ProgressColor1 = System.Drawing.Color.Red;
            this.bunifuGauge3.ProgressColor2 = System.Drawing.Color.Red;
            this.bunifuGauge3.Size = new System.Drawing.Size(236, 167);
            this.bunifuGauge3.TabIndex = 4;
            this.bunifuGauge3.Thickness = 30;
            this.bunifuGauge3.Value = 90;
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.White;
            this.bunifuProgressBar2.BorderRadius = 5;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(218, 257);
            this.bunifuProgressBar2.MaximumValue = 100;
            this.bunifuProgressBar2.Name = "bunifuProgressBar2";
            this.bunifuProgressBar2.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBar2.Size = new System.Drawing.Size(664, 10);
            this.bunifuProgressBar2.TabIndex = 7;
            this.bunifuProgressBar2.Value = 57;
            // 
            // bunifuProgressBar3
            // 
            this.bunifuProgressBar3.BackColor = System.Drawing.Color.White;
            this.bunifuProgressBar3.BorderRadius = 5;
            this.bunifuProgressBar3.Location = new System.Drawing.Point(218, 309);
            this.bunifuProgressBar3.MaximumValue = 100;
            this.bunifuProgressBar3.Name = "bunifuProgressBar3";
            this.bunifuProgressBar3.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBar3.Size = new System.Drawing.Size(664, 10);
            this.bunifuProgressBar3.TabIndex = 8;
            this.bunifuProgressBar3.Value = 67;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.White;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(218, 283);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(664, 10);
            this.bunifuProgressBar1.TabIndex = 9;
            this.bunifuProgressBar1.Value = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(171, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 260;
            this.label6.Text = "Uploaded";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 261;
            this.label1.Text = "Downloaded";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(729, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 262;
            this.label2.Text = "Espace restant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 263;
            this.label3.Text = "Uploaded";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 264;
            this.label4.Text = "Uploaded";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(109, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 265;
            this.label5.Text = "Uploaded";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(392, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 19);
            this.label7.TabIndex = 266;
            this.label7.Text = "Par type de fichier";
            // 
            // uc_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuProgressBar3);
            this.Controls.Add(this.bunifuProgressBar2);
            this.Controls.Add(this.bunifuGauge3);
            this.Controls.Add(this.bunifuGauge2);
            this.Controls.Add(this.bunifuGauge1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "uc_reports";
            this.Size = new System.Drawing.Size(963, 584);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge1;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge2;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge3;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar3;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}
