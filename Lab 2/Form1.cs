using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public List<BankAccount> bankAccount = new List<BankAccount>();
        public List<Owner> owner = new List<Owner>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddAccountClick(object sender, EventArgs e)
        {
            if (bankNumber.Text == "" || name.Text == "" ||
                surname.Text == "" || lastName.Text == "" ||
                pasportData.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            Predicate<BankAccount> isBunkNumber =
                x => x.numberAccount == bankNumber.Text;

            if (bankAccount.Exists(isBunkNumber) == true)
            {
                MessageBox.Show("Данный счёт имеется!");
                return;
            }

            bankAccount.Add(new BankAccount(bankNumber.Text, creatingDateAccount.Text,
                                            typeAccount.Text, balanceAccount.Value,
                                            smsNotification.Checked, monthlyCopying.Checked));

            owner.Add(new Owner(name.Text, surname.Text,
                                lastName.Text, birtday.Text,
                                pasportData.Text));
        }

        private void ViewAccountClick(object sender, EventArgs e)
        {
            for (int i = 0; i < bankAccount.Count; i++)
            {
                listAccount.Items.Add($"Счёт: {bankAccount[i].numberAccount}, " +
                    $"баланс: {bankAccount[i].balance}, фамилия: {owner[i].surname}");
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            bankNumber.Text = "";
            typeAccount.SelectedIndex = 0;
            balanceAccount.Value = 0;
            smsNotification.Checked = false;
            monthlyCopying.Checked = false;
            name.Text = "";
            surname.Text = "";
            lastName.Text = "";
            pasportData.Text = "";
        }

        private void ClearDataClick(object sender, EventArgs e)
        {
            bankAccount.Clear();
            owner.Clear();
        }

        private void ExtractJSONClick(object sender, EventArgs e)
        {
            string json = File.ReadAllText("bank.json");

            if (json == "")
            {
                MessageBox.Show("JSON файл пустой!");
                return;
            }

            Dictionary<string, object> data = JsonSerializer.Deserialize<Dictionary<string, object>>(json);

            foreach (var item in data)
            {
                string number = item.Key;
                JsonElement value = (JsonElement)item.Value;

                bankAccount.Add(new BankAccount(
                        number,
                        value.GetProperty("creatingDate").GetString(),
                        value.GetProperty("typeAccount").GetString(),
                        value.GetProperty("balance").GetInt32(),
                        value.GetProperty("isSMSNotif").GetBoolean(),
                        value.GetProperty("isMonthlyCopying").GetBoolean()
                    )
                );

                owner.Add(new Owner(
                        value.GetProperty("name").GetString(),
                        value.GetProperty("surname").GetString(),
                        value.GetProperty("lastName").GetString(),
                        value.GetProperty("birthday").GetString(),
                        value.GetProperty("passport").GetString()
                    )
                );
            }
        }

        private void SaveJSONClick(object sender, EventArgs e)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();

            for (int i = 0; i < bankAccount.Count; i++)
            {
                data.Add(bankAccount[i].numberAccount, new
                {
                    creatingDate = bankAccount[i].creatingDate,
                    typeAccount = bankAccount[i].typeAccount,
                    balance = bankAccount[i].balance,
                    isSMSNotif = bankAccount[i].isSMSNotif,
                    isMonthlyCopying = bankAccount[i].isSMSNotif,
                    name = owner[i].name,
                    surname = owner[i].surname,
                    lastName = owner[i].lastname,
                    birthday = owner[i].birthday,
                    passport = owner[i].pasport
                });
            }

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("bank.json", json);
        }

        private void BalanceAccountScroll(object sender, EventArgs e)
        {
            balanceText.Text = balanceAccount.Value.ToString();
        }
    }
}