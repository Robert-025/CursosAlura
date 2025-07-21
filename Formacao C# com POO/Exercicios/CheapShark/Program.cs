//using (HttpClient client = new HttpClient())
//{
//	try
//	{
//		string response = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");

//        Console.WriteLine(response);
//	}
//	catch (Exception ex)
//	{
//        Console.WriteLine(ex);
//		throw;
//	} 
//}
try
{
    Console.WriteLine("**** Divisão ****\n");
    Console.Write("Digite o primeiro número: ");
    float num1 = float.Parse(Console.ReadLine());

    Console.Write("\nDigite o segundo número: ");
    float num2 = float.Parse(Console.ReadLine());


    float result = num1 / num2;

    Console.WriteLine($"O resultado de {num1} / {num2} é: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex}");
	throw;
}