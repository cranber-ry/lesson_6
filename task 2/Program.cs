using task_2.clinic;

internal class Program
{
    private static void Main(string[] args)
    {
        Patient patient = new Patient("Иван", "Иванов", 30);
        var plan = new Treatment_plan(1);
        Console.WriteLine($"{patient}");
        patient.ChoiceDoctor(plan);
    }
}