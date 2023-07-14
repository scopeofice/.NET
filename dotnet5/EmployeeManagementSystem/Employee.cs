
namespace EMP;

public class Employee{
    public int id {get;set;}=0;
    public string firstName {get;set;}=string.Empty;
    public string lastName {get;set;}=string.Empty;
    public string email {get;set;}=string.Empty;
    // public DateTime dateOfJoing {get;set;}
    public double salary {get;set;}=0;

    public Employee(){}
    public Employee(int id, string fname,string lname, string email, double salary){
        this.id=id;
        this.firstName=fname;
        this.lastName=lname;
        this.email=email;
        // this.dateOfJoing=joining;
        this.salary=salary;
    }
    public virtual double CalculateSal(){
        return this.salary;
    }
    
    public override string ToString()
    {
        return base.ToString()+" "+string.Format("Id : {0}  First Name : {1}  Last Name : {2} Email : {3}   Salary : {4} ",id,firstName,lastName,email,salary);
    }

}