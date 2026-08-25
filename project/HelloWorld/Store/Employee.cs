namespace Store;
#nullable disable
internal abstract class Employee
{
    // fields
    protected decimal _baseSalary;
    //properties
     public string Name { get; set; }
    public decimal BaseSalary
    {
        get { return _baseSalary; }
        set { _baseSalary = value; }
    }
    public  Employee(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }
    public virtual decimal CalculateSalary()
    {
        return BaseSalary;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($" Name: {Name},Salary: {CalculateSalary()}");
    }
}

internal class Manager : Employee
{
    public int TeamSize { get; set; }
    public Manager(string name, decimal baseSalary, int teamSize)
        : base(name : name,baseSalary:baseSalary)
    {
        TeamSize = teamSize;
    }
    public override decimal CalculateSalary()
    {
        return (BaseSalary + (TeamSize * 200));
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"teamsize:{TeamSize}");
    }
}
internal class SalesPerson : Employee
{
    public decimal SalesAmount { get; set; }
    public SalesPerson(string name, decimal baseSalary, decimal salesAmount)
        :base(name:name, baseSalary: baseSalary)
    {
        SalesAmount = salesAmount;
    }
    public override decimal CalculateSalary()
    {
        return BaseSalary + ((SalesAmount *5)/100);
    }
}

    