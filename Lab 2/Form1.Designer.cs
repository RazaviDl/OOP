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
            listAccount = new ListView();
            label4 = new Label();
            surname = new TextBox();
            name = new TextBox();
            lastName = new TextBox();
            label5 = new Label();
            pasportData = new TextBox();
            AddAccount = new Button();
            ViewAccount = new Button();
            birtday = new DateTimePicker();
            panel1 = new Panel();
            ExtractJSON = new Button();
            SaveJSON = new Button();
            Clear = new Button();
            ClearData = new Button();
            label6 = new Label();
            label7 = new Label();
            balanceText = new TextBox();
            HistoryOperation = new Button();
            ((System.ComponentModel.ISupportInitialize)balanceAccount).BeginInit();
            SuspendLayout();
            // 
            // InformationAccount
            // 
            InformationAccount.AutoSize = true;
            InformationAccount.Font = new Font("Segoe UI", 12F);
            InformationAccount.Location = new Point(60, 40);
            InformationAccount.Name = "InformationAccount";
            InformationAccount.Size = new Size(209, 28);
            InformationAccount.TabIndex = 0;
            InformationAccount.Text = "Информация о счёте:";
            // 
            // bankNumber
            // 
            bankNumber.AccessibleDescription = "";
            bankNumber.AccessibleName = "";
            bankNumber.Location = new Point(60, 98);
            bankNumber.Name = "bankNumber";
            bankNumber.PlaceholderText = "Номер счёта";
            bankNumber.Size = new Size(224, 27);
            bankNumber.TabIndex = 1;
            // 
            // typeAccount
            // 
            typeAccount.FormattingEnabled = true;
            typeAccount.Items.AddRange(new object[] { "Простой", "Накопительный", "Кредитный" });
            typeAccount.Location = new Point(60, 143);
            typeAccount.Name = "typeAccount";
            typeAccount.Size = new Size(224, 28);
            typeAccount.TabIndex = 2;
            typeAccount.Text = "Простой";
            // 
            // balanceAccount
            // 
            balanceAccount.Location = new Point(60, 225);
            balanceAccount.Maximum = 10000;
            balanceAccount.Name = "balanceAccount";
            balanceAccount.Size = new Size(224, 56);
            balanceAccount.TabIndex = 3;
            balanceAccount.Scroll += BalanceAccountScroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 202);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Баланс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 284);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 5;
            label2.Text = "Дата создания";
            // 
            // creatingDateAccount
            // 
            creatingDateAccount.Location = new Point(60, 307);
            creatingDateAccount.Name = "creatingDateAccount";
            creatingDateAccount.Size = new Size(197, 27);
            creatingDateAccount.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 392);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 7;
            label3.Text = "Дополнительные услуги:";
            // 
            // smsNotification
            // 
            smsNotification.AutoSize = true;
            smsNotification.Location = new Point(60, 436);
            smsNotification.Name = "smsNotification";
            smsNotification.Size = new Size(153, 24);
            smsNotification.TabIndex = 8;
            smsNotification.Text = "SMS оповещения";
            smsNotification.UseVisualStyleBackColor = true;
            // 
            // monthlyCopying
            // 
            monthlyCopying.AutoSize = true;
            monthlyCopying.Location = new Point(60, 466);
            monthlyCopying.Name = "monthlyCopying";
            monthlyCopying.Size = new Size(188, 24);
            monthlyCopying.TabIndex = 9;
            monthlyCopying.Text = "Ежемесечная выписка";
            monthlyCopying.UseVisualStyleBackColor = true;
            // 
            // listAccount
            // 
            listAccount.Location = new Point(60, 543);
            listAccount.Name = "listAccount";
            listAccount.Size = new Size(228, 164);
            listAccount.TabIndex = 10;
            listAccount.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(502, 40);
            label4.Name = "label4";
            label4.Size = new Size(209, 28);
            label4.TabIndex = 11;
            label4.Text = "Информация о счёте:";
            // 
            // surname
            // 
            surname.AccessibleDescription = "";
            surname.AccessibleName = "";
            surname.Location = new Point(502, 98);
            surname.Name = "surname";
            surname.PlaceholderText = "Фамилия";
            surname.Size = new Size(224, 27);
            surname.TabIndex = 12;
            // 
            // name
            // 
            name.AccessibleDescription = "";
            name.AccessibleName = "";
            name.Location = new Point(502, 144);
            name.Name = "name";
            name.PlaceholderText = "Имя";
            name.Size = new Size(224, 27);
            name.TabIndex = 13;
            // 
            // lastName
            // 
            lastName.AccessibleDescription = "";
            lastName.AccessibleName = "";
            lastName.Location = new Point(502, 195);
            lastName.Name = "lastName";
            lastName.PlaceholderText = "Отчество";
            lastName.Size = new Size(224, 27);
            lastName.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 284);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 16;
            label5.Text = "Дата рождения";
            // 
            // pasportData
            // 
            pasportData.AccessibleDescription = "";
            pasportData.AccessibleName = "";
            pasportData.Location = new Point(502, 385);
            pasportData.Name = "pasportData";
            pasportData.PlaceholderText = "Данные паспорта";
            pasportData.Size = new Size(224, 27);
            pasportData.TabIndex = 18;
            // 
            // AddAccount
            // 
            AddAccount.Location = new Point(619, 608);
            AddAccount.Name = "AddAccount";
            AddAccount.Size = new Size(140, 38);
            AddAccount.TabIndex = 19;
            AddAccount.Text = "Добавить";
            AddAccount.UseVisualStyleBackColor = true;
            AddAccount.Click += AddAccountClick;
            // 
            // ViewAccount
            // 
            ViewAccount.Location = new Point(446, 608);
            ViewAccount.Name = "ViewAccount";
            ViewAccount.Size = new Size(140, 38);
            ViewAccount.TabIndex = 20;
            ViewAccount.Text = "Показать счета";
            ViewAccount.UseVisualStyleBackColor = true;
            ViewAccount.Click += ViewAccountClick;
            // 
            // birtday
            // 
            birtday.Location = new Point(502, 307);
            birtday.Name = "birtday";
            birtday.Size = new Size(224, 27);
            birtday.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(391, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 754);
            panel1.TabIndex = 22;
            // 
            // ExtractJSON
            // 
            ExtractJSON.Location = new Point(446, 543);
            ExtractJSON.Name = "ExtractJSON";
            ExtractJSON.Size = new Size(140, 38);
            ExtractJSON.TabIndex = 23;
            ExtractJSON.Text = "Извлечь";
            ExtractJSON.UseVisualStyleBackColor = true;
            ExtractJSON.Click += ExtractJSONClick;
            // 
            // SaveJSON
            // 
            SaveJSON.Location = new Point(619, 543);
            SaveJSON.Name = "SaveJSON";
            SaveJSON.Size = new Size(140, 38);
            SaveJSON.TabIndex = 24;
            SaveJSON.Text = "Сохранить";
            SaveJSON.UseVisualStyleBackColor = true;
            SaveJSON.Click += SaveJSONClick;
            // 
            // Clear
            // 
            Clear.Location = new Point(446, 669);
            Clear.Name = "Clear";
            Clear.Size = new Size(140, 38);
            Clear.TabIndex = 25;
            Clear.Text = " Очистить поля";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += ClearClick;
            // 
            // ClearData
            // 
            ClearData.Location = new Point(619, 669);
            ClearData.Name = "ClearData";
            ClearData.Size = new Size(140, 38);
            ClearData.TabIndex = 26;
            ClearData.Text = "Очистить данные";
            ClearData.UseVisualStyleBackColor = true;
            ClearData.Click += ClearDataClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 264);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 27;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 264);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 28;
            label7.Text = "10000";
            // 
            // balanceText
            // 
            balanceText.Location = new Point(290, 225);
            balanceText.Name = "balanceText";
            balanceText.Size = new Size(71, 27);
            balanceText.TabIndex = 29;
            balanceText.Text = "0";
            // 
            // HistoryOperation
            // 
            HistoryOperation.Location = new Point(446, 485);
            HistoryOperation.Name = "HistoryOperation";
            HistoryOperation.Size = new Size(313, 38);
            HistoryOperation.TabIndex = 30;
            HistoryOperation.Text = "История операций";
            HistoryOperation.UseVisualStyleBackColor = true;
            HistoryOperation.Click += HistoryOperation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 753);
            Controls.Add(HistoryOperation);
            Controls.Add(balanceText);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ClearData);
            Controls.Add(Clear);
            Controls.Add(SaveJSON);
            Controls.Add(ExtractJSON);
            Controls.Add(panel1);
            Controls.Add(ViewAccount);
            Controls.Add(AddAccount);
            Controls.Add(pasportData);
            Controls.Add(label5);
            Controls.Add(birtday);
            Controls.Add(lastName);
            Controls.Add(name);
            Controls.Add(surname);
            Controls.Add(label4);
            Controls.Add(listAccount);
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
        private ListView listAccount;
        private Label label4;
        private TextBox surname;
        private TextBox name;
        private TextBox lastName;
        private Label label5;
        private TextBox pasportData;
        private Button AddAccount;
        private Button ViewAccount;
        private DateTimePicker birtday;
        private Panel panel1;
        private Button ExtractJSON;
        private Button SaveJSON;
        private Button Clear;
        private Button ClearData;
        private Label label6;
        private Label label7;
        private TextBox balanceText;
        private Button HistoryOperation;
    }
}
