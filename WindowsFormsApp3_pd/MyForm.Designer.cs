namespace WindowsFormsApp3_pd
{
    partial class MyForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Dates = new System.Windows.Forms.TabPage();
            this.btnCount = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.Counting = new System.Windows.Forms.TabPage();
            this.lblFirstStep = new System.Windows.Forms.Label();
            this.lblSecondStep = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lblMultTable = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TrackBar();
            this.tbSecond = new System.Windows.Forms.TrackBar();
            this.chbQuadr = new System.Windows.Forms.CheckBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Dates.SuspendLayout();
            this.Counting.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Dates);
            this.tabControl.Controls.Add(this.Counting);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(636, 498);
            this.tabControl.TabIndex = 0;
            // 
            // Dates
            // 
            this.Dates.Controls.Add(this.btnCount);
            this.Dates.Controls.Add(this.tbResult);
            this.Dates.Controls.Add(this.lblStart);
            this.Dates.Controls.Add(this.lblLeft);
            this.Dates.Controls.Add(this.lblEnd);
            this.Dates.Controls.Add(this.dtpStart);
            this.Dates.Controls.Add(this.dtpEnd);
            this.Dates.Location = new System.Drawing.Point(4, 25);
            this.Dates.Name = "Dates";
            this.Dates.Padding = new System.Windows.Forms.Padding(3);
            this.Dates.Size = new System.Drawing.Size(628, 469);
            this.Dates.TabIndex = 0;
            this.Dates.Text = "Работа с датами";
            this.Dates.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(262, 225);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(102, 23);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Рассчитать";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // tbResult
            // 
            this.tbResult.ForeColor = System.Drawing.Color.White;
            this.tbResult.Location = new System.Drawing.Point(164, 161);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(278, 22);
            this.tbResult.TabIndex = 2;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(81, 36);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(57, 16);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Начало";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(81, 161);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(58, 16);
            this.lblLeft.TabIndex = 1;
            this.lblLeft.Text = "Прошло";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(81, 96);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(47, 16);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "Конец";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(164, 36);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(164, 96);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 0;
            // 
            // Counting
            // 
            this.Counting.Controls.Add(this.lblFirstStep);
            this.Counting.Controls.Add(this.lblSecondStep);
            this.Counting.Controls.Add(this.gbResult);
            this.Counting.Controls.Add(this.lblMultTable);
            this.Counting.Controls.Add(this.tbFirst);
            this.Counting.Controls.Add(this.tbSecond);
            this.Counting.Controls.Add(this.chbQuadr);
            this.Counting.Location = new System.Drawing.Point(4, 25);
            this.Counting.Name = "Counting";
            this.Counting.Padding = new System.Windows.Forms.Padding(3);
            this.Counting.Size = new System.Drawing.Size(628, 469);
            this.Counting.TabIndex = 1;
            this.Counting.Text = "Работа с вычислениями";
            this.Counting.UseVisualStyleBackColor = true;
            // 
            // lblFirstStep
            // 
            this.lblFirstStep.AutoSize = true;
            this.lblFirstStep.Location = new System.Drawing.Point(442, 97);
            this.lblFirstStep.Name = "lblFirstStep";
            this.lblFirstStep.Size = new System.Drawing.Size(14, 16);
            this.lblFirstStep.TabIndex = 7;
            this.lblFirstStep.Text = "0";
            // 
            // lblSecondStep
            // 
            this.lblSecondStep.AutoSize = true;
            this.lblSecondStep.Location = new System.Drawing.Point(442, 181);
            this.lblSecondStep.Name = "lblSecondStep";
            this.lblSecondStep.Size = new System.Drawing.Size(14, 16);
            this.lblSecondStep.TabIndex = 7;
            this.lblSecondStep.Text = "0";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lblRes);
            this.gbResult.Location = new System.Drawing.Point(338, 338);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(249, 107);
            this.gbResult.TabIndex = 6;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Произведение";
            // 
            // lblMultTable
            // 
            this.lblMultTable.AutoSize = true;
            this.lblMultTable.Location = new System.Drawing.Point(211, 29);
            this.lblMultTable.Name = "lblMultTable";
            this.lblMultTable.Size = new System.Drawing.Size(129, 16);
            this.lblMultTable.TabIndex = 4;
            this.lblMultTable.Text = "Таблица подсчёта";
            // 
            // tbFirst
            // 
            this.tbFirst.LargeChange = 10;
            this.tbFirst.Location = new System.Drawing.Point(40, 78);
            this.tbFirst.Maximum = 100;
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(365, 56);
            this.tbFirst.TabIndex = 2;
            this.tbFirst.TickFrequency = 10;
            this.tbFirst.Scroll += new System.EventHandler(this.tbFirst_Scroll);
            // 
            // tbSecond
            // 
            this.tbSecond.LargeChange = 10;
            this.tbSecond.Location = new System.Drawing.Point(40, 162);
            this.tbSecond.Maximum = 100;
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(365, 56);
            this.tbSecond.TabIndex = 2;
            this.tbSecond.TickFrequency = 10;
            this.tbSecond.Scroll += new System.EventHandler(this.tbSecond_Scroll);
            // 
            // chbQuadr
            // 
            this.chbQuadr.AutoSize = true;
            this.chbQuadr.Location = new System.Drawing.Point(69, 397);
            this.chbQuadr.Name = "chbQuadr";
            this.chbQuadr.Size = new System.Drawing.Size(84, 20);
            this.chbQuadr.TabIndex = 0;
            this.chbQuadr.Text = "Квадрат";
            this.chbQuadr.UseVisualStyleBackColor = true;
            this.chbQuadr.Click += new System.EventHandler(this.chbQuadr_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(104, 48);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(14, 16);
            this.lblRes.TabIndex = 7;
            this.lblRes.Text = "0";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 498);
            this.Controls.Add(this.tabControl);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.tabControl.ResumeLayout(false);
            this.Dates.ResumeLayout(false);
            this.Dates.PerformLayout();
            this.Counting.ResumeLayout(false);
            this.Counting.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSecond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Dates;
        private System.Windows.Forms.TabPage Counting;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblMultTable;
        private System.Windows.Forms.TrackBar tbSecond;
        private System.Windows.Forms.CheckBox chbQuadr;
        private System.Windows.Forms.Label lblSecondStep;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label lblFirstStep;
        private System.Windows.Forms.TrackBar tbFirst;
        private System.Windows.Forms.Label lblRes;
    }
}

