// CGPA Calculator Console Application

Console.WriteLine("---------------------");
Console.WriteLine("---CGPA CALCULATOR---");
Console.WriteLine("---------------------");

string endLoop = "end";

// Declaration of Lists
List<string> courses = new List<string>(){};
List<string> grades = new List<string>{};
List<int> points = new List<int>{};
List<int> units = new List<int> {};

for (; ;)
{   
    // Read course name
    Console.WriteLine("Enter course details or type 'end' to end input.");
    Console.Write("Course Name: ");
    string course = Console.ReadLine();

    // End loop
    if (course == endLoop) 
    {
       break; 
    }
    courses.Add(course);

    // Read course grade
    Console.Write("Grade (A - F): ");
    string grade = Console.ReadLine();

    // Converting grades to points
    if(grade == "A")
    {
        points.Add(5);
    }
    else if(grade == "B")
    {
        points.Add(4);
    }
    else if(grade == "C")
    {
        points.Add(3);
    }
    else if(grade == "D")
    {
        points.Add(2);
    }
    else if(grade == "E")
    {
        points.Add(1);
    }
    else if(grade == "F")
    {
        points.Add(0);
    }
    else
    {
        Console.WriteLine("Invalid Grade");
        break;
    }

    // Read course unit
    Console.Write("Course Unit: ");
    int unit = Convert.ToInt32(Console.ReadLine());
    units.Add(unit);
}


// Converting list to arrays
int[] units2 = units.ToArray();
int[] points2 = points.ToArray();

int[] products = new int[units2.Length];

// Lopp to add values to the products array
for(int i = 0; i < units2.Length; i++)
{
    products[i] = (units2[i] * points2[i]);
}

// GPA Calculation
double totalUnits = units.Sum();
double totalProducts = products.Sum();
double gpa = totalProducts / totalUnits;

// Print Result
Console.WriteLine("---------------------");
Console.WriteLine("YOUR RESULT: ");

if (gpa < 1.5)
{
    Console.WriteLine($"Class of Degree is PASS\nGPA = {gpa}");
}
else if ((gpa >= 1.5) && (gpa <= 2.39))
{
    Console.WriteLine($"Class of Degree is THIRD-CLASS\nGPA = {gpa}");
}
else if((gpa >= 2.40) && (gpa <= 3.49))
{
    Console.WriteLine($"Class of Degree is SECOND-CLASS (LOWER)\nGPA = {gpa}");
}
else if((gpa >= 3.5) && (gpa <= 4.49))
{
    Console.WriteLine($"Class of Degree is SECOND-CLASS (UPPER)\nGPA = {gpa}");
}
else if ((gpa >= 4.5) && (gpa <= 5.00))
{
    Console.WriteLine($"Class of Degree is FIRST-CLASS\nGPA = {gpa}");
}
Console.WriteLine("---------------------");
