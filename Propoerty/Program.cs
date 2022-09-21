


using Propoerty;

student s1 = new student();
student s2 = new student();
student s3 = new student();
student max = new student();


Console.WriteLine("enter name");
s1.name = (Console.ReadLine());
Console.WriteLine("enter number");
s1.number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter name");
s2.name = (Console.ReadLine());
Console.WriteLine("enter number");
s2.number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter name");
s3.name = (Console.ReadLine());
Console.WriteLine("enter number");
s3.number = Convert.ToInt32(Console.ReadLine());

max = s1;
if (s2.number > max.number)
{
	max = s2;
}
if (s3.number > max.number)
{
	max = s3;
}

Console.WriteLine("student name is:" + max.name);
Console.WriteLine("number is:" + max.number);
