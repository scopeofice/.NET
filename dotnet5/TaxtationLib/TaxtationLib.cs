namespace Tax;

public class TaxtationLib
{

    public double CalculateTax(double salary){
        
        double sal=salary;
        //payIncomeTax
        sal=sal-sal*0.15;

        //payServiceTax
        sal=sal-sal*0.2;

        //professionalTax
        sal=sal-sal*0.1;

        //PaySalesTax
        sal=sal-sal*0.03;

        return sal;

    }
}
