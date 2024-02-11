// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concrete;
using Intro.Entities;

Console.WriteLine("Hello, World!");


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "123456789";
customer1.FirstName = "Muhammet";
customer1.LastName = "Demiralay";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "123456789";
customer2.FirstName = "Ali";
customer2.LastName = "Demiralay";
customer2.CustomerNumber = "123456";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Abc";
customer3.CustomerNumber = "12S3456";
customer3.TaxNumber = "123456";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer3.Id = 4;
customer3.Name = "Abc";
customer3.CustomerNumber = "123456";
customer3.TaxNumber = "123456";

CourseManager courseManager = new(new CourseDal());

List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " - " + courses[i].Price + " - " + courses[i].Description);

}


int number1 = 10;
int number2 = 20;
number1 = number2;
Console.WriteLine(number1);



string[] cities1 = { "Ankara", "İstanbul", "kocaeli" };

string[] cities2 = { "Sakarya", "Denizli", "Mersin" };
cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);

//Polymorphism
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
foreach (var customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

