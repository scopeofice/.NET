
namespace EMP;

public class SalesManager : Employee{
    public double HRA{get;set;}
    public double totalSal=0;
    public SalesManager(int id, string fname,string lname, string email, double salary, double hra):base( id,  fname, lname, email, salary){
        this.HRA=hra;
        totalSal=base.salary+this.HRA;
    }

    public override double CalculateSal(){
        return this.totalSal;
    }
    public override string ToString()
    {
        return base.ToString()+" HRA : "+this.HRA+" Total Salary : "+this.totalSal;
    }

}