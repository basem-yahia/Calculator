
using System.Security.Cryptography.X509Certificates;

namespace Calculator;

public  class Program
{
     static void Main(string[] args)
    {
    }

    public static double cal(double n1, double n2, string op)
    {

        //return op switch
        //{
        //    "+" => n1 +n2,
        //    "-" => n1 -n2,
        //    "*" => n1 * n2,
        //    "/" => n2==0 ?throw new InvalidOperationException(op) : n1/n2,
        //    _=> throw new InvalidOperationException(op)

        //};



        switch (op)
        {
            case "+":
                return n1 + n2;

            case "-":
                return n1 - n2;

            case "*":
                return n1 * n2;
                

            case "/":
                if (n2 == 0)
                    throw new InvalidOperationException("no valid");
                return n1 / n2;


            default:
                throw new InvalidOperationException("non valid opeation");
        }


    }
            
         
}
