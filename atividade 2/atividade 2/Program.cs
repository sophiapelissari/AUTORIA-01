int temp;
Console.WriteLine("Digite a temperatura do dia (em graus Celsius): ");
float temperatura = float.Parse(Console.ReadLine());
//lendo a temperatura dada 
if (temperatura < 20 || temperatura > 30)
{
    Console.WriteLine("Temperatura fora da faixa confortável! ;(");
}
else
{
    Console.WriteLine("Temperatura confortável ;)");
}