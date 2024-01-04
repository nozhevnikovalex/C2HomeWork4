using System;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    // Перевантаження оператору +
    public static Employee operator +(Employee employee, double amount)
    {
        employee.Salary += amount;
        return employee;
    }

    // Перевантаження оператору -
    public static Employee operator -(Employee employee, double amount)
    {
        employee.Salary -= amount;
        return employee;
    }

    // Перевантаження оператору ==
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.Salary == employee2.Salary;
    }

    // Перевантаження оператору !=
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return employee1.Salary != employee2.Salary;
    }

    // Перевантаження оператору <
    public static bool operator <(Employee employee1, Employee employee2)
    {
        return employee1.Salary < employee2.Salary;
    }

    // Перевантаження оператору >
    public static bool operator >(Employee employee1, Employee employee2)
    {
        return employee1.Salary > employee2.Salary;
    }

    // Перевизначення методу Equals
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Employee other = (Employee)obj;
        return Salary == other.Salary;
    }
}

class City
{
    public string Name { get; set; }
    public int Population { get; set; }

    public City(string name, int population)
    {
        Name = name;
        Population = population;
    }

    // Перевантаження оператору +
    public static City operator +(City city, int amount)
    {
        city.Population += amount;
        return city;
    }

    // Перевантаження оператору -
    public static City operator -(City city, int amount)
    {
        city.Population -= amount;
        return city;
    }

    // Перевантаження оператору ==
    public static bool operator ==(City city1, City city2)
    {
        return city1.Population == city2.Population;
    }

    // Перевантаження оператору !=
    public static bool operator !=(City city1, City city2)
    {
        return city1.Population != city2.Population;
    }

    // Перевантаження оператору <
    public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }

    // Перевантаження оператору >
    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }

    // Перевизначення методу Equals
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        City other = (City)obj;
        return Population == other.Population;
    }
}

class CreditCard
{
    public string CardNumber { get; set; }
    public int CVC { get; set; } 
    public double Balance { get; set; }

    public CreditCard(string cardNumber, int cvc, double balance)
    {
        CardNumber = cardNumber;
        CVC = cvc;
        Balance = balance;
    }

    // Перевантаження оператору +
    public static CreditCard operator +(CreditCard creditCard, double amount)
    {
        creditCard.Balance += amount;
        return creditCard;
    }

    // Перевантаження оператору -
    public static CreditCard operator -(CreditCard creditCard, double amount)
    {
        creditCard.Balance -= amount;
        return creditCard;
    }

    // Перевантаження оператору ==
    public static bool operator ==(CreditCard card1, CreditCard card2)
    {
        return card1.CVC == card2.CVC;
    }

    // Перевантаження оператору !=
    public static bool operator !=(CreditCard card1, CreditCard card2)
    {
        return card1.CVC != card2.CVC;
    }

    // Перевантаження оператору <
    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        return card1.Balance < card2.Balance;
    }

    // Перевантаження оператору >
    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        return card1.Balance > card2.Balance;
    }

    // Перевизначення методу Equals
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        CreditCard other = (CreditCard)obj;
        return CVC == other.CVC;
    }
}

class Matrix
{
    private int[,] elements;

    public int Rows { get; }
    public int Columns { get; }

    // Індексатор для отримання або встановлення значень елементів матриці
    public int this[int row, int col]
    {
        get { return elements[row, col]; }
        set { elements[row, col] = value; }
    }

