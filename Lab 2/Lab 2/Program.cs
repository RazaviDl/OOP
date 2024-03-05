public partial class Customer
{
    private static int _count = 0;
    private readonly int _id;
    private string _lastName;
    private string _firstName;
    private string _middleName;
    private string _address;
    private string _creditCardNumber;
    private decimal _balance;
    public Customer(string lastName, string firstName, string middleName, string address, string creditCardNumber, decimal balance) : this(lastName, firstName, middleName)
    {
        _id = GetHashCode();
        _count++;
        Address = address;
        CreditCardNumber = creditCardNumber;
        Balance = balance;
    }

    public Customer(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }


    static Customer()
    {
        // Инициализация статических полей
    }

    private Customer(int id)
    {
        // Инициализация закрытого конструктора
    }

    public static int Count => _count;

    public int ID => _id;

    public const string SomeConstant = "Constant Value";

    public string LastName
    {
        get { return _lastName; }
        set
        {
            // Проверка корректности
            _lastName = value;
        }
    }

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            // Проверка корректности
            _firstName = value;
        }
    }

    public string MiddleName
    {
        get { return _middleName; }
        set
        {
            // Проверка корректности
            _middleName = value;
        }
    }

    public string Address
    {
        get { return _address; }
        set
        {
            // Проверка корректности
            _address = value;
        }
    }

    public string CreditCardNumber
    {
        get 
        { 
            return _creditCardNumber; 
        }
        set
        {
            // Проверка корректности
            _creditCardNumber = value;
        }
    }

    public decimal Balance
    {
        get { return _balance; }
        private set
        {
            // Проверка корректности
            _balance = value;
        }
    }
}


public partial class Customer
{

    public void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("Сумма должна быть положительной");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("Сумма должна быть положительной");

        if (Balance - amount < 0)
            throw new InvalidOperationException("Недостаточно средств на счету");

        Balance -= amount;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        var other = (Customer)obj;

        return ID == other.ID &&
               LastName == other.LastName &&
               FirstName == other.FirstName &&
               MiddleName == other.MiddleName &&
               Address == other.Address &&
               CreditCardNumber == other.CreditCardNumber &&
               Balance == other.Balance;
    }

    public override int GetHashCode()
    {
        return ID ^
               LastName.Length ^
               FirstName.Length ^
               MiddleName.Length ^
               Address.Length ^
               CreditCardNumber.Length ^
               Balance.GetHashCode();
    }

    public override string ToString()
    {
        return $"ID: {ID}, Фамилия: {LastName}, Имя: {FirstName}, Отчество: {MiddleName}, Адрес: {Address}, Номер кредитной карточки: {CreditCardNumber}, Баланс: {Balance}";
    }

    static void Main(string[] args)
    {
        // Создание объектов класса Customer
        Customer customer1 = new Customer("Иванов", "Иван", "Иванович", "Минск, Беларусь", "1234 5678 9012 3456", 1000m);
        Customer customer2 = new Customer("Петров", "Петр", "Петрович", "Москва, Россия", "2345 6789 0123 4567", 2000m);
        Customer customer3 = new Customer("Сидоров", "Сидор", "Сидорович", "Киев, Украина", "3456 7890 1234 5678", 3000m);

        // Вывод информации о клиентах
        Console.WriteLine(customer1.ToString());
        Console.WriteLine(customer2.ToString());
        Console.WriteLine(customer3.ToString());

        // Зачисление и списание сумм на счет
        customer1.Deposit(500m);
        customer2.Withdraw(200m);

        // Вывод обновленной информации о клиентах
        Console.WriteLine(customer1.ToString());
        Console.WriteLine(customer2.ToString());

        // Сравнение объектов
        Console.WriteLine(customer1.Equals(customer2));

        // Проверка типа созданного объекта
        Console.WriteLine(customer1 is Customer);

        // Создание массива объектов
        Customer[] customers = new Customer[] { customer1, customer2, customer3 };

        // Сортировка массива по фамилии покупателей в алфавитном порядке
        Array.Sort(customers, (x, y) => string.Compare(x.LastName, y.LastName));

        // Вывод списка покупателей в алфавитном порядке
        foreach (var customer in customers)
            Console.WriteLine(customer.LastName);

        // Создание анонимного типа
        var anonymousCustomer = new
        {
            ID = 1,
            LastName = "Иванов",
            FirstName = "Иван",
            MiddleName = "Иванович",
            Address = "Минск, Беларусь",
            CreditCardNumber = "1234 5678 9012 3456",
            Balance = 1000m
        };

        // Вывод информации об анонимном типе
        Console.WriteLine(anonymousCustomer.ToString());
    }

}