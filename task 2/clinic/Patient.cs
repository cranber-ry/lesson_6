namespace task_2.clinic
{
    internal class Patient
    {
        public string name;
        public string surname;
        public int age;
        private Doctor doctor;

        public Patient(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void ChoiceDoctor(Treatment_plan plan)
        {
            if (plan.code == 1)
            {
                doctor = new Surgeon();
                doctor.Heal();
            }
            else if (plan.code == 2)
            {

                doctor = new Dentist();
                doctor.Heal();
                
            }
            else
            {
                doctor = new Therapist();
                doctor.Heal();
            }
        }

        public override string ToString()
        {
            return $"Пациент: {name} {surname}, возраст: {age} лет";
        }

    }
}
