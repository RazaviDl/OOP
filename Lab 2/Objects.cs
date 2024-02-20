using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class BankAccount
    {
        public string numberAccount { get; set; }
        public string creatingDate { get; set; }
        public string typeAccount { get; set; }

        public int balance { get; set; }

        public bool isSMSNotif { get; set; }
        public bool isMonthlyCopying { get; set; }

        public BankAccount(string numberAccount, string creatingDate,
                           string typeAccount, int balance,
                           bool isSMSNotif, bool isMonthlyCopying)
        {
            this.numberAccount = numberAccount;
            this.creatingDate = creatingDate;
            this.typeAccount = typeAccount;
            this.balance = balance;
            this.isSMSNotif = isSMSNotif;
            this.isMonthlyCopying = isMonthlyCopying;
        }

    }

    public class Owner
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string lastname { get; set; }
        public string birthday { get; set; }
        public string pasport { get; set; }

        public Owner(string name, string surname,
                     string lastname, string birthday,
                     string pasport)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
            this.birthday = birthday;
            this.pasport = pasport;
        }
    }

    public class HistoryOperation
    {
        public string operationType { get; set; }
        public int sum { get; set; }
        public string date { get; set; }
    }
}
