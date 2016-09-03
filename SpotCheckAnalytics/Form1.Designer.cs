namespace SpotCheckAnalytics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNotification = new System.Windows.Forms.ToolStripTextBox();
            this.chartEmployee = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.listEmployees = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.lblGuardCount = new System.Windows.Forms.Label();
            this.tabTop = new System.Windows.Forms.TabPage();
            this.dataPerformance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExceedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RectifyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Streak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSupervisor = new System.Windows.Forms.TabPage();
            this.btnViewSup = new System.Windows.Forms.Button();
            this.listSupervisors = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chartSupervisor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.checkDefault = new System.Windows.Forms.CheckBox();
            this.btnSetDefault = new System.Windows.Forms.Button();
            this.textDefault = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCommitChanges = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkAutoChart = new System.Windows.Forms.CheckBox();
            this.loadDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployee)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.tabTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).BeginInit();
            this.tabSupervisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSupervisor)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.txtNotification});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtNotification
            // 
            this.txtNotification.Enabled = false;
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.Size = new System.Drawing.Size(175, 23);
            this.txtNotification.Text = "<< Please Load Data";
            this.txtNotification.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // chartEmployee
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEmployee.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEmployee.Legends.Add(legend1);
            this.chartEmployee.Location = new System.Drawing.Point(160, 6);
            this.chartEmployee.Name = "chartEmployee";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Performance";
            this.chartEmployee.Series.Add(series1);
            this.chartEmployee.Size = new System.Drawing.Size(375, 273);
            this.chartEmployee.TabIndex = 1;
            this.chartEmployee.Text = "chart1";
            title1.Name = "MainTitle";
            title1.Text = "Employee Performance";
            title2.Name = "Count";
            title2.Text = "Total Entries:";
            this.chartEmployee.Titles.Add(title1);
            this.chartEmployee.Titles.Add(title2);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(6, 8);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(148, 23);
            this.btnViewAll.TabIndex = 2;
            this.btnViewAll.Text = "View Overall Data";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(6, 37);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(148, 23);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Employee Specific";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // listEmployees
            // 
            this.listEmployees.FormattingEnabled = true;
            this.listEmployees.Location = new System.Drawing.Point(6, 79);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(148, 199);
            this.listEmployees.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChart);
            this.tabControl1.Controls.Add(this.tabTop);
            this.tabControl1.Controls.Add(this.tabSupervisor);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 311);
            this.tabControl1.TabIndex = 5;
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.lblGuardCount);
            this.tabChart.Controls.Add(this.chartEmployee);
            this.tabChart.Controls.Add(this.listEmployees);
            this.tabChart.Controls.Add(this.btnViewAll);
            this.tabChart.Controls.Add(this.btnEmployee);
            this.tabChart.Location = new System.Drawing.Point(4, 22);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(541, 285);
            this.tabChart.TabIndex = 0;
            this.tabChart.Text = "Spot Checks";
            this.tabChart.UseVisualStyleBackColor = true;
            // 
            // lblGuardCount
            // 
            this.lblGuardCount.AutoSize = true;
            this.lblGuardCount.Location = new System.Drawing.Point(6, 63);
            this.lblGuardCount.Name = "lblGuardCount";
            this.lblGuardCount.Size = new System.Drawing.Size(80, 13);
            this.lblGuardCount.TabIndex = 5;
            this.lblGuardCount.Text = "Total Guards: 0";
            // 
            // tabTop
            // 
            this.tabTop.Controls.Add(this.dataPerformance);
            this.tabTop.Location = new System.Drawing.Point(4, 22);
            this.tabTop.Name = "tabTop";
            this.tabTop.Padding = new System.Windows.Forms.Padding(3);
            this.tabTop.Size = new System.Drawing.Size(541, 285);
            this.tabTop.TabIndex = 1;
            this.tabTop.Text = "Top Guards";
            this.tabTop.UseVisualStyleBackColor = true;
            // 
            // dataPerformance
            // 
            this.dataPerformance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ExceedCount,
            this.RectifyCount,
            this.FailCount,
            this.Score,
            this.Streak});
            this.dataPerformance.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataPerformance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataPerformance.Location = new System.Drawing.Point(9, 3);
            this.dataPerformance.Margin = new System.Windows.Forms.Padding(0);
            this.dataPerformance.Name = "dataPerformance";
            this.dataPerformance.ReadOnly = true;
            this.dataPerformance.RowHeadersVisible = false;
            this.dataPerformance.ShowCellErrors = false;
            this.dataPerformance.ShowEditingIcon = false;
            this.dataPerformance.ShowRowErrors = false;
            this.dataPerformance.Size = new System.Drawing.Size(529, 279);
            this.dataPerformance.TabIndex = 0;
            this.dataPerformance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPerformance_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ExceedCount
            // 
            this.ExceedCount.HeaderText = "Number of Exceeds";
            this.ExceedCount.Name = "ExceedCount";
            this.ExceedCount.ReadOnly = true;
            // 
            // RectifyCount
            // 
            this.RectifyCount.HeaderText = "Number of Rectifys";
            this.RectifyCount.Name = "RectifyCount";
            this.RectifyCount.ReadOnly = true;
            // 
            // FailCount
            // 
            this.FailCount.HeaderText = "Number of Fails";
            this.FailCount.Name = "FailCount";
            this.FailCount.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Total Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Streak
            // 
            this.Streak.HeaderText = "Highest Exceeds Streak";
            this.Streak.Name = "Streak";
            this.Streak.ReadOnly = true;
            // 
            // tabSupervisor
            // 
            this.tabSupervisor.Controls.Add(this.btnViewSup);
            this.tabSupervisor.Controls.Add(this.listSupervisors);
            this.tabSupervisor.Controls.Add(this.label3);
            this.tabSupervisor.Controls.Add(this.chartSupervisor);
            this.tabSupervisor.Location = new System.Drawing.Point(4, 22);
            this.tabSupervisor.Name = "tabSupervisor";
            this.tabSupervisor.Size = new System.Drawing.Size(541, 285);
            this.tabSupervisor.TabIndex = 3;
            this.tabSupervisor.Text = "Supervisor Checks";
            this.tabSupervisor.UseVisualStyleBackColor = true;
            // 
            // btnViewSup
            // 
            this.btnViewSup.Location = new System.Drawing.Point(6, 247);
            this.btnViewSup.Name = "btnViewSup";
            this.btnViewSup.Size = new System.Drawing.Size(142, 23);
            this.btnViewSup.TabIndex = 3;
            this.btnViewSup.Text = "View Selected";
            this.btnViewSup.UseVisualStyleBackColor = true;
            this.btnViewSup.Click += new System.EventHandler(this.btnViewSup_Click);
            // 
            // listSupervisors
            // 
            this.listSupervisors.FormattingEnabled = true;
            this.listSupervisors.Location = new System.Drawing.Point(6, 29);
            this.listSupervisors.Name = "listSupervisors";
            this.listSupervisors.Size = new System.Drawing.Size(142, 212);
            this.listSupervisors.TabIndex = 2;
            this.listSupervisors.SelectedIndexChanged += new System.EventHandler(this.listSupervisors_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "List of Supervisors";
            // 
            // chartSupervisor
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSupervisor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSupervisor.Legends.Add(legend2);
            this.chartSupervisor.Location = new System.Drawing.Point(227, 3);
            this.chartSupervisor.Name = "chartSupervisor";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSupervisor.Series.Add(series2);
            this.chartSupervisor.Size = new System.Drawing.Size(311, 279);
            this.chartSupervisor.TabIndex = 0;
            this.chartSupervisor.Text = "chart1";
            title3.Name = "MainTitle";
            title3.Text = "Supervisor Checks Given";
            title4.Name = "Count";
            title4.Text = "Total Checks Given:";
            this.chartSupervisor.Titles.Add(title3);
            this.chartSupervisor.Titles.Add(title4);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.checkDefault);
            this.tabSettings.Controls.Add(this.btnSetDefault);
            this.tabSettings.Controls.Add(this.textDefault);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.btnCommitChanges);
            this.tabSettings.Controls.Add(this.textPassword);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.checkAutoChart);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(541, 285);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // checkDefault
            // 
            this.checkDefault.AutoSize = true;
            this.checkDefault.Location = new System.Drawing.Point(6, 96);
            this.checkDefault.Name = "checkDefault";
            this.checkDefault.Size = new System.Drawing.Size(174, 17);
            this.checkDefault.TabIndex = 7;
            this.checkDefault.Text = "Use Default Excel File Location";
            this.checkDefault.UseVisualStyleBackColor = true;
            this.checkDefault.CheckedChanged += new System.EventHandler(this.checkDefault_CheckedChanged);
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.Location = new System.Drawing.Point(163, 67);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(18, 23);
            this.btnSetDefault.TabIndex = 6;
            this.btnSetDefault.Text = "?";
            this.btnSetDefault.UseVisualStyleBackColor = true;
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // textDefault
            // 
            this.textDefault.Location = new System.Drawing.Point(6, 69);
            this.textDefault.Name = "textDefault";
            this.textDefault.Size = new System.Drawing.Size(151, 20);
            this.textDefault.TabIndex = 5;
            this.textDefault.TextChanged += new System.EventHandler(this.textDefault_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Default Excel File:";
            // 
            // btnCommitChanges
            // 
            this.btnCommitChanges.Enabled = false;
            this.btnCommitChanges.Location = new System.Drawing.Point(6, 142);
            this.btnCommitChanges.Name = "btnCommitChanges";
            this.btnCommitChanges.Size = new System.Drawing.Size(175, 23);
            this.btnCommitChanges.TabIndex = 3;
            this.btnCommitChanges.Text = "Save Changes";
            this.btnCommitChanges.UseVisualStyleBackColor = true;
            this.btnCommitChanges.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(6, 30);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(175, 20);
            this.textPassword.TabIndex = 2;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excel Spreadsheet Loading Password:";
            // 
            // checkAutoChart
            // 
            this.checkAutoChart.AutoSize = true;
            this.checkAutoChart.Location = new System.Drawing.Point(6, 119);
            this.checkAutoChart.Name = "checkAutoChart";
            this.checkAutoChart.Size = new System.Drawing.Size(175, 17);
            this.checkAutoChart.TabIndex = 0;
            this.checkAutoChart.Text = "Auto Chart Overall Performance";
            this.checkAutoChart.UseVisualStyleBackColor = true;
            this.checkAutoChart.CheckedChanged += new System.EventHandler(this.checkAutoChart_CheckedChanged);
            // 
            // loadDialog
            // 
            this.loadDialog.FileName = "SpotCheckMaster";
            this.loadDialog.Title = "Select Spot Check Excel File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 350);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Employee Performance Analytics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployee)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabChart.ResumeLayout(false);
            this.tabChart.PerformLayout();
            this.tabTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).EndInit();
            this.tabSupervisor.ResumeLayout(false);
            this.tabSupervisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSupervisor)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployee;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.ListBox listEmployees;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.TabPage tabTop;
        private System.Windows.Forms.DataGridView dataPerformance;
        private System.Windows.Forms.OpenFileDialog loadDialog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExceedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RectifyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Streak;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button btnCommitChanges;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkAutoChart;
        private System.Windows.Forms.Button btnSetDefault;
        private System.Windows.Forms.TextBox textDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkDefault;
        private System.Windows.Forms.Label lblGuardCount;
        private System.Windows.Forms.ToolStripTextBox txtNotification;
        private System.Windows.Forms.TabPage tabSupervisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSupervisor;
        private System.Windows.Forms.Button btnViewSup;
        private System.Windows.Forms.ListBox listSupervisors;
    }
}

