using System.Xml.Serialization;

using System.Text.Json;

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


        // Цвета
        //Color background_color = Color.OldLace;
        //Color font_color = Color.SaddleBrown;
        //Color clearbtn_color = Color.DimGray;
        //Color planpanel_color = Color.NavajoWhite;
        //Color txtbox_color = Color.Linen;
        //Color deletebtn_color = Color.Salmon;
        //Color createbtn_color = Color.SandyBrown;

        Color background_color = System.Drawing.ColorTranslator.FromHtml("#AFAAC8");
        Color font_color = System.Drawing.ColorTranslator.FromHtml("#27223D");
        Color planpanel_color = System.Drawing.ColorTranslator.FromHtml("#7768BD");
        Color txtbox_color = System.Drawing.ColorTranslator.FromHtml("#AFAAC8");
        Color createbtn_color = System.Drawing.ColorTranslator.FromHtml("#574C8A");
        Color deletebtn_color = System.Drawing.ColorTranslator.FromHtml("#27223D");
        Color clearbtn_color = System.Drawing.ColorTranslator.FromHtml("#27223D");


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
                    if (day[0].getDate().ToString("d") == DateMskdTxtBox.Text.Substring(0, 10))
                    {
                        for (int i = 0; i < day.Count(); ++i)
                        {
                            if (meet.getDate() < day[i].getDate())
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

                MeetingPanel meet_panel = new MeetingPanel(organizerPanel, meet, this.organizerPanel.Controls.Count - 1);

                calendar.SetDate(meet.getDate());

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
            create_label(calendar.SelectionStart.ToString("d MMMM yyyy"));

            MeetingPanel meet_panel;
            foreach (var day in dates)
                if (day[0].getDate().ToString("d") == calendar.SelectionStart.ToString("d"))
                    //for (int i = 0; i < day.Count(); ++i)
                    //    meet_panel = new MeetingPanel(organizerPanel, day[i], this.organizerPanel.Controls.Count - 1);
                    for (int i = day.Count()-1; i > -1; --i)
                        meet_panel = new MeetingPanel(organizerPanel, day[i], this.organizerPanel.Controls.Count - 1);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if(PhoneNumberMskdTxtBox.Text == "+7 (   )    -" && TownTxtBox.Text == "" &&  StreetTxtBox.Text == "" && HouseTxtBox.Text == "" && NameTxtBox.Text == "")
                MessageBox.Show("Вы не ввели ни одного условия для поиска встречи!\nНе надо так\nНадо заполнить хотя бы одно из условий поиска\nПостарайтесь что-нибудь вспомнить :)");
            else 
            {
                organizerPanel.Controls.Clear();
                create_label("Результаты поиска:");

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
                            if (day[i].getPhoneNumber() == PhoneNumberMskdTxtBox.Text)
                                check_for_search[0] = 2;
                        }
                        if (TownTxtBox.Text != "")
                        {
                            check_for_search[1] = 1;
                            if (day[i].getTown() == TownTxtBox.Text)
                                check_for_search[1] = 2;
                        }
                        if (StreetTxtBox.Text != "")
                        {
                            check_for_search[2] = 1;
                            if (day[i].getStreet() == StreetTxtBox.Text)
                                check_for_search[2] = 2;
                        }
                        if (HouseTxtBox.Text != "")
                        {
                            check_for_search[3] = 1;
                            if (day[i].getHouse().ToString() == HouseTxtBox.Text)
                                check_for_search[3] = 2;
                        }
                        if (NameTxtBox.Text != "")
                        {
                            check_for_search[4] = 1;
                            if (day[i].getName() == NameTxtBox.Text)
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
                            meet_panel = new MeetingPanel(organizerPanel, day[i], this.organizerPanel.Controls.Count - 1);
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

        private void create_label(string text)
        {
            Label DateLbl = new Label();
            DateLbl.AutoSize = true;
            DateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DateLbl.ForeColor = font_color;
            DateLbl.Location = new System.Drawing.Point(9, 9);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new System.Drawing.Size(0, 31);
            DateLbl.TabIndex = 0;
            DateLbl.Text = text;
            organizerPanel.Controls.Add(DateLbl);
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
        }

        private void Organizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<List<Meeting>>));
            string path = "Storage.xml";
            FileStream files = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            ser.Serialize(files, dates);
            files.Close();
        }
    }
}