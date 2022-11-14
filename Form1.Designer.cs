namespace AstronomicalProcessing
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
            this.components = new System.ComponentModel.Container();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.BtnBinarySearch = new System.Windows.Forms.Button();
            this.BtnMean = new System.Windows.Forms.Button();
            this.BtnMode = new System.Windows.Forms.Button();
            this.BtnMidExtreme = new System.Windows.Forms.Button();
            this.BtnRange = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(18, 131);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(112, 35);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.BtnAdd, "Add Data Set to ListBox");
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(160, 131);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(112, 35);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.BtnEdit, "Edit Data Entry");
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(18, 191);
            this.BtnSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(112, 35);
            this.BtnSort.TabIndex = 2;
            this.BtnSort.Text = "Sort";
            this.toolTip1.SetToolTip(this.BtnSort, "Sort Data Numerically");
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 3;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 20;
            this.ListBox.Location = new System.Drawing.Point(441, 45);
            this.ListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(178, 484);
            this.ListBox.TabIndex = 4;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // BtnBinarySearch
            // 
            this.BtnBinarySearch.Location = new System.Drawing.Point(160, 189);
            this.BtnBinarySearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBinarySearch.Name = "BtnBinarySearch";
            this.BtnBinarySearch.Size = new System.Drawing.Size(112, 35);
            this.BtnBinarySearch.TabIndex = 5;
            this.BtnBinarySearch.Text = "Binary Search";
            this.toolTip1.SetToolTip(this.BtnBinarySearch, "Binary Search of ListBox");
            this.BtnBinarySearch.UseVisualStyleBackColor = true;
            this.BtnBinarySearch.Click += new System.EventHandler(this.BtnBinarySearch_Click);
            // 
            // BtnMean
            // 
            this.BtnMean.Location = new System.Drawing.Point(18, 251);
            this.BtnMean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMean.Name = "BtnMean";
            this.BtnMean.Size = new System.Drawing.Size(112, 35);
            this.BtnMean.TabIndex = 6;
            this.BtnMean.Text = "Mean";
            this.toolTip1.SetToolTip(this.BtnMean, "Calculate Mean of data set");
            this.BtnMean.UseVisualStyleBackColor = true;
            this.BtnMean.Click += new System.EventHandler(this.BtnMean_Click);
            // 
            // BtnMode
            // 
            this.BtnMode.Location = new System.Drawing.Point(160, 251);
            this.BtnMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMode.Name = "BtnMode";
            this.BtnMode.Size = new System.Drawing.Size(112, 35);
            this.BtnMode.TabIndex = 7;
            this.BtnMode.Text = "Mode";
            this.toolTip1.SetToolTip(this.BtnMode, "Find Mode of data set ");
            this.BtnMode.UseVisualStyleBackColor = true;
            this.BtnMode.Click += new System.EventHandler(this.BtnMode_Click);
            // 
            // BtnMidExtreme
            // 
            this.BtnMidExtreme.Location = new System.Drawing.Point(160, 308);
            this.BtnMidExtreme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMidExtreme.Name = "BtnMidExtreme";
            this.BtnMidExtreme.Size = new System.Drawing.Size(112, 35);
            this.BtnMidExtreme.TabIndex = 8;
            this.BtnMidExtreme.Text = "Mid-Extreme";
            this.toolTip1.SetToolTip(this.BtnMidExtreme, "Find Mid-Extreme of data set");
            this.BtnMidExtreme.UseVisualStyleBackColor = true;
            this.BtnMidExtreme.Click += new System.EventHandler(this.BtnMidExtreme_Click);
            // 
            // BtnRange
            // 
            this.BtnRange.Location = new System.Drawing.Point(20, 308);
            this.BtnRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRange.Name = "BtnRange";
            this.BtnRange.Size = new System.Drawing.Size(112, 35);
            this.BtnRange.TabIndex = 9;
            this.BtnRange.Text = "Range";
            this.toolTip1.SetToolTip(this.BtnRange, "Find Range of data set ");
            this.BtnRange.UseVisualStyleBackColor = true;
            this.BtnRange.Click += new System.EventHandler(this.BtnRange_Click);
            // 
            // btnSSearch
            // 
            this.btnSSearch.Location = new System.Drawing.Point(18, 366);
            this.btnSSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(255, 62);
            this.btnSSearch.TabIndex = 10;
            this.btnSSearch.Text = "Sequential Search";
            this.toolTip1.SetToolTip(this.btnSSearch, "Sequential search of data set");
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.Click += new System.EventHandler(this.btnSSearch_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 458);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 26);
            this.textBox2.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBox2, "Mean, Mode, Range and Mid-Extreme Calculations will appear here");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Result:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 32);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 542);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSSearch);
            this.Controls.Add(this.BtnRange);
            this.Controls.Add(this.BtnMidExtreme);
            this.Controls.Add(this.BtnMode);
            this.Controls.Add(this.BtnMean);
            this.Controls.Add(this.BtnBinarySearch);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button BtnBinarySearch;
        private System.Windows.Forms.Button BtnMean;
        private System.Windows.Forms.Button BtnMode;
        private System.Windows.Forms.Button BtnMidExtreme;
        private System.Windows.Forms.Button BtnRange;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

