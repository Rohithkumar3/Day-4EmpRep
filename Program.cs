// See https://aka.ms/new-console-template for more information


using ConAppTwo;

List<Employee> employees = new List<Employee>()
{
    new Employee() {Id=1,Name="Rohith",Designation="Manager",Doj=new DateTime(day:12,month:11,year:2023)},
    new Employee() {Id=2,Name="Sam",Designation="Tester",Doj=new DateTime(day:02,month:12,year:2022)},
    new Employee() {Id=3,Name="Nikhil",Designation="Developer",Doj=new DateTime(day:16,month:08,year:2024)},
    new Employee() {Id=4,Name="Kamal",Designation="Manager",Doj=new DateTime(day:10,month:01,year:2024)}
};
Console.WriteLine("ID\t Name \t Designation \t Date of Joining");
foreach(Employee emp in employees)
{
    Console.Write(emp.Id+"\t");
    Console.Write(emp.Name+"\t ");
    Console.Write(emp.Designation+"\t \t");
    Console.Write(emp.Doj.ToLongDateString());
    Console.WriteLine("\n");
}
