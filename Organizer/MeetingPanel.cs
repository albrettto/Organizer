using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    [Serializable]
    public class MeetingPanel
    {
        public Panel panel = new Panel();
        public Label label = new Label();
        public Label label_d = new Label();
        public TextBox textBox = new TextBox();
        public Button delete_button = new Button();
        public MeetingPanel() { }
        public MeetingPanel(Panel organizerPanel, Meeting meet, int k)
        {
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.Controls.Add(delete_button);
            panel.Controls.Add(textBox);
            panel.Controls.Add(label);
            panel.Controls.Add(label_d);
            panel.Location = new System.Drawing.Point(9, 59 + k * 150);
            panel.Name = "panel0";
            panel.Size = new System.Drawing.Size(718, 134);
            panel.TabIndex = 1;
            panel.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            panel.Dock = DockStyle.Top;
            // 
            // delete_button
            // 
            delete_button.BackColor = System.Drawing.Color.Salmon;
            delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            delete_button.ForeColor = System.Drawing.SystemColors.ControlText;
            delete_button.Location = new System.Drawing.Point(571, 98);
            delete_button.Name = "delete_button";
            delete_button.Size = new System.Drawing.Size(142, 29);
            delete_button.TabIndex = 6;
            delete_button.Text = "Удалить встречу";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Anchor = AnchorStyles.Right;
            // 
            // textBox
            // 
            textBox.BackColor = System.Drawing.Color.White;
            textBox.Enabled = false;
            textBox.HideSelection = false;
            textBox.Location = new System.Drawing.Point(70, 4);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.PlaceholderText = "Имя: " + meet.name + "\n" 
                + "Номер телефона: " +  meet.phone_number + "\n" 
                + "Адрес: " + meet.town + " " + meet.street + " " + meet.house + "\n" 
                + "Цель встречи: " + meet.purpose_of_meeting;
            textBox.ReadOnly = true;
            textBox.Size = new System.Drawing.Size(643, 88);
            textBox.TabIndex = 4;
            textBox.TabStop = false;
            textBox.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(3, 0);
            label.Name = "label0";
            label.Size = new System.Drawing.Size(61, 28);
            label.TabIndex = 0;
            label.Text = meet.date.ToString("HH:mm");
            // 
            // label_d
            // 
            label_d.AutoSize = true;
            label_d.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.GraphicsUnit.Point);
            label_d.Location = new System.Drawing.Point(3, 30);
            label_d.Name = "label0";
            label_d.Size = new System.Drawing.Size(61, 28);
            label_d.TabIndex = 0;
            label_d.Text = meet.date.ToString("d");

            delete_button.Click += new System.EventHandler(delete_button_Click);

            organizerPanel.Controls.Add(panel);
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            bool delete = false;
            foreach (var day in Organizer.dates)
            {
                for (int i = 0; i < day.Count; i++)
                    if (day[i].date.ToString("d.MM.yyyy HH:mm:ss") == (label_d.Text + " " + label.Text + ":00"))
                    {
                        day.RemoveAt(i);
                        delete = true;
                        if (day.Count == 0)
                            Organizer.dates.Remove(day);
                        break;
                    }
                if (delete)
                    break;
            }
            label.Dispose();
            label_d.Dispose();
            textBox.Dispose();
            delete_button.Dispose();
            panel.Dispose();
        }

    }
}
