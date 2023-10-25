Console.WriteLine("## Date Time ##\n");

DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje : {hoje}\n");
// Extrair informções 
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);


// Adicionar Valores

Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(2));
Console.WriteLine(hoje.AddHours(3));
Console.WriteLine(hoje.AddYears(10));


// Data especifica

DateTime dataHoje = new DateTime(2000, 05, 02);

Console.WriteLine(dataHoje);


// Data e hora

DateTime dataHoraHoje = new DateTime(2000, 05, 02,21,10,30);

Console.WriteLine(dataHoraHoje);