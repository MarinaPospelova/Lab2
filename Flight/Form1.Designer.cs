﻿namespace Flight
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaxY = new System.Windows.Forms.NumericUpDown();
            this.MaxX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeIndicator = new System.Windows.Forms.Label();
            this.btPause = new System.Windows.Forms.Button();
            this.edSquare = new System.Windows.Forms.NumericUpDown();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MaxY);
            this.panel1.Controls.Add(this.MaxX);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TimeIndicator);
            this.panel1.Controls.Add(this.btPause);
            this.panel1.Controls.Add(this.edSquare);
            this.panel1.Controls.Add(this.edWeight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edHeight);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 154);
            this.panel1.TabIndex = 0;
            // 
            // MaxY
            // 
            this.MaxY.Location = new System.Drawing.Point(676, 74);
            this.MaxY.Name = "MaxY";
            this.MaxY.Size = new System.Drawing.Size(120, 26);
            this.MaxY.TabIndex = 16;
            this.MaxY.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // MaxX
            // 
            this.MaxX.Location = new System.Drawing.Point(676, 23);
            this.MaxX.Name = "MaxX";
            this.MaxX.Size = new System.Drawing.Size(120, 26);
            this.MaxX.TabIndex = 15;
            this.MaxX.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "MaxY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "MaxX";
            // 
            // TimeIndicator
            // 
            this.TimeIndicator.AutoSize = true;
            this.TimeIndicator.Location = new System.Drawing.Point(308, 117);
            this.TimeIndicator.Name = "TimeIndicator";
            this.TimeIndicator.Size = new System.Drawing.Size(58, 20);
            this.TimeIndicator.TabIndex = 12;
            this.TimeIndicator.Text = "Время";
            // 
            // btPause
            // 
            this.btPause.Location = new System.Drawing.Point(831, 100);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(120, 40);
            this.btPause.TabIndex = 11;
            this.btPause.Text = "Пауза";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // edSquare
            // 
            this.edSquare.Location = new System.Drawing.Point(404, 68);
            this.edSquare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edSquare.Name = "edSquare";
            this.edSquare.Size = new System.Drawing.Size(135, 26);
            this.edSquare.TabIndex = 10;
            this.edSquare.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // edWeight
            // 
            this.edWeight.Location = new System.Drawing.Point(404, 22);
            this.edWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(135, 26);
            this.edWeight.TabIndex = 9;
            this.edWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Площадь:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Масса:";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(831, 14);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(120, 72);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Старт!";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(123, 108);
            this.edHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(147, 26);
            this.edHeight.TabIndex = 5;
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(123, 60);
            this.edSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(147, 26);
            this.edSpeed.TabIndex = 4;
            this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(126, 18);
            this.edAngle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(144, 26);
            this.edAngle.TabIndex = 3;
            this.edAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Угол:";
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 154);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Purple;
            series1.LabelForeColor = System.Drawing.Color.DarkMagenta;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(982, 497);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 651);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown edSquare;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Label TimeIndicator;
        private System.Windows.Forms.NumericUpDown MaxY;
        private System.Windows.Forms.NumericUpDown MaxX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

