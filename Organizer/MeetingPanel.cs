using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    internal class MeetingPanel
    {
        Panel panel = new Panel();
        Label label = new Label();
        TextBox textBox = new TextBox();
        Button delete_button = new Button();

        public MeetingPanel(Panel organizerPanel, Meeting meet, int k)
        {
            // 
            // panel
            // 
            panel.BackColor = System.Drawing.Color.FloralWhite;
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.Controls.Add(delete_button);
            panel.Controls.Add(textBox);
            panel.Controls.Add(label);
            panel.Location = new System.Drawing.Point(9, 59 + k * 150);
            panel.Name = "panel0";
            panel.Size = new System.Drawing.Size(718, 134);
            panel.TabIndex = 1;
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
            // 
            // textBox
            // 
            textBox.BackColor = System.Drawing.Color.FloralWhite;
            textBox.Enabled = false;
            textBox.HideSelection = false;
            textBox.Location = new System.Drawing.Point(70, 4);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.PlaceholderText = meet.getName() + "\n" + meet.getPhoneNumber() + "\n" + meet.getTown() + " " + meet.getStreet() + " " + meet.getHouse() + "\n" + meet.getPurpose_of_meeting();
            textBox.ReadOnly = true;
            textBox.Size = new System.Drawing.Size(643, 88);
            textBox.TabIndex = 4;
            textBox.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(3, 0);
            label.Name = "label0";
            label.Size = new System.Drawing.Size(61, 28);
            label.TabIndex = 0;
            label.Text = meet.getDate().ToString("HH:mm");

            delete_button.Click += new System.EventHandler(delete_button_Click);

            organizerPanel.Controls.Add(panel);
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            label.Dispose();
            textBox.Dispose();
            delete_button.Dispose();
            panel.Dispose();
        }

    }
}
