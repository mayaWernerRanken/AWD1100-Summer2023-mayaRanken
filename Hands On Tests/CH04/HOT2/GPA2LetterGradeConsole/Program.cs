

Console.Write("Enter GPA: ");
double gradeNum = Convert.ToDouble(Console.ReadLine());

if  (gradeNum > 3.2 && gradeNum <= 4.0 )
{
    Console.Write("\nYour letter grade is: A\n");
}
else if (gradeNum > 2.5 && gradeNum <= 3.2)
{
    Console.Write("\nYour letter grade is: B");
}
else if (gradeNum > 1.5 && gradeNum <= 2.5)
{
    Console.Write("\nYour letter grade is: C\n");
}
else if (gradeNum > 0.0 && gradeNum <= 1.5)
{
    Console.Write("\nYour letter grade is: D\n");
}
else if (gradeNum == 0.0)
{
    Console.Write("\nYour letter grade is: F\n");
}