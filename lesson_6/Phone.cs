namespace task_1
{
    internal class Phone
    {
        public string number;
        public string model;
        public double weight;

        public Phone(string number, string model, double weight) : this(number, model)
        {

        }

        public Phone(string number, string model)
        {

        }

        public Phone() { }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public void ReceiveCall(string name, string number)
        {
            Console.WriteLine($"Звонит {name} с номера {number}");
        }

        public string GetNumber()
        {
            return number;
        }

        public void sendMessage(string[] phoneNumbers)
        {
            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine($"Данное сообщение будет отправлено номеру телефона {phoneNumber}");
            }
        }

    }
}
