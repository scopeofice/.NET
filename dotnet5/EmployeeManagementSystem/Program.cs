using Tax;
using Despatcher;
using EMP;

Console.WriteLine("Employee Managment System");

List<Employee> emp=new List<Employee>();

TaxtationLib tax=new TaxtationLib();
TaxOperation payTax=new TaxOperation(tax.CalculateTax);

Console.WriteLine(payTax(500));


int input=0;

do{
    Console.WriteLine("Enter choice");
    Console.WriteLine("1.Add Employee");
    Console.WriteLine("2.Remove Employee");
    Console.WriteLine("3.Display Employee");
    Console.WriteLine("4.Calculate Employee salary");
    Console.WriteLine("0.Exit");
     input=int.Parse(Console.ReadLine());
    switch(input){
        //  id,  fname, lname,  email,  salary,  hra
        case 1:Console.WriteLine("Enter : id, first name, last name, email, salary, HRA");
        Employee sEmp=new SalesManager(int.Parse(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        emp.Add(sEmp);
        Console.WriteLine("Employee added");
        break;
        case 2:Console.WriteLine("Enter emp id");
            int empid = int.Parse(Console.ReadLine());
            int i = 0;
            foreach (Employee e in emp) {
                if (e.id == empid) {
                    emp.RemoveAt(i);
                }
                i++;
            }
            Console.WriteLine("Employee deleted");
            break;
        case 3: foreach(Employee e in emp ){
            Console.WriteLine(e);
        }
        break;
        case 4:Console.WriteLine("Enter Employee id");
        int id=int.Parse(Console.ReadLine());
        foreach (Employee e in emp){
            if (e.id == id){
                Console.WriteLine(e.ToString()+" Salary after Tax deduction : "+payTax(e.CalculateSal()));
            }
        }
        Console.WriteLine();
        break;
        default:Console.WriteLine("Invalid input");
        break;
    }
    
}while(input!=0);





