
    Console.ForegroundColor = ConsoleColor.Blue;
      
    Console.WriteLine("informe seu peso");
    float.TryParse(Console.ReadLine(), out float peso);
    Console.ResetColor();
    
    Console.WriteLine("informe sua altura(em metros)");
    float.TryParse(Console.ReadLine(), out float altura);
    
    float imc = peso/(altura*altura);
    Console.WriteLine($"seu IMC é: {imc}");
    Console.WriteLine("você tem alguma dessas doenças?\n\n diabetes\n Artrite\n Problemas cardíacos\n Obesidade\n Dores nas costas\n Ansiedade\n Estresse");
    string doeca = Console.ReadLine().ToLower();
    
    string[] doenca = new string[] {"diabetes", "Artrite", "Problemas cardíacos","Obesidade", "Dores nas costas", "Ansiedade", "Estresse"};
    
    if(doeca == doenca[0])
    {
        Console.WriteLine("\nexercícios recomendados:\n -Caminhadas rápidas\n -Natação\n -Treinamento de resistência (com pesos leves a moderados)\n -Exercícios aeróbicos de baixa intensidade\n -Yoga (ajuda no controle do estresse e glicemia)");
    }
    
    else if(doeca ==doenca[1])
    {
        Console.WriteLine("\nexercícios recomendados:\n -Hidroginástica\n -Caminhadas leves\n -Ciclismo (com baixa resistência)\n -Alongamentos e yoga\n -Pilates (fortalecimento sem sobrecarga articular)");
    }
    
    else if(doeca ==doenca[2])
    {
        Console.WriteLine("\nexercícios recomendados:\n -Caminhadas moderadas\n -Bicicleta leve\n -Natação\n -Exercícios de alongamento\n -Tai Chi (uma forma de exercício suave que também ajuda com equilíbrio)");
    }
    
    else if(doeca ==doenca[3])
    {
        Console.WriteLine("\nexercícios recomendados:\n -Caminhadas e caminhadas rápidas\n -Natação\n -Exercícios em bicicleta ergométrica\n -Exercícios aeróbicos de baixo impacto\n -Hidroginástica");
    }
    
    else if(doeca ==doenca[4])
    {
        Console.WriteLine("\nexercícios recomendados:\n -Caminhada em ritmo leve\n -Natação ou hidroginástica\n -Yoga com foco em alongamento e fortalecimento do núcleo\n -Pilates (fortalecimento do núcleo)\n -Exercícios de alongamento e mobilidade");
    }
    
    else if(doeca ==doenca[5])
    {
        Console.WriteLine("\nexercícios recomendados:\n -Yoga\n -Tai Chi\n -Meditação guiada (combinada com alongamentos)\n -Caminhadas ao ar livre\n -Dança (para liberar endorfina)");
    }
    
    else if (doeca ==doenca[6])
    {
        Console.WriteLine("\nexercícios recomendados:\n -Yoga\n -Tai Chi\n -Meditação guiada (combinada com alongamentos)\n -Caminhadas ao ar livre\n -Dança (para liberar endorfina)");
    }
    
    