    public Matrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        elements = new int[rows, columns];
    }

    // Перевантаження оператору +
    public static Matrix operator +(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
        {
            throw new InvalidOperationException("Matrices must have the same dimensions for addition.");
        }

        Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix1.Columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    // Перевантаження оператору -
    public static Matrix operator -(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
        {
            throw new InvalidOperationException("Matrices must have the same dimensions for subtraction.");
        }

        Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix1.Columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    // Перевантаження оператору *
    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.Columns != matrix2.Rows)
        {
            throw new InvalidOperationException("Number of columns in the first matrix must be equal to the number of rows in the second matrix for multiplication.");
        }

        Matrix result = new Matrix(matrix1.Rows, matrix2.Columns);

        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix2.Columns; j++)
            {
                for (int k = 0; k < matrix1.Columns; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    // Перевантаження оператору * для множення матриці на число
    public static Matrix operator *(Matrix matrix, int scalar)
    {
        Matrix result = new Matrix(matrix.Rows, matrix.Columns);

        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }

    // Перевантаження оператору ==
    public static bool operator ==(Matrix matrix1, Matrix matrix2)
    {
        if (ReferenceEquals(matrix1, matrix2))
        {
            return true;
        }

        if ((matrix1 is null) || (matrix2 is null))
        {
            return false;
        }

        if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
        {
            return false;
        }

        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix1.Columns; j++)
            {
                if (matrix1[i, j] != matrix2[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }

    // Перевантаження оператору !=
    public static bool operator !=(Matrix matrix1, Matrix matrix2)
    {
        return !(matrix1 == matrix2);
    }

    // Перевизначення методу Equals
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Matrix other = (Matrix)obj;

        if (Rows != other.Rows || Columns != other.Columns)
        {
            return false;
        }

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                if (this[i, j] != other[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }
}


class Program
{
    static void Main()
    {        
        //1
        Employee emp1 = new Employee("John", 1000);
        Employee emp2 = new Employee("Rafael", 1000);

        Console.WriteLine($"{emp1.Name} salary: {emp1.Salary}");
        emp1 = emp1 + 100;
        emp2 = emp2 - 200;
        Console.WriteLine($"{emp1.Name} new salary: {emp1.Salary}");
        Console.WriteLine($"{emp2.Name} new salary: {emp2.Salary}");

        Console.WriteLine(emp2 == emp1);
        Console.WriteLine(emp2 != emp1);
        Console.WriteLine(emp1.Equals(emp2));

        //2
        City city1 = new City("Odessa", 1000000);
        City city2 = new City("Kyiv", 2500000);

        Console.WriteLine($"{city1.Name} population: {city1.Population}");
        city1 = city1 + 10000;
        city2 = city2 - 20000;
        Console.WriteLine($"{city1.Name} new population: {city1.Population}");
        Console.WriteLine($"{city2.Name} new population: {city2.Population}");

        Console.WriteLine(city2 == city1);
        Console.WriteLine(city2 != city1);
        Console.WriteLine(city1.Equals(city2));

        //3
        //2
        CreditCard cc1 = new CreditCard("1111 1111 1111 1111", 111, 120);
        CreditCard cc2 = new CreditCard("1111 1111 1111 2222", 2000, 100000);

        Console.WriteLine($"{cc1.CardNumber} balance: {cc1.Balance}");
        cc1 = cc1 + 10000;
        cc2 = cc2 - 20000;
        Console.WriteLine($"{cc1.CardNumber} new balance: {cc1.Balance}");
        Console.WriteLine($"{cc2.CardNumber} new balance: {cc2.Balance}");

        Console.WriteLine(cc2 == cc1);
        Console.WriteLine(cc2 != cc1);
        Console.WriteLine(cc1.Equals(cc2));


        //4

        Matrix matrix1 = InitializeRandomMatrix(2, 5);
        Matrix matrix2 = InitializeRandomMatrix(2, 5);
        Matrix matrix3 = InitializeRandomMatrix(5, 2);

        // Додавання матриць
        Matrix sumMatrix = matrix1 + matrix2;

        // Віднімання матриць
        Matrix diffMatrix = matrix1 - matrix2;

        // Множення матриць
        Matrix productMatrix = matrix1 * matrix3;

        // Множення матриці на число
        Matrix scaledMatrix = matrix1 * 2;

        // Перевірка рівності матриць
        bool areEqual = matrix1 == matrix2;

        // Виведення результатів
        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nMatrix 2:");
        PrintMatrix(matrix2);

        Console.WriteLine("\nMatrix 3:");
        PrintMatrix(matrix3);

        Console.WriteLine("\nSum of Matrices:");
        PrintMatrix(sumMatrix);

        Console.WriteLine("\nDifference of Matrices:");
        PrintMatrix(diffMatrix);

        Console.WriteLine("\nProduct of Matrices:");
        PrintMatrix(productMatrix);

        Console.WriteLine("\nScaled Matrix:");
        PrintMatrix(scaledMatrix);

        Console.WriteLine("\nAre Matrices Equal: " + areEqual);

        Console.ReadLine();

    }

    static Matrix InitializeRandomMatrix(int rows, int columns)
    {
        Random random = new Random();
        Matrix matrix = new Matrix(rows, columns);

        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                matrix[i, j] = random.Next(1, 10); // Випадкові значення в діапазоні від 1 до 10
            }
        }

        return matrix;
    }

    static void PrintMatrix(Matrix matrix)
    {
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

