using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace Organizer
{
    public partial class Organizer : Form
    {
        public Organizer()
        {
            InitializeComponent();
            DateLbl.Text = calendar.TodayDate.ToString("d MMMM yyyy");
        }
        // Хранилище дат
        public static List<List<Meeting>> dates = new List<List<Meeting>>();

        XmlSerializer ser = new XmlSerializer(typeof(List<List<Meeting>>));
        string path = "Storage.xml";

        public static Colors color = new Colors("White", "Black", "DimGray", "WhiteSmoke", "White", "White");

        XmlSerializer s = new XmlSerializer(typeof(Colors));
        string p = "Colors.xml";


        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // Проверка на пустые строчки
            if (DateMskdTxtBox.Text == "  .  .       :" ||
                PhoneMskdTxtBox.Text == "+7 (   )    -" ||
                PlanNameTxtBox.Text == "" ||
                PlanTownTxtBox.Text == "" ||
                PlanStreetTxtBox.Text == "" ||
                PlanHouseTxtBox.Text == "" ||
                GoalTxtBox.Text == "")
                MessageBox.Show("Вы ввели не все данные!\nЗаполните их полностью и встреча обязательно будет запланирована :)");
            else
            {
                // Создание объекта класса Встречи (новой встречи)
                Meeting meet = new Meeting(
                    Convert.ToDateTime(DateMskdTxtBox.Text),
                    PhoneMskdTxtBox.Text,
                    PlanTownTxtBox.Text,
                    PlanStreetTxtBox.Text,
                    PlanHouseTxtBox.Text,
                    PlanNameTxtBox.Text, GoalTxtBox.Text
                    );
                // Переменная для проверки наличия даты в органайзере
                bool flag = false;
                // Добавление встречи в хранилище
                foreach (var day in dates)
                    if (day[0].date.ToString("d") == DateMskdTxtBox.Text.Substring(0, 10))
                    {
                        for (int i = 0; i < day.Count(); ++i)
                        {
                            if (meet.date < day[i].date)
                            {
                                Meeting temp = new Meeting();
                                for (int j = i; j < day.Count() - 1; ++j)
                                {
                                    temp = day[j + 1];
                                    day[j + 1] = day[j];
                                }
                                if (i == day.Count() - 1)
                                {
                                    day.Add(day[i]);
                                    day[i] = meet;
                                    flag = true;
                                    break;
                                }
                                else
                                {
                                    day.Add(temp);
                                    day[i] = meet;
                                    flag = true;
                                    break;
                                }
                            }
                        }
                        if (!flag)
                        {

                            day.Add(meet);
                            flag = true;
                            break;
                        }
                    }
                if (!flag)
                {
                    List<Meeting> hours = new List<Meeting>();
                    hours.Add(meet);
                    dates.Add(hours);
                }

                MeetingPanel meet_panel = new MeetingPanel(organizerPanel, meet, organizerPanel.Controls.Count - 1);

                calendar.SetDate(meet.date);

                // Очистка формы
                ClearBtn_Click(sender, e);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DateMskdTxtBox.Text = "  .  .       :";
            PhoneMskdTxtBox.Text = "+7 (   )    -";
            PlanNameTxtBox.Text = "";
            PlanTownTxtBox.Text = "";
            PlanStreetTxtBox.Text = "";
            PlanHouseTxtBox.Text = "";
            GoalTxtBox.Text = "";
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
           Update_Panel();
        }

        public void Update_Panel()
        {
            organizerPanel.Controls.Clear();
            DateLbl.Text = calendar.SelectionStart.ToString("d MMMM yyyy");

            MeetingPanel meet_panel;
            foreach (var day in dates)
                if (day[0].date.ToString("d") == calendar.SelectionStart.ToString("d"))
                    for (int i = day.Count()-1; i > -1; --i)
                        meet_panel = new MeetingPanel(organizerPanel, day[i], organizerPanel.Controls.Count - 1);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if(PhoneNumberMskdTxtBox.Text == "+7 (   )    -" && TownTxtBox.Text == "" &&  StreetTxtBox.Text == "" && HouseTxtBox.Text == "" && NameTxtBox.Text == "")
                MessageBox.Show("Вы не ввели ни одного условия для поиска встречи!\nНе надо так\nНадо заполнить хотя бы одно из условий поиска\nПостарайтесь что-нибудь вспомнить :)");
            else 
            {
                organizerPanel.Controls.Clear();
                DateLbl.Text = "Результаты поиска:";

                MeetingPanel meet_panel;
                foreach (var day in dates)
                    for (int i = 0; i < day.Count(); ++i)
                    {
                        int[] check_for_search = { 0, 0, 0, 0, 0 };

                        // Обозначения:
                        // 0 - текстовое поле не заполнено
                        // 1 - текстовое поле заполнено и совпадений нет (или еще не найдено)
                        // 2 - текстовое поле заполнено и найдено совпадение 

                        if (PhoneNumberMskdTxtBox.Text != "+7 (   )    -")
                        {
                            check_for_search[0] = 1;
                            if (day[i].phone_number == PhoneNumberMskdTxtBox.Text)
                                check_for_search[0] = 2;
                        }
                        if (TownTxtBox.Text != "")
                        {
                            check_for_search[1] = 1;
                            if (day[i].town == TownTxtBox.Text)
                                check_for_search[1] = 2;
                        }
                        if (StreetTxtBox.Text != "")
                        {
                            check_for_search[2] = 1;
                            if (day[i].street == StreetTxtBox.Text)
                                check_for_search[2] = 2;
                        }
                        if (HouseTxtBox.Text != "")
                        {
                            check_for_search[3] = 1;
                            if (day[i].house.ToString() == HouseTxtBox.Text)
                                check_for_search[3] = 2;
                        }
                        if (NameTxtBox.Text != "")
                        {
                            check_for_search[4] = 1;
                            if (day[i].name == NameTxtBox.Text)
                                check_for_search[4] = 2;
                        }
                        int flag = 0;
                        for (int j = 0; j < 5; j++)
                        {
                            if (check_for_search[j] == 1)
                            {
                                flag = 1;
                                break;
                            }
                            if (check_for_search[j] == 2)
                                flag = 2;
                        }
                        if (flag == 2)
                            meet_panel = new MeetingPanel(organizerPanel, day[i], organizerPanel.Controls.Count - 1);
                    }
            }
        }

        private void ClearSearchPanelBtn_Click(object sender, EventArgs e)
        {
            PhoneNumberMskdTxtBox.Text = "+7 (   )    -";
            TownTxtBox.Text = "";
            StreetTxtBox.Text = "";
            HouseTxtBox.Text = "";
            NameTxtBox.Text = "";
        }

        private void Organizer_Load(object sender, EventArgs e)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
            if (file.Length > 0)
            {
                dates = (List<List<Meeting>>)ser.Deserialize(file);
                Update_Panel();
            }
            file.Close();

            FileStream f = new FileStream(p, FileMode.Open, FileAccess.Read, FileShare.None);
            if (f.Length > 0)
            {
                color = (Colors)s.Deserialize(f);
                Update_Colors(color);
            }
            else
            {
                WhiteTheme_Click(sender, e);
                Update_Colors(color);
            }
            f.Close();
        }

        private void Organizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<List<Meeting>>));
            string path = "Storage.xml";
            FileStream files = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            ser.Serialize(files, dates);
            files.Close();

            XmlSerializer s = new XmlSerializer(typeof(Colors));
            string p = "Colors.xml";
            FileStream f = new FileStream(p, FileMode.Create, FileAccess.Write, FileShare.None);
            s.Serialize(f, color);
            f.Close();
        }

        void Update_Colors(Colors color)
        {
            calendarPanel.BackColor = ColorTranslator.FromHtml(color.background_color);
            calendar.ForeColor = ColorTranslator.FromHtml(color.font_color);
            searchPanel.BackColor = ColorTranslator.FromHtml(color.background_color);

            ClearSearchPanelBtn.BackColor = ColorTranslator.FromHtml(color.clearbtn_color);
            ClearSearchPanelBtn.ForeColor = ColorTranslator.FromHtml(color.txtbox_color);

            SearchBtn.BackColor = ColorTranslator.FromHtml(color.txtbox_color);
            SearchLbl.ForeColor = ColorTranslator.FromHtml(color.font_color);
            PlanMeetingPanel.BackColor = ColorTranslator.FromHtml(color.planpanel_color);

            ClearBtn.BackColor = ColorTranslator.FromHtml(color.clearbtn_color);
            ClearBtn.ForeColor = ColorTranslator.FromHtml(color.txtbox_color);

            CreateBtn.BackColor = ColorTranslator.FromHtml(color.createbtn_color);
            GoalTxtBox.BackColor = ColorTranslator.FromHtml(color.txtbox_color);
            PlanHouseTxtBox.BackColor = ColorTranslator.FromHtml(color.txtbox_color);
            PlanStreetTxtBox.BackColor = ColorTranslator.FromHtml(color.txtbox_color);
            PlanTownTxtBox.BackColor = ColorTranslator.FromHtml(color.txtbox_color);
            PhoneMskdTxtBox.BackColor = ColorTranslator.FromHtml(color.txtbox_color);
            PlanNameTxtBox.BackColor = ColorTranslator.FromHtml(color.txtbox_color);
            MeetingLbl.ForeColor = ColorTranslator.FromHtml(color.font_color);
            DateMskdTxtBox.BackColor = ColorTranslator.FromHtml(color.txtbox_color);
            organizerPanel.BackColor = ColorTranslator.FromHtml(color.background_color);
            DateLbl.ForeColor = ColorTranslator.FromHtml(color.font_color);
            topPanel.BackColor = ColorTranslator.FromHtml(color.background_color);
        }

        private void WhiteTheme_Click(object sender, EventArgs e)
        {
            color.background_color = ("White");
            color.font_color = ("Black");
            color.clearbtn_color = ("DimGray");
            color.planpanel_color = ("WhiteSmoke");
            color.txtbox_color = ("White");
            color.createbtn_color = ("White");
            Update_Colors(color);
        }

        private void StandartTheme_Click(object sender, EventArgs e)
        {
            color.background_color = ("OldLace");
            color.font_color = ("SaddleBrown");
            color.clearbtn_color = ("DimGray");
            color.planpanel_color = ("NavajoWhite");
            color.txtbox_color = ("Linen");
            color.createbtn_color = ("SandyBrown");
            Update_Colors(color);
        }

        private void MonochromeTheme_Click(object sender, EventArgs e)
        {
            color.background_color = ("#F4F6F4");
            color.font_color = ("#342E36");
            color.clearbtn_color = ("#817581");
            color.planpanel_color = ("#8D7F87");
            color.txtbox_color = ("#F4F6F4");
            color.createbtn_color = ("#918590");
            Update_Colors(color);
        }

        private void EcologicalTheme_Click(object sender, EventArgs e)
        {
            color.background_color = ("#F4ECD1");
            color.font_color = ("#0B1B29");
            color.clearbtn_color = ("#1C4751");
            color.planpanel_color = ("#CAD0B1");
            color.txtbox_color = color.background_color;
            color.createbtn_color = ("#6B9076");
            Update_Colors(color);
        }

        private void Check_Is_Digit(object sender, KeyPressEventArgs e)
        {
            if (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void Check_House(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 47)
            {
                e.Handled = true;
            }
        }

        private void ShowAllMeetings_Click(object sender, EventArgs e)
        {
            organizerPanel.Controls.Clear();
            DateLbl.Text = "Все встречи";

            MeetingPanel meet_panel;
            foreach (var day in dates)
                    for (int i = day.Count() - 1; i > -1; --i)
                        meet_panel = new MeetingPanel(organizerPanel, day[i], organizerPanel.Controls.Count - 1);
        }
    }
}