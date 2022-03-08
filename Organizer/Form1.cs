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
        public static List <List <Meeting>> dates = new List <List<Meeting>>();
        
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
                    Convert.ToInt16(PlanHouseTxtBox.Text),
                    PlanNameTxtBox.Text, GoalTxtBox.Text
                    );
                // Переменная для проверки наличия даты в органайзере
                bool flag = false;
                // Добавление встречи в хранилище
                foreach (var day in dates)
                    if (day[0].getDate().ToString("d") == DateMskdTxtBox.Text.Substring(0,10))
                    {
                        for (int i = 0; i < day.Count(); ++i)
                        {
                            if(meet.getDate() < day[i].getDate())
                            {
                                Meeting temp = new Meeting();
                                for(int j = i; j < day.Count()-1; ++j)
                                {
                                    temp = day[j+1];
                                    day[j+1] = day[j];
                                }
                                if(i == day.Count() - 1)
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
                        if(!flag)
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
            organizerPanel.Controls.Clear();
            
            Label DateLbl = new Label();
            DateLbl.AutoSize = true;
            DateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DateLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            DateLbl.Location = new System.Drawing.Point(9, 9);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new System.Drawing.Size(0, 31);
            DateLbl.TabIndex = 0;
            DateLbl.Text = calendar.SelectionStart.ToString("d MMMM yyyy");
            organizerPanel.Controls.Add(DateLbl);

            MeetingPanel meet_panel;
            foreach (var day in dates)
                if (day[0].getDate().ToString("d") == calendar.SelectionStart.ToString("d"))
                    for (int i = 0; i < day.Count(); ++i)
                        meet_panel = new MeetingPanel(organizerPanel, day[i], this.organizerPanel.Controls.Count - 1);
        }
        
    }
}