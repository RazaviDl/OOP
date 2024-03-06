namespace Lab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            InformationAccount = new Label();
            bankNumber = new TextBox();
            typeAccount = new ComboBox();
            balanceAccount = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            creatingDateAccount = new DateTimePicker();
            label3 = new Label();
            smsNotification = new CheckBox();
            monthlyCopying = new CheckBox();
            label4 = new Label();
            lastname = new TextBox();
            name = new TextBox();
            surname = new TextBox();
            label5 = new Label();
            pasportData = new TextBox();
            AddAccount = new Button();
            ViewAccount = new Button();
            birthday = new DateTimePicker();
            panel1 = new Panel();
            ExtractJSON = new Button();
            SaveJSON = new Button();
            label6 = new Label();
            label7 = new Label();
            balanceText = new TextBox();
            HistoryOperation = new Button();
            ListBank = new ListBox();
            toolStrip1 = new ToolStrip();
            Search = new ToolStripButton();
            Sort = new ToolStripButton();
            ClearList = new ToolStripDropDownButton();
            ClearData = new ToolStripMenuItem();
            Clear = new ToolStripMenuItem();
            AboutUs = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            StatusLast = new ToolStripStatusLabel();
            StatusCountObject = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)balanceAccount).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // InformationAccount
            // 
            InformationAccount.AutoSize = true;
            InformationAccount.Font = new Font("Segoe UI", 12F);
            InformationAccount.Location = new Point(12, 40);
            InformationAccount.Name = "InformationAccount";
            InformationAccount.Size = new Size(57, 28);
            InformationAccount.TabIndex = 0;
            InformationAccount.Text = "Счёт:";
            // 
            // bankNumber
            // 
            bankNumber.AccessibleDescription = "";
            bankNumber.AccessibleName = "";
            bankNumber.Location = new Point(17, 87);
            bankNumber.Name = "bankNumber";
            bankNumber.PlaceholderText = "Номер счёта";
            bankNumber.Size = new Size(224, 27);
            bankNumber.TabIndex = 1;
            // 
            // typeAccount
            // 
            typeAccount.FormattingEnabled = true;
            typeAccount.Items.AddRange(new object[] { "Простой", "Накопительный", "Кредитный" });
            typeAccount.Location = new Point(17, 130);
            typeAccount.Name = "typeAccount";
            typeAccount.Size = new Size(224, 28);
            typeAccount.TabIndex = 2;
            typeAccount.Text = "Простой";
            // 
            // balanceAccount
            // 
            balanceAccount.Location = new Point(16, 212);
            balanceAccount.Maximum = 10000;
            balanceAccount.Name = "balanceAccount";
            balanceAccount.Size = new Size(224, 56);
            balanceAccount.TabIndex = 3;
            balanceAccount.Scroll += BalanceAccountScroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 182);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Баланс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 293);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 5;
            label2.Text = "Дата создания";
            // 
            // creatingDateAccount
            // 
            creatingDateAccount.Location = new Point(17, 316);
            creatingDateAccount.Name = "creatingDateAccount";
            creatingDateAccount.Size = new Size(197, 27);
            creatingDateAccount.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 386);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 7;
            label3.Text = "Дополнительные услуги:";
            // 
            // smsNotification
            // 
            smsNotification.AutoSize = true;
            smsNotification.Location = new Point(17, 412);
            smsNotification.Name = "smsNotification";
            smsNotification.Size = new Size(153, 24);
            smsNotification.TabIndex = 8;
            smsNotification.Text = "SMS оповещения";
            smsNotification.UseVisualStyleBackColor = true;
            // 
            // monthlyCopying
            // 
            monthlyCopying.AutoSize = true;
            monthlyCopying.Location = new Point(17, 442);
            monthlyCopying.Name = "monthlyCopying";
            monthlyCopying.Size = new Size(188, 24);
            monthlyCopying.TabIndex = 9;
            monthlyCopying.Text = "Ежемесечная выписка";
            monthlyCopying.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(319, 40);
            label4.Name = "label4";
            label4.Size = new Size(209, 28);
            label4.TabIndex = 11;
            label4.Text = "Информация о счёте:";
            // 
            // lastname
            // 
            lastname.AccessibleDescription = "";
            lastname.AccessibleName = "";
            lastname.Location = new Point(324, 98);
            lastname.Name = "lastname";
            lastname.PlaceholderText = "Фамилия";
            lastname.Size = new Size(224, 27);
            lastname.TabIndex = 12;
            // 
            // name
            // 
            name.AccessibleDescription = "";
            name.AccessibleName = "";
            name.Location = new Point(324, 143);
            name.Name = "name";
            name.PlaceholderText = "Имя";
            name.Size = new Size(224, 27);
            name.TabIndex = 13;
            // 
            // surname
            // 
            surname.AccessibleDescription = "";
            surname.AccessibleName = "";
            surname.Location = new Point(324, 182);
            surname.Name = "surname";
            surname.PlaceholderText = "Отчество";
            surname.Size = new Size(224, 27);
            surname.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 251);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 16;
            label5.Text = "Дата рождения";
            // 
            // pasportData
            // 
            pasportData.AccessibleDescription = "";
            pasportData.AccessibleName = "";
            pasportData.Location = new Point(324, 326);
            pasportData.Name = "pasportData";
            pasportData.PlaceholderText = "Данные паспорта";
            pasportData.Size = new Size(224, 27);
            pasportData.TabIndex = 18;
            // 
            // AddAccount
            // 
            AddAccount.Location = new Point(441, 604);
            AddAccount.Name = "AddAccount";
            AddAccount.Size = new Size(107, 38);
            AddAccount.TabIndex = 19;
            AddAccount.Text = "Добавить";
            AddAccount.UseVisualStyleBackColor = true;
            AddAccount.Click += AddAccountClick;
            // 
            // ViewAccount
            // 
            ViewAccount.Location = new Point(324, 604);
            ViewAccount.Name = "ViewAccount";
            ViewAccount.Size = new Size(111, 38);
            ViewAccount.TabIndex = 20;
            ViewAccount.Text = "Счета";
            ViewAccount.UseVisualStyleBackColor = true;
            ViewAccount.Click += ViewAccountClick;
            // 
            // birthday
            // 
            birthday.Location = new Point(324, 283);
            birthday.Name = "birthday";
            birthday.Size = new Size(224, 27);
            birthday.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(293, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 661);
            panel1.TabIndex = 22;
            // 
            // ExtractJSON
            // 
            ExtractJSON.Location = new Point(324, 551);
            ExtractJSON.Name = "ExtractJSON";
            ExtractJSON.Size = new Size(111, 38);
            ExtractJSON.TabIndex = 23;
            ExtractJSON.Text = "Извлечь";
            ExtractJSON.UseVisualStyleBackColor = true;
            ExtractJSON.Click += ExtractJSONClick;
            // 
            // SaveJSON
            // 
            SaveJSON.Location = new Point(441, 551);
            SaveJSON.Name = "SaveJSON";
            SaveJSON.Size = new Size(107, 38);
            SaveJSON.TabIndex = 24;
            SaveJSON.Text = "Сохранить";
            SaveJSON.UseVisualStyleBackColor = true;
            SaveJSON.Click += SaveJSONClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 251);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 27;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 251);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 28;
            label7.Text = "10000";
            // 
            // balanceText
            // 
            balanceText.Location = new Point(87, 251);
            balanceText.Name = "balanceText";
            balanceText.Size = new Size(71, 27);
            balanceText.TabIndex = 29;
            balanceText.Text = "0";
            balanceText.TextAlign = HorizontalAlignment.Center;
            // 
            // HistoryOperation
            // 
            HistoryOperation.Location = new Point(324, 498);
            HistoryOperation.Name = "HistoryOperation";
            HistoryOperation.Size = new Size(224, 38);
            HistoryOperation.TabIndex = 30;
            HistoryOperation.Text = "История операций";
            HistoryOperation.UseVisualStyleBackColor = true;
            HistoryOperation.Click += HistoryOperation_Click;
            // 
            // ListBank
            // 
            ListBank.FormattingEnabled = true;
            ListBank.HorizontalScrollbar = true;
            ListBank.Location = new Point(17, 498);
            ListBank.Name = "ListBank";
            ListBank.Size = new Size(255, 144);
            ListBank.TabIndex = 31;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Search, Sort, ClearList, AboutUs });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new Size(571, 27);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 32;
            toolStrip1.Text = "toolStrip1";
            // 
            // Search
            // 
            Search.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Search.Image = (Image)resources.GetObject("Search.Image");
            Search.ImageTransparentColor = Color.Magenta;
            Search.Name = "Search";
            Search.Size = new Size(56, 24);
            Search.Text = "Поиск";
            Search.Click += Search_Click;
            // 
            // Sort
            // 
            Sort.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Sort.Image = (Image)resources.GetObject("Sort.Image");
            Sort.ImageTransparentColor = Color.Magenta;
            Sort.Name = "Sort";
            Sort.Size = new Size(96, 24);
            Sort.Text = "Сортировка";
            Sort.Click += Sort_Click;
            // 
            // ClearList
            // 
            ClearList.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ClearList.DropDownItems.AddRange(new ToolStripItem[] { ClearData, Clear });
            ClearList.Image = (Image)resources.GetObject("ClearList.Image");
            ClearList.ImageTransparentColor = Color.Magenta;
            ClearList.Name = "ClearList";
            ClearList.Size = new Size(79, 24);
            ClearList.Text = "Очистка";
            // 
            // ClearData
            // 
            ClearData.Name = "ClearData";
            ClearData.Size = new Size(213, 26);
            ClearData.Text = "Очистить данные";
            ClearData.Click += ClearDataClick;
            // 
            // Clear
            // 
            Clear.Name = "Clear";
            Clear.Size = new Size(213, 26);
            Clear.Text = "Сбросить поля";
            Clear.Click += ClearClick;
            // 
            // AboutUs
            // 
            AboutUs.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AboutUs.Image = (Image)resources.GetObject("AboutUs.Image");
            AboutUs.ImageTransparentColor = Color.Magenta;
            AboutUs.Name = "AboutUs";
            AboutUs.Size = new Size(52, 24);
            AboutUs.Text = "О нас";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLast, StatusCountObject });
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            statusStrip1.Location = new Point(0, 632);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(571, 26);
            statusStrip1.TabIndex = 33;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLast
            // 
            StatusLast.Name = "StatusLast";
            StatusLast.Size = new Size(159, 20);
            StatusLast.Text = "Последнее действие: ";
            // 
            // StatusCountObject
            // 
            StatusCountObject.Margin = new Padding(30, 4, 0, 2);
            StatusCountObject.Name = "StatusCountObject";
            StatusCountObject.Size = new Size(178, 20);
            StatusCountObject.Text = "Количество объектов:  0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 658);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(ListBank);
            Controls.Add(HistoryOperation);
            Controls.Add(balanceText);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(SaveJSON);
            Controls.Add(ExtractJSON);
            Controls.Add(panel1);
            Controls.Add(ViewAccount);
            Controls.Add(AddAccount);
            Controls.Add(pasportData);
            Controls.Add(label5);
            Controls.Add(birthday);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(lastname);
            Controls.Add(label4);
            Controls.Add(monthlyCopying);
            Controls.Add(smsNotification);
            Controls.Add(label3);
            Controls.Add(creatingDateAccount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(balanceAccount);
            Controls.Add(typeAccount);
            Controls.Add(bankNumber);
            Controls.Add(InformationAccount);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)balanceAccount).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InformationAccount;
        private TextBox bankNumber;
        private ComboBox typeAccount;
        private TrackBar balanceAccount;
        private Label label1;
        private Label label2;
        private DateTimePicker creatingDateAccount;
        private Label label3;
        private CheckBox smsNotification;
        private CheckBox monthlyCopying;
        private Label label4;
        private TextBox lastname;
        private TextBox name;
        private TextBox surname;
        private Label label5;
        private TextBox pasportData;
        private Button AddAccount;
        private Button ViewAccount;
        private DateTimePicker birthday;
        private Panel panel1;
        private Button ExtractJSON;
        private Button SaveJSON;
        private Label label6;
        private Label label7;
        private TextBox balanceText;
        private Button HistoryOperation;
        private ListBox ListBank;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton ClearList;
        private ToolStripMenuItem ClearData;
        private ToolStripMenuItem Clear;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLast;
        private ToolStripStatusLabel StatusCountObject;
        private ToolStripButton Search;
        private ToolStripButton Sort;
        private ToolStripButton AboutUs;
    }
}
