double IMC;

Console.Write("Altura (m)...: ");
string alturaDigitada = Console.ReadLine()!;

double altura = Convert.ToDouble(alturaDigitada);

Console.Write("Peso (kg)...: ");
string pesoDigitado = Console.ReadLine()!;

double peso = Convert.ToDouble(pesoDigitado);

IMC = peso/Math.Pow(altura, 2);

Console.WriteLine($"\nIMC:{IMC:N2} kg/m²");