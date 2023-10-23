using task_1;
using System.Numerics;

List<Phone> phoneList = new List<Phone>();
phoneList.Add(new Phone { number = "111-222-333", model = "Sumsung", weight = 111.11 });
phoneList.Add(new Phone { number = "222-333-444", model = "Nokia", weight = 222.22 });
phoneList.Add(new Phone { number = "333-444-555", model = "Huawei", weight = 333.33 });

string[] names = { "Pavel", "Vladimir", "Elena" };
var name = "";
var count = 1;

foreach (Phone phone in phoneList)
{
    Console.WriteLine($"Телефон {count}:" +
        $"\n Номер: {phone.number}" +
        $"\n Модель: {phone.model}" +
        $"\n Вес: {phone.weight}");
    
    phone.ReceiveCall("Pavel");
    phone.GetNumber();
    phone.ReceiveCall("Elena", "999-888-777");
    Console.WriteLine();
    count++;
}

phoneList[1].sendMessage(new string[] { "111-222-333", "222-333-444", "333-444-555" });

Console.WriteLine();

