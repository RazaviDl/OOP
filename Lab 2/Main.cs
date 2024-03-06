using System.ComponentModel.DataAnnotations  ;

namespace Lab2
{
    public class BankAccount
    {
        [Range(0, int.MaxValue, ErrorMessage = "Счёт должен состоять только из цифр.")]
        public int NumberAccount { get; set; }

        public int Balance { get; set; }

        public string CreatingDate { get; set; }
        public string TypeAccount { get; set; }


        public bool IsSMSNotif { get; set; }
        public bool IsMonthlyCopying { get; set; }
    }

    public class Owner
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле фамилии обязательно для заполнения.")]
        [RegularExpression(@"^[a-zA-Zа-яА-Я\-]+$", ErrorMessage = "Фамилия должна состоять только из букв и дефисов.")]
        public string Lastname { get; set; }

        public string Surname { get; set; }
        public string Birthday { get; set; }

        [BelarusPassportValidation]
        public string Passport { get; set; }
    }

    public class Accounts
    {
        public BankAccount Account { get; set; }

        public Owner Owner { get; set; }

    }

    public class BelarusPassportValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string passportNumber = value.ToString();

                if (passportNumber.Length == 9 && passportNumber.StartsWith("AB"))
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult("Неправильный формат паспорта");
            }

            return ValidationResult.Success;
        }
    }

    public class HistoryOperation
    {
        public string OperationType { get; set; }
        public string Date { get; set; }

        public int Sum { get; set; }
    }

}
