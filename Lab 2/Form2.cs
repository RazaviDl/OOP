using System;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public List<HistoryOperation> historyOperations;

        public Form2()
        {
            historyOperations = new List<HistoryOperation>();
            InitializeComponent();
        }

        private void SaveJSON_Click(object sender, EventArgs e)
        {
            Dictionary<int, object> data = new Dictionary<int, object>();

            for (int i = 0; i < historyOperations.Count; i++)
            {
                data.Add(new Random().Next(), new
                {
                    operationType = historyOperations[i].operationType,
                    sum = historyOperations[i].sum,
                    date = historyOperations[i].date
                });
            }

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("history.json", json);
        }

        private void ExtractJSON_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("history.json");

            if (json == "")
            {
                MessageBox.Show("JSON файл пустой!");
                return;
            }

            Dictionary<int, object> data = JsonSerializer.Deserialize<Dictionary<int, object>>(json);

            foreach (var item in data)
            {
                int key = item.Key;
                JsonElement value = (JsonElement)item.Value;

                string operationType = value.GetProperty("operationType").GetString();
                int sum = value.GetProperty("sum").GetInt32();
                string date = value.GetProperty("date").GetString();

                FillListhistory(operationType, sum, date);
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (OperationType.Text == "Тип операции")
            {
                MessageBox.Show("Выберите тип операции!");
                return;
            }
            else if(SumOperation.Text == "" || int.TryParse(SumOperation.Text, out int _) == false)
            {
                MessageBox.Show("Введите корректную сумму!");
                return;
            }

            FillListhistory(OperationType.Text, int.Parse(SumOperation.Text), DateTime.Now.ToString());
        }

        private void FillListhistory(string type, int sum, string date)
        {
            HistoryOperation tmp = new HistoryOperation
            {
                operationType = type,
                sum = sum,
                date = date
            };

            historyOperations.Add(tmp);

            HistoryOperation.Items.Add($"Тип: {tmp.operationType}, сумма: {tmp.sum}, дата: {tmp.date}");
        }
    }
}