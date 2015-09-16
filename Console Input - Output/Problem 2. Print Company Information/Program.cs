using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Print_Company_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            
            
            
            
            
                        Console.Write("Compay name: ");
                        string companyName = Console.ReadLine();
                        
                        Console.Write("Compay address: ");
                        string companyAddress = Console.ReadLine();
                        Console.Write("Phone number: ");
                        string phone  = Console.ReadLine();
                        Console.Write("Fax number: ");
                        string fax = Console.ReadLine();
                        Console.Write("Web site: ");
                        string website = Console.ReadLine();
                        Console.Write("Manger first name: ");
                        string mngFirstN  = Console.ReadLine();
                        Console.Write("Manager last name: ");
                        string mngLN  = Console.ReadLine();
                        Console.Write("Manager age: ");
                        string mngAge  = Console.ReadLine();
                        Console.Write("Manaer phone: ");
                        string mngPhone = Console.ReadLine();
                        Console.WriteLine(companyName);
                        
                        if (fax == "")
                        {
                            fax = "(no fax)";
                        }

                        Console.WriteLine("Address: "+companyAddress);
                        Console.WriteLine("Tel. "+phone);
                        Console.WriteLine("Fax: "+fax);
                        Console.WriteLine("Web site: "+website);
                        Console.WriteLine("Manager: "+mngFirstN+" "+mngLN+" (age: "+mngAge+", tel. "+mngPhone+")");
        }
    }
}
