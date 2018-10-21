namespace EXE_Controler
{
    partial class FinalTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalTask));
            this.ProgramBox = new MetroFramework.Controls.MetroComboBox();
            this.ADD_PROGRAM = new MetroFramework.Controls.MetroButton();
            this.GO_PROGRAM = new MetroFramework.Controls.MetroButton();
            this.DELETE_PROGRAM = new MetroFramework.Controls.MetroButton();
            this.ADD_PR = new MetroFramework.Controls.MetroPanel();
            this.Road_PR = new MetroFramework.Controls.MetroTextBox();
            this.Name_PR = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CANCEL = new MetroFramework.Controls.MetroButton();
            this.OK = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ShutDownBut = new MetroFramework.Controls.MetroButton();
            this.HourOff = new MetroFramework.Controls.MetroTextBox();
            this.MinOff = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Min_up = new MetroFramework.Controls.MetroTextBox();
            this.Hour_up = new MetroFramework.Controls.MetroTextBox();
            this.W_UP = new MetroFramework.Controls.MetroButton();
            this.Info = new MetroFramework.Controls.MetroButton();
            this.ADD_PR.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgramBox
            // 
            this.ProgramBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProgramBox.FormattingEnabled = true;
            this.ProgramBox.ItemHeight = 23;
            this.ProgramBox.Location = new System.Drawing.Point(23, 88);
            this.ProgramBox.MaxDropDownItems = 15;
            this.ProgramBox.Name = "ProgramBox";
            this.ProgramBox.Size = new System.Drawing.Size(206, 29);
            this.ProgramBox.TabIndex = 0;
            this.ProgramBox.SelectedIndexChanged += new System.EventHandler(this.ProgramBox_SelectedIndexChanged);
            // 
            // ADD_PROGRAM
            // 
            this.ADD_PROGRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ADD_PROGRAM.AutoSize = true;
            this.ADD_PROGRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_PROGRAM.Location = new System.Drawing.Point(257, 88);
            this.ADD_PROGRAM.Name = "ADD_PROGRAM";
            this.ADD_PROGRAM.Size = new System.Drawing.Size(55, 28);
            this.ADD_PROGRAM.TabIndex = 1;
            this.ADD_PROGRAM.Text = "ADD";
            this.ADD_PROGRAM.Click += new System.EventHandler(this.ADD_PROGRAM_Click);
            // 
            // GO_PROGRAM
            // 
            this.GO_PROGRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GO_PROGRAM.AutoSize = true;
            this.GO_PROGRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GO_PROGRAM.Location = new System.Drawing.Point(424, 88);
            this.GO_PROGRAM.Name = "GO_PROGRAM";
            this.GO_PROGRAM.Size = new System.Drawing.Size(61, 28);
            this.GO_PROGRAM.TabIndex = 2;
            this.GO_PROGRAM.Text = "GO";
            this.GO_PROGRAM.Click += new System.EventHandler(this.GO_PROGRAM_Click);
            // 
            // DELETE_PROGRAM
            // 
            this.DELETE_PROGRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DELETE_PROGRAM.AutoSize = true;
            this.DELETE_PROGRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETE_PROGRAM.Location = new System.Drawing.Point(331, 88);
            this.DELETE_PROGRAM.Name = "DELETE_PROGRAM";
            this.DELETE_PROGRAM.Size = new System.Drawing.Size(68, 28);
            this.DELETE_PROGRAM.TabIndex = 4;
            this.DELETE_PROGRAM.Text = "DELETE";
            this.DELETE_PROGRAM.Click += new System.EventHandler(this.DELETE_PROGRAM_Click);
            // 
            // ADD_PR
            // 
            this.ADD_PR.BackColor = System.Drawing.Color.Black;
            this.ADD_PR.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ADD_PR.Controls.Add(this.Road_PR);
            this.ADD_PR.Controls.Add(this.Name_PR);
            this.ADD_PR.Controls.Add(this.metroLabel2);
            this.ADD_PR.Controls.Add(this.CANCEL);
            this.ADD_PR.Controls.Add(this.OK);
            this.ADD_PR.Controls.Add(this.metroLabel1);
            this.ADD_PR.HorizontalScrollbarBarColor = true;
            this.ADD_PR.HorizontalScrollbarHighlightOnWheel = false;
            this.ADD_PR.HorizontalScrollbarSize = 10;
            this.ADD_PR.Location = new System.Drawing.Point(156, 37);
            this.ADD_PR.Name = "ADD_PR";
            this.ADD_PR.Size = new System.Drawing.Size(336, 189);
            this.ADD_PR.Style = MetroFramework.MetroColorStyle.Orange;
            this.ADD_PR.TabIndex = 5;
            this.ADD_PR.VerticalScrollbarBarColor = true;
            this.ADD_PR.VerticalScrollbarHighlightOnWheel = false;
            this.ADD_PR.VerticalScrollbarSize = 10;
            // 
            // Road_PR
            // 
            this.Road_PR.Location = new System.Drawing.Point(146, 82);
            this.Road_PR.Name = "Road_PR";
            this.Road_PR.Size = new System.Drawing.Size(178, 16);
            this.Road_PR.TabIndex = 7;
            // 
            // Name_PR
            // 
            this.Name_PR.BackColor = System.Drawing.Color.Black;
            this.Name_PR.Location = new System.Drawing.Point(146, 39);
            this.Name_PR.Name = "Name_PR";
            this.Name_PR.Size = new System.Drawing.Size(178, 16);
            this.Name_PR.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "ROAD TO PROGRAM:";
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(256, 148);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(68, 23);
            this.CANCEL.TabIndex = 3;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(191, 148);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(53, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "NAME PROGRAM:";
            // 
            // ShutDownBut
            // 
            this.ShutDownBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShutDownBut.Location = new System.Drawing.Point(23, 171);
            this.ShutDownBut.Name = "ShutDownBut";
            this.ShutDownBut.Size = new System.Drawing.Size(205, 28);
            this.ShutDownBut.TabIndex = 6;
            this.ShutDownBut.Text = "SHUT DOWN YOUR PC AFTER";
            this.ShutDownBut.Click += new System.EventHandler(this.ShutDownBut_Click);
            // 
            // HourOff
            // 
            this.HourOff.Location = new System.Drawing.Point(257, 171);
            this.HourOff.Name = "HourOff";
            this.HourOff.Size = new System.Drawing.Size(55, 28);
            this.HourOff.TabIndex = 7;
            this.HourOff.Text = "0";
            this.HourOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HourOff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HourOff_KeyPress);
            // 
            // MinOff
            // 
            this.MinOff.Location = new System.Drawing.Point(401, 171);
            this.MinOff.Name = "MinOff";
            this.MinOff.Size = new System.Drawing.Size(44, 28);
            this.MinOff.TabIndex = 8;
            this.MinOff.Text = "0";
            this.MinOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinOff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinOff_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(325, 171);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(0, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 28);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "HOURS";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(451, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 28);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "MIN";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(451, 254);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(34, 28);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "MIN";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(325, 254);
            this.metroLabel6.MinimumSize = new System.Drawing.Size(0, 28);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 28);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "HOURS";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min_up
            // 
            this.Min_up.Location = new System.Drawing.Point(401, 254);
            this.Min_up.Name = "Min_up";
            this.Min_up.Size = new System.Drawing.Size(44, 28);
            this.Min_up.TabIndex = 13;
            this.Min_up.Text = "0";
            this.Min_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min_up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Min_up_KeyPress);
            // 
            // Hour_up
            // 
            this.Hour_up.Location = new System.Drawing.Point(257, 254);
            this.Hour_up.Name = "Hour_up";
            this.Hour_up.Size = new System.Drawing.Size(55, 28);
            this.Hour_up.TabIndex = 12;
            this.Hour_up.Text = "0";
            this.Hour_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hour_up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hour_up_KeyPress);
            // 
            // W_UP
            // 
            this.W_UP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.W_UP.Location = new System.Drawing.Point(23, 254);
            this.W_UP.Name = "W_UP";
            this.W_UP.Size = new System.Drawing.Size(205, 28);
            this.W_UP.TabIndex = 11;
            this.W_UP.Text = "WAKE UP";
            this.W_UP.Click += new System.EventHandler(this.W_UP_Click);
            // 
            // Info
            // 
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.Location = new System.Drawing.Point(457, 357);
            this.Info.Margin = new System.Windows.Forms.Padding(2);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(35, 32);
            this.Info.TabIndex = 16;
            this.Info.Text = "Info";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // FinalTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(508, 412);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ADD_PR);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.Min_up);
            this.Controls.Add(this.Hour_up);
            this.Controls.Add(this.W_UP);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.MinOff);
            this.Controls.Add(this.HourOff);
            this.Controls.Add(this.ShutDownBut);
            this.Controls.Add(this.DELETE_PROGRAM);
            this.Controls.Add(this.GO_PROGRAM);
            this.Controls.Add(this.ADD_PROGRAM);
            this.Controls.Add(this.ProgramBox);
            this.DoubleBuffered = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(521, 450);
            this.Name = "FinalTask";
            this.Resizable = false;
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "EXE CONTROLER";
            this.ADD_PR.ResumeLayout(false);
            this.ADD_PR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ProgramBox;
        private MetroFramework.Controls.MetroButton ADD_PROGRAM;
        private MetroFramework.Controls.MetroButton GO_PROGRAM;
        private MetroFramework.Controls.MetroButton DELETE_PROGRAM;
        private MetroFramework.Controls.MetroPanel ADD_PR;
        private MetroFramework.Controls.MetroButton CANCEL;
        private MetroFramework.Controls.MetroButton OK;
        private MetroFramework.Controls.MetroTextBox Road_PR;
        private MetroFramework.Controls.MetroTextBox Name_PR;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton ShutDownBut;
        private MetroFramework.Controls.MetroTextBox HourOff;
        private MetroFramework.Controls.MetroTextBox MinOff;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox Min_up;
        private MetroFramework.Controls.MetroTextBox Hour_up;
        private MetroFramework.Controls.MetroButton W_UP;
        private MetroFramework.Controls.MetroButton Info;
    }
}

