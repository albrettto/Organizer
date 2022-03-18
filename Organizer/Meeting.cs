using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
                                                                                          
    public class Meeting
    {
        public DateTime date;
        public string phone_number;
        public string name;
        public string purpose_of_meeting;
        public string town;
        public string street;
        public string house;
        public Meeting()
        {
            date = DateTime.Now;
            phone_number = "";
            town = "";
            street = "";
            house = "";
            name = "";
            purpose_of_meeting = "";
        }
        public Meeting(DateTime new_date, string new_phone_number,string new_town, string new_street, string new_house, string new_name, string new_purpose_of_meeting)
        {
            date = new_date;
            phone_number = new_phone_number;
            town = new_town;
            street = new_street;
            house = new_house;
            name = new_name;
            purpose_of_meeting = new_purpose_of_meeting;
        }
    }    
}