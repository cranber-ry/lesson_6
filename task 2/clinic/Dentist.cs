namespace task_2.clinic
{
    public class Dentist : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Лечит дантист");
        }
    }
}
