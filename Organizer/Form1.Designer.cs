namespace Organizer
{
    partial class Organizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizer));
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.organizerPanel = new System.Windows.Forms.Panel();
            this.calendarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarPanel
            // 
            this.calendarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendarPanel.Controls.Add(this.calendar);
            this.calendarPanel.Location = new System.Drawing.Point(12, 12);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(269, 255);
            this.calendarPanel.TabIndex = 0;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(39, 25);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Location = new System.Drawing.Point(12, 273);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(269, 401);
            this.searchPanel.TabIndex = 1;
            // 
            // organizerPanel
            // 
            this.organizerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.organizerPanel.Location = new System.Drawing.Point(287, 12);
            this.organizerPanel.Name = "organizerPanel";
            this.organizerPanel.Size = new System.Drawing.Size(786, 662);
            this.organizerPanel.TabIndex = 2;
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 686);
            this.Controls.Add(this.organizerPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.calendarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Organizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Органайзер";
            this.calendarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel calendarPanel;
        private Panel searchPanel;
        private Panel organizerPanel;
        private MonthCalendar calendar;
    }
}