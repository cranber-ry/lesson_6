namespace task_2.clinic
{
    public class Therapist : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Лечит терапевт");
        }
    }
}
