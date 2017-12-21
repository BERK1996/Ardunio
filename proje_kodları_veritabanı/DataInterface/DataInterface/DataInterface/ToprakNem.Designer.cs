namespace DataInterface
{
    partial class ToprakNem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arduinoDataSet = new DataInterface.ArduinoDataSet();
            this.nemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nemTableAdapter = new DataInterface.ArduinoDataSetTableAdapters.nemTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.nemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 241);
            this.dataGridView1.TabIndex = 1;
            // 
            // arduinoDataSet
            // 
            this.arduinoDataSet.DataSetName = "ArduinoDataSet";
            this.arduinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nemBindingSource
            // 
            this.nemBindingSource.DataMember = "nem";
            this.nemBindingSource.DataSource = this.arduinoDataSet;
            // 
            // nemTableAdapter
            // 
            this.nemTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.nemBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 269);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "nem";
            series1.XValueMember = "nem";
            series1.YValueMembers = "id";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(448, 282);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // nemBindingSource1
            // 
            this.nemBindingSource1.DataMember = "nem";
            this.nemBindingSource1.DataSource = this.arduinoDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "TARİH";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nemDataGridViewTextBoxColumn
            // 
            this.nemDataGridViewTextBoxColumn.DataPropertyName = "nem";
            this.nemDataGridViewTextBoxColumn.HeaderText = "NEM";
            this.nemDataGridViewTextBoxColumn.Name = "nemDataGridViewTextBoxColumn";
            this.nemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ToprakNem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ToprakNem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToprakNem";
            this.Load += new System.EventHandler(this.ToprakNem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ArduinoDataSet arduinoDataSet;
        private System.Windows.Forms.BindingSource nemBindingSource;
        private ArduinoDataSetTableAdapters.nemTableAdapter nemTableAdapter;
        private System.Windows.Forms.BindingSource nemBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemDataGridViewTextBoxColumn;
    }
}