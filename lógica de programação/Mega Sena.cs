using System;
class HelloWorld {
	static void Main() {
		Console.WriteLine("Sorteio");
		Random aleatorio = new Random();
		int resultpremio = aleatorio.Next(100000, 10000000);
		Console.Write($"Valor do prêmio {resultpremio}\n");
		
		Console.Write($"----------------Tabela de ganhador-----------------\n 1º lugar, com 6 dezenas acertadas - {resultpremio*0.75} \n 2º lugar, com 5 dezenas acertadas - {resultpremio*0.15}\n 3º lugar, com 4 dezenas acertadas - {resultpremio*0.10}\n----------------------------------------\n");
		
		//Console.Write("escreva o valor do prêmio ");
		//float premio = float.Parse(Console.ReadLine());
		
		
		//float resultpremio;
		
		//Console.Write($"----------------Tabela de ganhador-----------------\n 1º lugar, com 6 dezenas acertadas - {premio*0.75} \n 2º lugar, com 5 dezenas acertadas - {premio*0.15}\n 3º lugar, com 4 dezenas acertadas - {premio*0.10}\n----------------------------------------\n");
		
		
		Console.Write("escreva a quantidade de jogos ");
		int qnt = int.Parse(Console.ReadLine());
		
		Console.Write("Quantidade de dezenas ");
		int deze = int.Parse(Console.ReadLine());
		
		
		while (deze<6 || deze>15)
		{
			Console.Write("informe outro valor: ");
			deze = int.Parse(Console.ReadLine());
			Console.Clear();
		}


		Random sorte =new Random();
		int sorteio = sorte.Next(1, 61);


		for(int j = 1; j <= qnt; j++)
		{

			if(sorteio<10)
			{
				Console.Write($" {sorteio:D2}");
			}
			else
			{
				Console.Write($" {sorteio:D2}");
			}



			for(int i = 1; i<deze; i++)

			{
				sorteio = sorte.Next(1, 61);
				if(sorteio<10)
				{
					Console.Write($"-{sorteio:D2}");
				}
				else {
					Console.Write($"-{sorteio:D2}");
				}

			}
			
			Console.WriteLine("\n");
	
			
		}
		/*Console.WriteLine("informe quantas dezenas você acertou");
			int infordezen = int.Parse(Console.ReadLine());
			
			if( infordezen == 6)
			{
			    resultpremio = premio*(75/100f);
			Console.Write($"você acertou {infordezen}, seu prêmio será de: {resultpremio}");
			}*/
	}
}
