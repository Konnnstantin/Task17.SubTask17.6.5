using Task17.SubTask17._6._5;
{
    string Types;
    Console.WriteLine("Введите свой тип аккаунта, для расчета ставки - Обычный или Зарплатный");

    if (string.IsNullOrEmpty(Types = Console.ReadLine()))
    {
        throw new ArgumentNullException("Данное поле не может быть пустым", nameof(Types));
    }
    else
    {
        while (Types != "Обычный" && Types != "обычный" && Types != "Зарплатный" && Types != "зарплатный")
        {
            Console.WriteLine("Не правильно введен тип аккаунта, повторите ввод");
            Types = Console.ReadLine();
        };
    }
    Console.Clear();

    var account = new Account() { Type = Types };
    Calculator.CalculateInterest(account);
}
