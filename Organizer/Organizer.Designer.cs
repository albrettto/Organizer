namespace Organizer
{
    partial class Organizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizer));
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.ClearSearchPanelBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.HouseTxtBox = new System.Windows.Forms.TextBox();
            this.StreetTxtBox = new System.Windows.Forms.TextBox();
            this.TownTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberMskdTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.PhoneNumberLbl = new System.Windows.Forms.Label();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.PlanMeetingPanel = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.GoalTxtBox = new System.Windows.Forms.TextBox();
            this.PlanHouseTxtBox = new System.Windows.Forms.TextBox();
            this.PlanStreetTxtBox = new System.Windows.Forms.TextBox();
            this.PlanTownTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneMskdTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.PlanNameTxtBox = new System.Windows.Forms.TextBox();
            this.GoalLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MeetingLbl = new System.Windows.Forms.Label();
            this.DateMskdTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.organizerPanel = new System.Windows.Forms.Panel();
            this.DateLbl = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ChangeTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.WhiteTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.StandartTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.MonochromeTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.EcologicalTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllMeetings = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.PlanMeetingPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarPanel
            // 
            this.calendarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendarPanel.Controls.Add(this.calendar);
            this.calendarPanel.Location = new System.Drawing.Point(12, 27);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(269, 240);
            this.calendarPanel.TabIndex = 0;
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.SystemColors.Window;
            this.calendar.Location = new System.Drawing.Point(39, 25);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.ClearSearchPanelBtn);
            this.searchPanel.Controls.Add(this.SearchBtn);
            this.searchPanel.Controls.Add(this.NameTxtBox);
            this.searchPanel.Controls.Add(this.HouseTxtBox);
            this.searchPanel.Controls.Add(this.StreetTxtBox);
            this.searchPanel.Controls.Add(this.TownTxtBox);
            this.searchPanel.Controls.Add(this.PhoneNumberMskdTxtBox);
            this.searchPanel.Controls.Add(this.NameLbl);
            this.searchPanel.Controls.Add(this.AddressLbl);
            this.searchPanel.Controls.Add(this.PhoneNumberLbl);
            this.searchPanel.Controls.Add(this.SearchLbl);
            this.searchPanel.Location = new System.Drawing.Point(12, 273);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(269, 401);
            this.searchPanel.TabIndex = 1;
            // 
            // ClearSearchPanelBtn
            // 
            this.ClearSearchPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSearchPanelBtn.Location = new System.Drawing.Point(148, 334);
            this.ClearSearchPanelBtn.Name = "ClearSearchPanelBtn";
            this.ClearSearchPanelBtn.Size = new System.Drawing.Size(94, 31);
            this.ClearSearchPanelBtn.TabIndex = 7;
            this.ClearSearchPanelBtn.Text = "Очистить";
            this.ClearSearchPanelBtn.UseVisualStyleBackColor = false;
            this.ClearSearchPanelBtn.Click += new System.EventHandler(this.ClearSearchPanelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(25, 334);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 31);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NameTxtBox.Location = new System.Drawing.Point(3, 277);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.PlaceholderText = "С кем запланированна встреча";
            this.NameTxtBox.Size = new System.Drawing.Size(259, 27);
            this.NameTxtBox.TabIndex = 6;
            this.NameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Is_Digit);
            // 
            // HouseTxtBox
            // 
            this.HouseTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.HouseTxtBox.Location = new System.Drawing.Point(5, 208);
            this.HouseTxtBox.Name = "HouseTxtBox";
            this.HouseTxtBox.PlaceholderText = "№ дома";
            this.HouseTxtBox.Size = new System.Drawing.Size(259, 27);
            this.HouseTxtBox.TabIndex = 5;
            this.HouseTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_House);
            // 
            // StreetTxtBox
            // 
            this.StreetTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.StreetTxtBox.Location = new System.Drawing.Point(5, 175);
            this.StreetTxtBox.Name = "StreetTxtBox";
            this.StreetTxtBox.PlaceholderText = "Улица";
            this.StreetTxtBox.Size = new System.Drawing.Size(259, 27);
            this.StreetTxtBox.TabIndex = 4;
            this.StreetTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Is_Digit);
            // 
            // TownTxtBox
            // 
            this.TownTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TownTxtBox.Location = new System.Drawing.Point(5, 142);
            this.TownTxtBox.Name = "TownTxtBox";
            this.TownTxtBox.PlaceholderText = "Город";
            this.TownTxtBox.Size = new System.Drawing.Size(259, 27);
            this.TownTxtBox.TabIndex = 0;
            this.TownTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Is_Digit);
            // 
            // PhoneNumberMskdTxtBox
            // 
            this.PhoneNumberMskdTxtBox.Location = new System.Drawing.Point(3, 76);
            this.PhoneNumberMskdTxtBox.Mask = "+7 (999) 000-0000";
            this.PhoneNumberMskdTxtBox.Name = "PhoneNumberMskdTxtBox";
            this.PhoneNumberMskdTxtBox.Size = new System.Drawing.Size(261, 27);
            this.PhoneNumberMskdTxtBox.TabIndex = 0;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.Location = new System.Drawing.Point(3, 251);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 23);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Имя";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLbl.Location = new System.Drawing.Point(3, 116);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(127, 23);
            this.AddressLbl.TabIndex = 1;
            this.AddressLbl.Text = "Адрес встречи";
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.AutoSize = true;
            this.PhoneNumberLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLbl.Location = new System.Drawing.Point(3, 50);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(146, 23);
            this.PhoneNumberLbl.TabIndex = 0;
            this.PhoneNumberLbl.Text = "Номер телефона";
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchLbl.Location = new System.Drawing.Point(81, 0);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(94, 31);
            this.SearchLbl.TabIndex = 0;
            this.SearchLbl.Text = "ПОИСК";
            // 
            // PlanMeetingPanel
            // 
            this.PlanMeetingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlanMeetingPanel.BackColor = System.Drawing.Color.White;
            this.PlanMeetingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlanMeetingPanel.Controls.Add(this.ClearBtn);
            this.PlanMeetingPanel.Controls.Add(this.CreateBtn);
            this.PlanMeetingPanel.Controls.Add(this.GoalTxtBox);
            this.PlanMeetingPanel.Controls.Add(this.PlanHouseTxtBox);
            this.PlanMeetingPanel.Controls.Add(this.PlanStreetTxtBox);
            this.PlanMeetingPanel.Controls.Add(this.PlanTownTxtBox);
            this.PlanMeetingPanel.Controls.Add(this.PhoneMskdTxtBox);
            this.PlanMeetingPanel.Controls.Add(this.PlanNameTxtBox);
            this.PlanMeetingPanel.Controls.Add(this.GoalLbl);
            this.PlanMeetingPanel.Controls.Add(this.PhoneLbl);
            this.PlanMeetingPanel.Controls.Add(this.label1);
            this.PlanMeetingPanel.Controls.Add(this.label2);
            this.PlanMeetingPanel.Controls.Add(this.label3);
            this.PlanMeetingPanel.Controls.Add(this.MeetingLbl);
            this.PlanMeetingPanel.Controls.Add(this.DateMskdTxtBox);
            this.PlanMeetingPanel.Location = new System.Drawing.Point(1079, 27);
            this.PlanMeetingPanel.Name = "PlanMeetingPanel";
            this.PlanMeetingPanel.Size = new System.Drawing.Size(447, 647);
            this.PlanMeetingPanel.TabIndex = 3;
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Location = new System.Drawing.Point(167, 595);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(142, 29);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateBtn.Location = new System.Drawing.Point(167, 560);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(142, 29);
            this.CreateBtn.TabIndex = 13;
            this.CreateBtn.Text = "Создать встречу";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // GoalTxtBox
            // 
            this.GoalTxtBox.Location = new System.Drawing.Point(188, 289);
            this.GoalTxtBox.Multiline = true;
            this.GoalTxtBox.Name = "GoalTxtBox";
            this.GoalTxtBox.Size = new System.Drawing.Size(254, 246);
            this.GoalTxtBox.TabIndex = 12;
            // 
            // PlanHouseTxtBox
            // 
            this.PlanHouseTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PlanHouseTxtBox.Location = new System.Drawing.Point(188, 243);
            this.PlanHouseTxtBox.Name = "PlanHouseTxtBox";
            this.PlanHouseTxtBox.PlaceholderText = "Дом";
            this.PlanHouseTxtBox.Size = new System.Drawing.Size(254, 27);
            this.PlanHouseTxtBox.TabIndex = 11;
            this.PlanHouseTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_House);
            // 
            // PlanStreetTxtBox
            // 
            this.PlanStreetTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PlanStreetTxtBox.Location = new System.Drawing.Point(188, 210);
            this.PlanStreetTxtBox.Name = "PlanStreetTxtBox";
            this.PlanStreetTxtBox.PlaceholderText = "Улица";
            this.PlanStreetTxtBox.Size = new System.Drawing.Size(254, 27);
            this.PlanStreetTxtBox.TabIndex = 10;
            this.PlanStreetTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Is_Digit);
            // 
            // PlanTownTxtBox
            // 
            this.PlanTownTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PlanTownTxtBox.Location = new System.Drawing.Point(188, 177);
            this.PlanTownTxtBox.Name = "PlanTownTxtBox";
            this.PlanTownTxtBox.PlaceholderText = "Город";
            this.PlanTownTxtBox.Size = new System.Drawing.Size(254, 27);
            this.PlanTownTxtBox.TabIndex = 9;
            this.PlanTownTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Is_Digit);
            // 
            // PhoneMskdTxtBox
            // 
            this.PhoneMskdTxtBox.Location = new System.Drawing.Point(188, 131);
            this.PhoneMskdTxtBox.Mask = "+7 (999) 000-0000";
            this.PhoneMskdTxtBox.Name = "PhoneMskdTxtBox";
            this.PhoneMskdTxtBox.Size = new System.Drawing.Size(254, 27);
            this.PhoneMskdTxtBox.TabIndex = 8;
            // 
            // PlanNameTxtBox
            // 
            this.PlanNameTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PlanNameTxtBox.Location = new System.Drawing.Point(188, 87);
            this.PlanNameTxtBox.Name = "PlanNameTxtBox";
            this.PlanNameTxtBox.Size = new System.Drawing.Size(254, 27);
            this.PlanNameTxtBox.TabIndex = 7;
            this.PlanNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Is_Digit);
            // 
            // GoalLbl
            // 
            this.GoalLbl.AutoSize = true;
            this.GoalLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GoalLbl.Location = new System.Drawing.Point(3, 285);
            this.GoalLbl.Name = "GoalLbl";
            this.GoalLbl.Size = new System.Drawing.Size(148, 28);
            this.GoalLbl.TabIndex = 6;
            this.GoalLbl.Text = "Цель встречи:";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneLbl.Location = new System.Drawing.Point(3, 130);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(179, 28);
            this.PhoneLbl.TabIndex = 5;
            this.PhoneLbl.Text = "Номер телефона:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата и время:";
            // 
            // MeetingLbl
            // 
            this.MeetingLbl.AutoSize = true;
            this.MeetingLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MeetingLbl.Location = new System.Drawing.Point(94, -1);
            this.MeetingLbl.Name = "MeetingLbl";
            this.MeetingLbl.Size = new System.Drawing.Size(270, 31);
            this.MeetingLbl.TabIndex = 1;
            this.MeetingLbl.Text = "Планирование встречи";
            // 
            // DateMskdTxtBox
            // 
            this.DateMskdTxtBox.Location = new System.Drawing.Point(188, 43);
            this.DateMskdTxtBox.Mask = "00/00/0000 90:00";
            this.DateMskdTxtBox.Name = "DateMskdTxtBox";
            this.DateMskdTxtBox.Size = new System.Drawing.Size(254, 27);
            this.DateMskdTxtBox.TabIndex = 0;
            this.DateMskdTxtBox.ValidatingType = typeof(System.DateTime);
            // 
            // organizerPanel
            // 
            this.organizerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizerPanel.AutoScroll = true;
            this.organizerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.organizerPanel.Location = new System.Drawing.Point(283, 73);
            this.organizerPanel.Name = "organizerPanel";
            this.organizerPanel.Size = new System.Drawing.Size(794, 601);
            this.organizerPanel.TabIndex = 2;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLbl.Location = new System.Drawing.Point(317, 6);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(156, 31);
            this.DateLbl.TabIndex = 0;
            this.DateLbl.Text = "8 марта 2022";
            // 
            // topPanel
            // 
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.DateLbl);
            this.topPanel.Location = new System.Drawing.Point(283, 27);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(794, 45);
            this.topPanel.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeTheme,
            this.ShowAllMeetings});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(1534, 28);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "menuStrip1";
            // 
            // ChangeTheme
            // 
            this.ChangeTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WhiteTheme,
            this.StandartTheme,
            this.MonochromeTheme,
            this.EcologicalTheme});
            this.ChangeTheme.Name = "ChangeTheme";
            this.ChangeTheme.Size = new System.Drawing.Size(119, 24);
            this.ChangeTheme.Text = "Сменить тему";
            // 
            // WhiteTheme
            // 
            this.WhiteTheme.BackColor = System.Drawing.Color.White;
            this.WhiteTheme.Name = "WhiteTheme";
            this.WhiteTheme.Size = new System.Drawing.Size(224, 26);
            this.WhiteTheme.Text = "Светлая тема";
            this.WhiteTheme.Click += new System.EventHandler(this.WhiteTheme_Click);
            // 
            // StandartTheme
            // 
            this.StandartTheme.BackColor = System.Drawing.Color.White;
            this.StandartTheme.Name = "StandartTheme";
            this.StandartTheme.Size = new System.Drawing.Size(224, 26);
            this.StandartTheme.Text = "Стандратная тема";
            this.StandartTheme.Click += new System.EventHandler(this.StandartTheme_Click);
            // 
            // MonochromeTheme
            // 
            this.MonochromeTheme.Name = "MonochromeTheme";
            this.MonochromeTheme.Size = new System.Drawing.Size(224, 26);
            this.MonochromeTheme.Text = "Монохром";
            this.MonochromeTheme.Click += new System.EventHandler(this.MonochromeTheme_Click);
            // 
            // EcologicalTheme
            // 
            this.EcologicalTheme.Name = "EcologicalTheme";
            this.EcologicalTheme.Size = new System.Drawing.Size(224, 26);
            this.EcologicalTheme.Text = "Экологичная тема";
            this.EcologicalTheme.Click += new System.EventHandler(this.EcologicalTheme_Click);
            // 
            // ShowAllMeetings
            // 
            this.ShowAllMeetings.Name = "ShowAllMeetings";
            this.ShowAllMeetings.Size = new System.Drawing.Size(306, 24);
            this.ShowAllMeetings.Text = "Показать все запланированные встречи";
            this.ShowAllMeetings.Click += new System.EventHandler(this.ShowAllMeetings_Click);
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 686);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.organizerPanel);
            this.Controls.Add(this.PlanMeetingPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.calendarPanel);
            this.Controls.Add(this.Menu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "Organizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Органайзер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Organizer_FormClosing);
            this.Load += new System.EventHandler(this.Organizer_Load);
            this.calendarPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.PlanMeetingPanel.ResumeLayout(false);
            this.PlanMeetingPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel calendarPanel;
        private Panel searchPanel;
        private MonthCalendar calendar;
        private MaskedTextBox PhoneNumberMskdTxtBox;
        private Label NameLbl;
        private Label AddressLbl;
        private Label PhoneNumberLbl;
        private Label SearchLbl;
        private Button SearchBtn;
        private TextBox NameTxtBox;
        private TextBox HouseTxtBox;
        private TextBox StreetTxtBox;
        private TextBox TownTxtBox;
        private Panel PlanMeetingPanel;
        private Button CreateBtn;
        private TextBox GoalTxtBox;
        private TextBox PlanHouseTxtBox;
        private TextBox PlanStreetTxtBox;
        private TextBox PlanTownTxtBox;
        private MaskedTextBox PhoneMskdTxtBox;
        private TextBox PlanNameTxtBox;
        private Label GoalLbl;
        private Label PhoneLbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label MeetingLbl;
        private MaskedTextBox DateMskdTxtBox;
        private Button ClearBtn;
        public Panel organizerPanel;
        private Label DateLbl;
        private Button ClearSearchPanelBtn;
        private Panel topPanel;
        private MenuStrip Menu;
        private ToolStripMenuItem ChangeTheme;
        private ToolStripMenuItem WhiteTheme;
        private ToolStripMenuItem StandartTheme;
        private ToolStripMenuItem MonochromeTheme;
        private ToolStripMenuItem EcologicalTheme;
        private ToolStripMenuItem ShowAllMeetings;
    }
}