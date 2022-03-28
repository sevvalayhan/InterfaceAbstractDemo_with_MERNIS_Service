using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapter;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
           customerManager.Save(new Customer { CustomerId=1,FirstName="ayşe",LastName="yılmaz",DateOfBirth=new DateTime(2003,7,11),NationalityId="754143545"});
            //Mernis sistemi eklendiği için ancak gerçek bir insanın adı soyadı , doğum tarihi ve tc kimlik numarası kullanıldığında çalışır. 


            Console.ReadLine();
        
        }
    }
}
