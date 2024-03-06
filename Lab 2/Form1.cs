using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public static List<Accounts> accounts = new List<Accounts>();

        public Form1()
        {
            InitializeComponent();

            ChangeStatus("������ �����");
        }


        private void AddAccountClick(object sender, EventArgs e)
        {
            if (bankNumber.Text == "" || name.Text == "" ||
                surname.Text == "" || pasportData.Text == "")
            {
                ChangeStatus("������� ���������� ������");

                MessageBox.Show("�� ��� ���� ���������!");

                return;
            }

            BankAccount bankAccount = new BankAccount()
            {
                NumberAccount = int.TryParse(bankNumber.Text, out int number) ? number : -1,
                CreatingDate = creatingDateAccount.Text,
                Balance = balanceAccount.Value,
                IsSMSNotif = smsNotification.Checked,
                IsMonthlyCopying = monthlyCopying.Checked,
            };

            Owner owner = new Owner()
            {
                Name = name.Text,
                Surname = surname.Text,
                Lastname = lastname.Text,
                Birthday = birthday.Text,
                Passport = pasportData.Text
            };

            var validationContextOwner = new ValidationContext(owner);
            var validationContextBankAccount = new ValidationContext(bankAccount);

            var validationResults1 = new List<ValidationResult>();
            var validationResults2 = new List<ValidationResult>();

            bool isValidOwner1 = Validator.TryValidateObject(owner, validationContextOwner, validationResults1, true);
            bool isValidOwner2 = Validator.TryValidateObject(bankAccount, validationContextBankAccount, validationResults2, true);

            if (isValidOwner1 == false || isValidOwner2 == false)
            {
                ChangeStatus("������� ���������� ������");

                foreach (var val in validationResults1.Concat(validationResults2))
                    MessageBox.Show(val.ErrorMessage);
            }
            else
            {
                Predicate<Accounts> isBunkNumber = x => x.Account.NumberAccount == int.Parse(bankNumber.Text);

                if (accounts.Exists(isBunkNumber) == true)
                {
                    MessageBox.Show("������ ���� �������!");

                    return;
                }

                accounts.Add(new Accounts()
                {
                    Owner = owner,
                    Account = bankAccount
                });
            }

            ChangeStatus("����������� ������");
        }

        private void ViewAccountClick(object sender, EventArgs e)
        {
            ListBank.Items.Clear();

            foreach (var elem in accounts)
            {
                ListBank.Items.Add($"����: {elem.Account.NumberAccount}, " +
                    $"������: {elem.Account.Balance}, �������: {elem.Owner.Surname}");
            }

            ChangeStatus("�������� ������");
        }

        private void ClearClick(object sender, EventArgs e)
        {
            pasportData.Clear();
            bankNumber.Clear();
            lastname.Clear();
            surname.Clear();
            name.Clear();

            typeAccount.SelectedIndex = 0;
            balanceAccount.Value = 0;
            balanceText.Text = "0";
            smsNotification.Checked = false;
            monthlyCopying.Checked = false;

            ChangeStatus("������� �����");
        }

        private void ClearDataClick(object sender, EventArgs e)
        {
            accounts.Clear();

            ChangeStatus("������� ������");
        }

        private void ExtractJSONClick(object sender, EventArgs e)
        {
            string json = File.ReadAllText("bank.json");

            if (json == "")
            {
                MessageBox.Show("JSON ���� ������!");

                return;
            }

            var data = JsonSerializer.Deserialize<Dictionary<int, object>>(json);

            foreach (var item in data)
            {
                int number = item.Key;
                JsonElement value = (JsonElement)item.Value;

                Predicate<Accounts> isBunkNumber =
                    x => x.Account.NumberAccount == number;

                if (accounts.Exists(isBunkNumber) == true) continue;

                BankAccount newBank = new BankAccount()
                {
                    NumberAccount = number,
                    CreatingDate = value.GetProperty("creatingDate").GetString(),
                    TypeAccount = value.GetProperty("typeAccount").GetString(),
                    Balance = value.GetProperty("balance").GetInt32(),
                    IsSMSNotif = value.GetProperty("isSMSNotif").GetBoolean(),
                    IsMonthlyCopying = value.GetProperty("isMonthlyCopying").GetBoolean()
                };


                Owner owner = new Owner()
                {
                    Name = value.GetProperty("name").GetString(),
                    Surname = value.GetProperty("surname").GetString(),
                    Lastname = value.GetProperty("lastName").GetString(),
                    Birthday = value.GetProperty("birthday").GetString(),
                    Passport = value.GetProperty("passport").GetString()
                };

                accounts.Add(new Accounts()
                {
                    Owner = owner,
                    Account = newBank
                });
            }

            ChangeStatus("���������� ������ �� JSON");
        }

        private void SaveJSONClick(object sender, EventArgs e)
        {
            var data = new Dictionary<int, object>();

            foreach (var elem in accounts)
            {
                data.Add(elem.Account.NumberAccount, new
                {
                    creatingDate = elem.Account.CreatingDate,
                    typeAccount = elem.Account.TypeAccount,
                    balance = elem.Account.Balance,
                    isSMSNotif = elem.Account.IsSMSNotif,
                    isMonthlyCopying = elem.Account.IsMonthlyCopying,
                    name = elem.Owner.Name,
                    surname = elem.Owner.Surname,
                    lastName = elem.Owner.Lastname,
                    birthday = elem.Owner.Birthday,
                    passport = elem.Owner.Passport
                });
            }

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("bank.json", json);

            ChangeStatus("���������� ������ � JSON");
        }

        private void BalanceAccountScroll(object sender, EventArgs e)
        {
            balanceText.Text = balanceAccount.Value.ToString();
        }

        private void HistoryOperation_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            ChangeStatus("�������� ������� ��������");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ListBank.Items.Clear();

            foreach (var elem in accounts)
            {
                if (elem.Account.NumberAccount == int.Parse(bankNumber.Text))
                {
                    ListBank.Items.Add($"����: {elem.Account.NumberAccount}, " +
                                       $"������: {elem.Account.Balance}, " +
                                       $"�������: {elem.Owner.Surname}");
                }
            }

            ChangeStatus("����� ������");
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            accounts.Sort((x, y) => x.Account.NumberAccount.CompareTo(y.Account.NumberAccount));

            ViewAccountClick(sender, e);

            ChangeStatus("���������� ������");
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������: 1.0.0 (����)\n�����������: ���� ������");
        }

        private void ChangeStatus(string status)
        {
            StatusLast.Text = "��������� ��������: " + status;
            StatusCountObject.Text = "��������: " + accounts.Count;
        }

    }
}