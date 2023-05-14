namespace SubmarineForms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startButton = new System.Windows.Forms.Button();
            this.DeepTextBox = new System.Windows.Forms.TextBox();
            this.deepLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.squareLabel = new System.Windows.Forms.Label();
            this.squareTextBox = new System.Windows.Forms.TextBox();
            this.densityLabel = new System.Windows.Forms.Label();
            this.densityTextBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.Timelabel = new System.Windows.Forms.Label();
            this.timeLabelZT = new System.Windows.Forms.Label();
            this.timeLabelSpeed = new System.Windows.Forms.Label();
            this.ascentPointLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.resultLabel2 = new System.Windows.Forms.Label();
            this.resultLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea7.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea7);
            this.chart.Location = new System.Drawing.Point(482, 24);
            this.chart.Name = "chart";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Firebrick;
            series7.IsVisibleInLegend = false;
            series7.Name = "Series1";
            this.chart.Series.Add(series7);
            this.chart.Size = new System.Drawing.Size(779, 572);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(38, 24);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(404, 75);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Начать всплытие";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // DeepTextBox
            // 
            this.DeepTextBox.Location = new System.Drawing.Point(38, 131);
            this.DeepTextBox.Name = "DeepTextBox";
            this.DeepTextBox.Size = new System.Drawing.Size(404, 31);
            this.DeepTextBox.TabIndex = 2;
            this.DeepTextBox.Text = "1000";
            // 
            // deepLabel
            // 
            this.deepLabel.AutoSize = true;
            this.deepLabel.Location = new System.Drawing.Point(33, 103);
            this.deepLabel.Name = "deepLabel";
            this.deepLabel.Size = new System.Drawing.Size(95, 25);
            this.deepLabel.TabIndex = 3;
            this.deepLabel.Text = "Глубина";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(32, 170);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(181, 25);
            this.volumeLabel.TabIndex = 5;
            this.volumeLabel.Text = "Объем подлодки";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(37, 198);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(404, 31);
            this.volumeTextBox.TabIndex = 4;
            this.volumeTextBox.Text = "10000";
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Location = new System.Drawing.Point(32, 238);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(291, 25);
            this.squareLabel.TabIndex = 7;
            this.squareLabel.Text = "Площадь сечения подлодки";
            // 
            // squareTextBox
            // 
            this.squareTextBox.Location = new System.Drawing.Point(37, 266);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(404, 31);
            this.squareTextBox.TabIndex = 6;
            this.squareTextBox.Text = "1000";
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Location = new System.Drawing.Point(32, 307);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(333, 25);
            this.densityLabel.TabIndex = 9;
            this.densityLabel.Text = "Плотность материала подлодки";
            // 
            // densityTextBox
            // 
            this.densityTextBox.Location = new System.Drawing.Point(37, 335);
            this.densityTextBox.Name = "densityTextBox";
            this.densityTextBox.Size = new System.Drawing.Size(404, 31);
            this.densityTextBox.TabIndex = 8;
            this.densityTextBox.Text = "7800";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(33, 376);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(307, 25);
            this.speedLabel.TabIndex = 11;
            this.speedLabel.Text = "Скорость всплытия подлодки";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(37, 404);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(404, 31);
            this.speedTextBox.TabIndex = 10;
            this.speedTextBox.Text = "80";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timelabel.Location = new System.Drawing.Point(31, 454);
            this.Timelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(230, 31);
            this.Timelabel.TabIndex = 12;
            this.Timelabel.Text = "Время всплытия:";
            // 
            // timeLabelZT
            // 
            this.timeLabelZT.AutoSize = true;
            this.timeLabelZT.Location = new System.Drawing.Point(57, 485);
            this.timeLabelZT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeLabelZT.Name = "timeLabelZT";
            this.timeLabelZT.Size = new System.Drawing.Size(233, 25);
            this.timeLabelZT.TabIndex = 13;
            this.timeLabelZT.Text = "По апроксимации z(t):";
            // 
            // timeLabelSpeed
            // 
            this.timeLabelSpeed.AutoSize = true;
            this.timeLabelSpeed.Location = new System.Drawing.Point(57, 510);
            this.timeLabelSpeed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeLabelSpeed.Name = "timeLabelSpeed";
            this.timeLabelSpeed.Size = new System.Drawing.Size(142, 25);
            this.timeLabelSpeed.TabIndex = 14;
            this.timeLabelSpeed.Text = "По скорости:";
            // 
            // ascentPointLabel
            // 
            this.ascentPointLabel.AutoSize = true;
            this.ascentPointLabel.Location = new System.Drawing.Point(32, 545);
            this.ascentPointLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ascentPointLabel.Name = "ascentPointLabel";
            this.ascentPointLabel.Size = new System.Drawing.Size(227, 25);
            this.ascentPointLabel.TabIndex = 15;
            this.ascentPointLabel.Text = "Точка всплытия: (0;0)";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(32, 638);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(0, 25);
            this.pointsLabel.TabIndex = 21;
            // 
            // resultLabel2
            // 
            this.resultLabel2.AutoSize = true;
            this.resultLabel2.Location = new System.Drawing.Point(33, 1238);
            this.resultLabel2.Name = "resultLabel2";
            this.resultLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.resultLabel2.Size = new System.Drawing.Size(0, 55);
            this.resultLabel2.TabIndex = 20;
            // 
            // resultLabel1
            // 
            this.resultLabel1.AutoSize = true;
            this.resultLabel1.Location = new System.Drawing.Point(33, 1177);
            this.resultLabel1.Name = "resultLabel1";
            this.resultLabel1.Size = new System.Drawing.Size(0, 25);
            this.resultLabel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 1214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Аппроксимация полученных значений по z(t):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 1152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Аппроксмация полученных значений по z(y):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Первые 20 точек после метода Рунге-Кутта 4 порядка:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1286, 1419);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.resultLabel2);
            this.Controls.Add(this.resultLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ascentPointLabel);
            this.Controls.Add(this.timeLabelSpeed);
            this.Controls.Add(this.timeLabelZT);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.densityLabel);
            this.Controls.Add(this.densityTextBox);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.squareTextBox);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.deepLabel);
            this.Controls.Add(this.DeepTextBox);
            this.Controls.Add(this.startButton);
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
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox DeepTextBox;
        private System.Windows.Forms.Label deepLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.TextBox squareTextBox;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.TextBox densityTextBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label timeLabelZT;
        private System.Windows.Forms.Label timeLabelSpeed;
        private System.Windows.Forms.Label ascentPointLabel;
        public System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label resultLabel2;
        private System.Windows.Forms.Label resultLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

