namespace CaesarsCalendar
{
    partial class FormCaesarsCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaesarsCalendar));
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxWeekday = new System.Windows.Forms.ComboBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.labelWeekday = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.pictureBoxPuzzle = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFirstButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripPrevButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripNextButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripLastButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPuzzle)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DisplayMember = "Month";
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(52, 6);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(80, 21);
            this.comboBoxMonth.TabIndex = 0;
            this.comboBoxMonth.ValueMember = "Month";
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            this.comboBoxMonth.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMonth_SelectionChangeCommitted);
            // 
            // comboBoxWeekday
            // 
            this.comboBoxWeekday.FormattingEnabled = true;
            this.comboBoxWeekday.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.comboBoxWeekday.Location = new System.Drawing.Point(332, 7);
            this.comboBoxWeekday.Name = "comboBoxWeekday";
            this.comboBoxWeekday.Size = new System.Drawing.Size(94, 21);
            this.comboBoxWeekday.TabIndex = 1;
            this.comboBoxWeekday.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeekday_SelectedIndexChanged);
            this.comboBoxWeekday.SelectionChangeCommitted += new System.EventHandler(this.comboBoxWeekday_SelectionChangeCommitted);
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(12, 9);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(37, 13);
            this.labelMonth.TabIndex = 2;
            this.labelMonth.Text = "Month";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(162, 9);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(26, 13);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "Day";
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Location = new System.Drawing.Point(192, 7);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDay.TabIndex = 4;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.ValueChanged += new System.EventHandler(this.numericUpDownDay_ValueChanged);
            // 
            // labelWeekday
            // 
            this.labelWeekday.AutoSize = true;
            this.labelWeekday.Location = new System.Drawing.Point(272, 9);
            this.labelWeekday.Name = "labelWeekday";
            this.labelWeekday.Size = new System.Drawing.Size(53, 13);
            this.labelWeekday.TabIndex = 5;
            this.labelWeekday.Text = "Weekday";
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(451, 7);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(75, 23);
            this.buttonSolve.TabIndex = 6;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // pictureBoxPuzzle
            // 
            this.pictureBoxPuzzle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPuzzle.BackgroundImage")));
            this.pictureBoxPuzzle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPuzzle.Location = new System.Drawing.Point(10, 60);
            this.pictureBoxPuzzle.Name = "pictureBoxPuzzle";
            this.pictureBoxPuzzle.Size = new System.Drawing.Size(600, 687);
            this.pictureBoxPuzzle.TabIndex = 7;
            this.pictureBoxPuzzle.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(537, 7);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(65, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(332, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripFirstButton,
            this.toolStripPrevButton,
            this.toolStripStatusLabel,
            this.toolStripNextButton,
            this.toolStripLastButton,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 756);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(621, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(261, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripFirstButton
            // 
            this.toolStripFirstButton.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripFirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFirstButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFirstButton.Image")));
            this.toolStripFirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFirstButton.Name = "toolStripFirstButton";
            this.toolStripFirstButton.ShowDropDownArrow = false;
            this.toolStripFirstButton.Size = new System.Drawing.Size(20, 20);
            this.toolStripFirstButton.ToolTipText = "Go to first solution";
            this.toolStripFirstButton.Click += new System.EventHandler(this.toolStripFirstButton_Click);
            this.toolStripFirstButton.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // toolStripPrevButton
            // 
            this.toolStripPrevButton.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripPrevButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrevButton.DoubleClickEnabled = true;
            this.toolStripPrevButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrevButton.Image")));
            this.toolStripPrevButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrevButton.Name = "toolStripPrevButton";
            this.toolStripPrevButton.ShowDropDownArrow = false;
            this.toolStripPrevButton.Size = new System.Drawing.Size(20, 20);
            this.toolStripPrevButton.ToolTipText = "Previous Solution";
            this.toolStripPrevButton.Click += new System.EventHandler(this.toolStripPrevButton_Click);
            this.toolStripPrevButton.DoubleClick += new System.EventHandler(this.toolStripPrevButton_DoubleClick);
            this.toolStripPrevButton.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(4, 17);
            this.toolStripStatusLabel.ToolTipText = "test";
            // 
            // toolStripNextButton
            // 
            this.toolStripNextButton.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNextButton.DoubleClickEnabled = true;
            this.toolStripNextButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNextButton.Image")));
            this.toolStripNextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNextButton.Name = "toolStripNextButton";
            this.toolStripNextButton.ShowDropDownArrow = false;
            this.toolStripNextButton.Size = new System.Drawing.Size(20, 20);
            this.toolStripNextButton.ToolTipText = "Next solution";
            this.toolStripNextButton.Click += new System.EventHandler(this.toolStripNextButton_Click);
            this.toolStripNextButton.DoubleClick += new System.EventHandler(this.toolStripNextButton_DoubleClick);
            this.toolStripNextButton.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // toolStripLastButton
            // 
            this.toolStripLastButton.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripLastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLastButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLastButton.Image")));
            this.toolStripLastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLastButton.Name = "toolStripLastButton";
            this.toolStripLastButton.ShowDropDownArrow = false;
            this.toolStripLastButton.Size = new System.Drawing.Size(20, 20);
            this.toolStripLastButton.ToolTipText = "Go to last solution";
            this.toolStripLastButton.Click += new System.EventHandler(this.toolStripLastButton_Click);
            this.toolStripLastButton.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(261, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // FormCaesarsCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 778);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBoxPuzzle);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.labelWeekday);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.comboBoxWeekday);
            this.Controls.Add(this.comboBoxMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaesarsCalendar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Caesar\'s Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPuzzle)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxWeekday;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.Label labelWeekday;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.PictureBox pictureBoxPuzzle;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFirstButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripPrevButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripNextButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLastButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

