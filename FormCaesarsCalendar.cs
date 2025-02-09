using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CaesarsCalendar
{
    public partial class FormCaesarsCalendar : System.Windows.Forms.Form
    {
        private const int DoubleClickStepSize = 99;
        private CaesarsCalendarPuzzle caesarsCalendarPuzzle;
        private Bitmap bitmap;
        List<List<Tuple<Piece, int, int>>> solutions;
        int? solutionIndex;
        private static readonly int blockSize = 83;
        private static readonly int solutionX = 10;
        private static readonly int solutionY = 10;

        public FormCaesarsCalendar()
        {
            InitializeComponent();
            caesarsCalendarPuzzle = new CaesarsCalendarPuzzle();
            bitmap = new Bitmap(blockSize * caesarsCalendarPuzzle.Width + solutionX, blockSize * caesarsCalendarPuzzle.Height + solutionY);

            buttonClear_Click(null, null);
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            var month = comboBoxMonth.SelectedIndex;
            var weekday = comboBoxWeekday.SelectedIndex;
            int day = (int)numericUpDownDay.Value;
            solutionIndex = null;
            solutions = caesarsCalendarPuzzle.Solve(month, day, weekday);
            if (solutions?.Count > 0)
                solutionIndex = 0;
            updateStatus();
        }

        void updateStatus()
        {
            if (solutions == null || !solutionIndex.HasValue)
            {
                pictureBoxPuzzle.Image = null;
                toolStripStatusLabel.Text = null;
                toolStripFirstButton.Enabled = false;
                toolStripPrevButton.Enabled = false;
                toolStripNextButton.Enabled = false;
                toolStripLastButton.Enabled = false;
                return;
            }
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(TransparencyKey);
                foreach (var p in solutions[solutionIndex.Value])
                {
                    p.Item1.Render(graphics, solutionX, solutionY, p.Item2, p.Item3, blockSize);
                }
            }
            pictureBoxPuzzle.Image = bitmap;
            var n = solutions.Count;
            toolStripStatusLabel.Text = $"{solutionIndex+1}/{n}";
            bool nf = solutionIndex > 0;
            bool nl = solutionIndex < n - 1;
            toolStripFirstButton.Enabled = nf;
            toolStripPrevButton.Enabled = nf;
            toolStripNextButton.Enabled = nl;
            toolStripLastButton.Enabled = nl;
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            var dt = DateTime.Now.Date;
            dateTimePicker.Value = dt;
            solutionIndex = null;
            solutions = null;
            updateStatus();
        }

        private void comboBoxWeekday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxWeekday.SelectedIndex != (int)dateTimePicker.Value.DayOfWeek)
                dateTimePicker.Value = DateTimePicker.MinimumDateTime;
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMonth.SelectedIndex != dateTimePicker.Value.Month - 1)
                dateTimePicker.Value = DateTimePicker.MinimumDateTime;
        }

        private void numericUpDownDay_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker.Value!=DateTimePicker.MinimumDateTime && numericUpDownDay.Value != dateTimePicker.Value.Day)
                dateTimePicker.Value = DateTimePicker.MinimumDateTime;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Value == DateTimePicker.MinimumDateTime)
            {
                dateTimePicker.ValueChanged -= dateTimePicker_ValueChanged;
                dateTimePicker.Value = DateTime.Now; // This is required in order to show current month/year when user reopens the date popup.
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = " ";
                dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            }
            else
            {
                dateTimePicker.Format = DateTimePickerFormat.Short;
                var dt = dateTimePicker.Value;
                comboBoxMonth.SelectedIndex = dt.Month - 1;
                comboBoxWeekday.SelectedIndex = (int)dt.DayOfWeek;
                numericUpDownDay.Value = dt.Day;
                this.pictureBoxPuzzle.Image = null;
                solutionIndex = null;
                solutions = null;
                updateStatus();
            }
        }

        private void comboBoxMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTimePicker.MinimumDateTime;
        }

        private void comboBoxWeekday_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTimePicker.MinimumDateTime;
        }

        private void toolStripPrevButton_Click(object sender, EventArgs e)
        {
            if (solutionIndex.HasValue &&  solutions != null&&solutionIndex.Value>0)
            {
                solutionIndex--;
                updateStatus();
            }
        }
        private void toolStripPrevButton_DoubleClick(object sender, EventArgs e)
        {
            if (solutionIndex.HasValue && solutions != null)
            {
                if (solutionIndex.Value >= DoubleClickStepSize)
                    solutionIndex -= DoubleClickStepSize;
                else
                    solutionIndex = 0;
                updateStatus();
            }
        }

        private void toolStripNextButton_Click(object sender, EventArgs e)
        {
            if (solutionIndex.HasValue&& solutions != null&&solutionIndex.Value<solutions.Count-1)
            {
                solutionIndex++;
                updateStatus();
            }
        }
        private void toolStripNextButton_DoubleClick(object sender, EventArgs e)
        {
            if (solutionIndex.HasValue&&solutions!=null)
            {
                var n = solutions.Count;
                if (solutionIndex.Value < n - DoubleClickStepSize)
                    solutionIndex += DoubleClickStepSize;
                else
                    solutionIndex = n - 1;
                updateStatus();
            }
        }

        private void toolStripFirstButton_Click(object sender, EventArgs e)
        {
            if (solutionIndex.HasValue && solutions != null)
            {
                solutionIndex=0;
                updateStatus();
            }
        }

        private void toolStripLastButton_Click(object sender, EventArgs e)
        {
            if (solutionIndex.HasValue&&solutions!=null)
            {
                solutionIndex = solutions.Count - 1;
                updateStatus();
            }
        }

        private void toolStripButton_Paint(object sender, PaintEventArgs e)
        {
            ToolStripDropDownButton toolStripButton = sender as ToolStripDropDownButton;

            if (toolStripButton != null)
            {
                ControlPaint.DrawBorder3D(e.Graphics, new Rectangle(0, 0, toolStripButton.Width, toolStripButton.Height), Border3DStyle.RaisedOuter);
            }
        }

    }
}
