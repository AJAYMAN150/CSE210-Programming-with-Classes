public class WritingAssignment : Assignment
{
    private string title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        this.title = title;
    }

    public string GetWritingInformation()
    {
        return $"{title} by {GetStudentName()}";
    }

    // Add this method to access the student's name since it's private in the base class.
    public string GetStudentName()
    {
        return base.GetSummary().Split(" - ")[0];  // Using GetSummary() to extract student name
    }
}
