using System;

class StudentExam
{
    static void Main()
    {
        string studentName = "Pavithra";
        int totalMarks = 0;
        bool isUpdated = false;

        Console.WriteLine($"Before Update: {studentName}, Marks: {totalMarks}, Updated: {isUpdated}");

        // Ref Example — Must initialize before calling
        UpdateMarks(ref totalMarks, ref isUpdated);

        Console.WriteLine($"After Update: {studentName}, Marks: {totalMarks}, Updated: {isUpdated}");

        // Out Example — Optional to initialize before
        string grade = "Unknown";  // Initialized, but will be overwritten
        bool isPassed = false;     // Initialized, but will be overwritten

        Console.WriteLine($"Before Result: Grade: {grade}, Passed: {isPassed}");

        GetResult(totalMarks, out grade, out isPassed); // grade, isPassed will be changed

        Console.WriteLine($"After Result: Grade: {grade}, Passed: {isPassed}");

        // TryParse Example
        string inputMarks = "95a";
        int parsedMarks = -999;    // initialized before calling
        bool parseSuccess;

        ParseMarks(inputMarks, out parsedMarks, out parseSuccess);

        if (parseSuccess)
        {
            Console.WriteLine($"Parsed Marks: {parsedMarks}");
        }
        else
        {
            Console.WriteLine("❌ Invalid input for marks.");
        }
    }

    static void UpdateMarks(ref int marks, ref bool updated)
    {
        marks = 85;
        updated = true;
    }

    static void GetResult(int marks, out string grade, out bool passed)
    {
        if (marks >= 90)
            grade = "A+";
        else if (marks >= 75)
            grade = "A";
        else if (marks >= 60)
            grade = "B";
        else
            grade = "C";

        passed = marks >= 35;
    }

    static void ParseMarks(string input, out int marks, out bool success)
    {
        success = int.TryParse(input, out marks);
        if (!success)
        {
            marks = 0; // Even if initialized before, overwritten here
        }
    }
}