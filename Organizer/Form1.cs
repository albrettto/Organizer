namespace Organizer
{
    
    public partial class Organizer : Form
    {
        public Organizer()
        {
            InitializeComponent();
            DateLbl.Text = calendar.TodayDate.ToString("d MMMM yyyy");
        }
        // ��������� ���
        public static List <List <Meeting>> dates = new List <List<Meeting>>();
        
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // �������� �� ������ �������
            if (DateMskdTxtBox.Text == "  .  .       :" ||
                PhoneMskdTxtBox.Text == "+7 (   )    -" ||
                PlanNameTxtBox.Text == "" ||
                PlanTownTxtBox.Text == "" ||
                PlanStreetTxtBox.Text == "" ||
                PlanHouseTxtBox.Text == "" ||
                GoalTxtBox.Text == "")
                MessageBox.Show("�� ����� �� ��� ������!\n��������� �� ��������� � ������� ����������� ����� ������������� :)");
            else
            {
                // �������� ������� ������ ������� (����� �������)
                Meeting meet = new Meeting(
                    Convert.ToDateTime(DateMskdTxtBox.Text),
                    PhoneMskdTxtBox.Text,
                    PlanTownTxtBox.Text,
                    PlanStreetTxtBox.Text,
                    Convert.ToInt16(PlanHouseTxtBox.Text),
                    PlanNameTxtBox.Text, GoalTxtBox.Text
                    );
                bool flag = false;
                // ���������� ������� � ���������
                foreach (var day in dates)
                    if (day[0].getDate().ToString("d") == DateMskdTxtBox.Text.Substring(0,10))
                    {
                        day.Add(meet);
                        flag = true;
                        break;
                    }
                if (!flag)
                {
                    List<Meeting> hours = new List<Meeting>();
                    hours.Add(meet);
                    dates.Add(hours);
                }

                MeetingPanel meet_panel = new MeetingPanel(organizerPanel, meet, this.organizerPanel.Controls.Count - 1);


                // ������� �����
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
            DateLbl.Text = calendar.SelectionStart.ToString("d MMMM yyyy");
        }
    }
}