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
    }    
}