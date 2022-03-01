using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    public class Meeting
    {
        private DateTime date;
        private string phone_number;
        private string name;
        private string purpose_of_meeting;
        private string town;
        private string street;
        private int house;
        public Meeting()
        {
            date = DateTime.Now;
            phone_number = "";
            town = "";
            street = " ";
            house = 0;
            name = "";
            purpose_of_meeting = "";
        }
        public Meeting(DateTime new_date, string new_phone_number,string new_town, string new_street, int new_house, string new_name, string new_purpose_of_meeting)
        {
            date = new_date;
            phone_number = new_phone_number;
            town = new_town;
            street = new_street;
            house = new_house;
            name = new_name;
            purpose_of_meeting = new_purpose_of_meeting;
        }
        public DateTime getDate()
        {
            return date;
        }
        public void setDate(DateTime new_date)
        {
            date = new_date;
        }
        public string getPhoneNumber()
        {
            return phone_number;
        }
        public void setPhoneNumber(string new_phone_number)
        {
            phone_number = new_phone_number;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string new_name)
        {
            name = new_name;
        }
        public string getPurpose_of_meeting()
        { 
            return purpose_of_meeting;
        }
        public void setPurpose_of_meeting(string new_purpose_of_meeting)
        {
            purpose_of_meeting = new_purpose_of_meeting;
        }
        public string getTown()
        {
            return town;
        }
        public void setTown(string new_town)
        {
            town = new_town;
        }
        public string getStreet()
        {
            return street;
        }
        public void setStreet(string new_street)
        {
            street = new_street;
        }
        public int getHouse()
        {
            return house;
        }
        public void setHouse(int new_house)
        {
            house = new_house;
        }
        //public void create_panel(object sender, EventArgs e, Panel organizerPanel, Meeting meet, int k)
        //{
        //    Panel panel = new Panel();
        //    Label label = new Label();
        //    TextBox textBox = new TextBox();
        //    Button delete_button = new Button();


        //    //panel


        //    panel.BackColor = System.Drawing.Color.FloralWhite;
        //    panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //    panel.Controls.Add(delete_button);
        //    panel.Controls.Add(textBox);
        //    panel.Controls.Add(label);
        //    panel.Location = new System.Drawing.Point(9, 59 + k * 150);
        //    panel.Name = "panel0";
        //    panel.Size = new System.Drawing.Size(718, 134);
        //    panel.TabIndex = 1;

        //    //delete_button


        //    delete_button.BackColor = System.Drawing.Color.Salmon;
        //    delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    delete_button.ForeColor = System.Drawing.SystemColors.ControlText;
        //    delete_button.Location = new System.Drawing.Point(571, 98);
        //    delete_button.Name = "delete_button";
        //    delete_button.Size = new System.Drawing.Size(142, 29);
        //    delete_button.TabIndex = 6;
        //    delete_button.Text = "Удалить встречу";
        //    delete_button.UseVisualStyleBackColor = false;

        //    //edit_button


        //    //edit_button.BackColor = System.Drawing.Color.SandyBrown;
        //    //edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    //edit_button.ForeColor = System.Drawing.SystemColors.ControlText;
        //    //edit_button.Location = new System.Drawing.Point(423, 98);
        //    //edit_button.Name = "edit_button";
        //    //edit_button.Size = new System.Drawing.Size(142, 29);
        //    //edit_button.TabIndex = 5;
        //    //edit_button.Text = "Создать встречу";
        //    //edit_button.UseVisualStyleBackColor = false;

        //    //textBox


        //    textBox.BackColor = System.Drawing.Color.FloralWhite;
        //    textBox.Enabled = false;
        //    textBox.HideSelection = false;
        //    textBox.Location = new System.Drawing.Point(70, 4);
        //    textBox.Multiline = true;
        //    textBox.Name = "textBox";
        //    textBox.PlaceholderText = meet.name + "\n" + meet.phone_number + "\n" + meet.town + " " + meet.street + " " + meet.house + "\n" + meet.purpose_of_meeting;
        //    textBox.ReadOnly = true;
        //    textBox.Size = new System.Drawing.Size(643, 88);
        //    textBox.TabIndex = 4;
        //    textBox.TabStop = false;

        //    //label


        //    label.AutoSize = true;
        //    label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    label.Location = new System.Drawing.Point(3, 0);
        //    label.Name = "label0";
        //    label.Size = new System.Drawing.Size(61, 28);
        //    label.TabIndex = 0;
        //    label.Text = meet.date.ToString("HH:mm");

        //    organizerPanel.Controls.Add(panel);
        //}
    }
    
}
