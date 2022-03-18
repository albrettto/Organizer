using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    [Serializable]
    public class Colors
    {
        public string background_color;
        public string font_color;
        public string clearbtn_color;
        public string planpanel_color;
        public string txtbox_color;
        public string createbtn_color;

        public Colors()
        {
            background_color = "White";
            font_color = "Black";
            clearbtn_color = "White";
            planpanel_color = "White";
            txtbox_color = "White";
            createbtn_color = "White";
        }
        public Colors(string new_background_color, string new_font_color, string new_clearbtn_color, string new_planpanel_color, string new_txtbox_color, string new_createbtn_color)
        {
            background_color = new_background_color;
            font_color = new_font_color;
            clearbtn_color = new_clearbtn_color;
            planpanel_color = new_planpanel_color;
            txtbox_color = new_txtbox_color;
            createbtn_color = new_createbtn_color;
        }
    }
}
