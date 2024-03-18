void MenuPrincipal()
{
    Console.WriteLine("---------- LISTA COM OS EXERCÍCIOS ----------\n");
    Console.WriteLine("[1] Exercicio 1 \n[2] Exercicio 2 \n[3] Exercicio 3\n[4] Exercicio 4 \n[5] Exercicio 5\n");
    Console.Write("Escolha o exercícios que deseja ver: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine())!;
    switch (opcaoEscolhida)
    {
        case 0: 
            Console.WriteLine("Saindo do programa...");
            Thread.Sleep(1500);
            break;
        case 1:
            Console.Clear();
            Console.WriteLine("QUESTÃO 1 ESCOLHIDA: \n");
            Exercicio1();
            VoltarParaOMenu();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("QUESTÃO 2 ESCOLHIDA: \n");
            Exercicio2();
            VoltarParaOMenu();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("QUESTÃO 3 ESCOLHIDA: \n");
            Console.WriteLine("[a] Alternativa A \n[b] Alternativa B\n[c] Alternativa C \n[d] Alternativa D" +
                "\n[e] Alternativa E \n[f] Alternativa F");
            Console.Write("Qual alternativa da questão 3 deseja ver: ");
            string alternativa = Console.ReadLine()!.ToLower();
            switch (alternativa)
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("Alternativa 'A' escolhida\n");
                    Exercicio3A();
                    VoltarParaOMenu();
                    break;
                case "b":
                    Console.Clear();
                    Console.WriteLine("Alternativa 'B' escolhida\n");
                    Exercicio3B();
                    VoltarParaOMenu();
                    break;
                case "c":
                    Console.Clear();
                    Console.WriteLine("Alternativa 'C' escolhida\n");
                    Exercicio3C();
                    VoltarParaOMenu();
                    break;
                case "d":
                    Console.Clear();
                    Console.WriteLine("Alternativa 'D' escolhida\n");
                    Exercicio3D();
                    VoltarParaOMenu();
                    break;
                case "e":
                    Console.Clear();
                    Console.WriteLine("Alternativa 'E' escolhida\n");
                    Exercicio3E();
                    VoltarParaOMenu();
                    break;
                case "f":
                    Console.Clear();
                    Console.WriteLine("Alternativa 'F' escolhida\n");
                    Console.WriteLine("Essa opção foi resolvida no site da Gupy por ser uma questão discursiva. ");
                    VoltarParaOMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Voltando para o menu principal...");
                    Thread.Sleep(3000);
                    MenuPrincipal();
                    break;
            }
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Esse exercicio foi resolvido no site por ser uma questão discursiva.");
            VoltarParaOMenu();
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("QUESTÃO 5 ESCOLHIDA: \n");
            Exercicio5();
            VoltarParaOMenu();
            break;
        default:
            Console.WriteLine("Opção inválida, digite uma questão existente.");
            VoltarParaOMenu();
            break;
    }
}
MenuPrincipal();

void VoltarParaOMenu()
{
    Console.Write("\nAperte uma tecla para voltar para o menu principal: ");
    Console.ReadLine();
    Console.WriteLine("\nVoltando para o menu principal...");
    Thread.Sleep(1800);
    Console.Clear();
    MenuPrincipal();
}
void Exercicio1()
{
    // EXERCICIO 1
    Exerc1 tentativa = new Exerc1();
    tentativa.K = 0;
    tentativa.Indice = 13;
    tentativa.Soma = 0;

    tentativa.ResolucaoExercicio1(tentativa.Indice, tentativa.Soma, tentativa.K); // RESPOSTA
}

void Exercicio2()
{
    // EXERCICIO 2
    List<int> numeros = new List<int>() { 0, 1 };
    Console.Write("Até que número deseja ver a sequência da Fibonacci? ");
    int limiteDaFibonacci = int.Parse(Console.ReadLine()!);

    int penultimoNumero = numeros.Count - 2;
    int ultimoNumero = numeros.Count - 1;
    int soma = ultimoNumero + penultimoNumero;

    while (soma <= limiteDaFibonacci)
    {
        soma = penultimoNumero + ultimoNumero;
        if (soma > limiteDaFibonacci)
        {
            break;
        }
        numeros.Add(soma);
        penultimoNumero = ultimoNumero;
        ultimoNumero = soma;
    }
    Console.WriteLine(string.Join(", ", numeros)); // RESPOSTA
}

void Exercicio3A()
{
    // EXERCICIO 3, QUESTÃO A: Seuquência de números ímpares
    // Esse exercício mostra a sequência de números ímpares iniciando do 1
    List<int> numeros = new List<int> { 1, 3, 5, 7 };
    int numeroFaltante = 0;

    for (int i = 0; numeros.Count < 5; i++)
    {
        if (i % 2 == 0)
        {
            continue;
        }
        else
        {
            if (numeros.Contains(i))
            {
                continue;
            }
            else
            {
                numeros.Add(i);
                numeroFaltante = i;
                Console.WriteLine("Número que faltava: " + numeroFaltante);
            }
        }
    }
    Console.WriteLine("A sequência ficou assim: ");
    Console.WriteLine(string.Join(", ", numeros));
}

void Exercicio3B()
{
    // EXERCICIO 3, QUESTÃO B: Dobrando valores
    // Esse exercício está dobrando os valores começando pelo 2

    List<int> numerosDaLista = new List<int>() { 2, 4, 8, 16, 32, 64 };

    int ultimoNumero = numerosDaLista[numerosDaLista.Count - 1];
    int proximoNumero = ultimoNumero * 2;
    numerosDaLista.Add(proximoNumero);
    Console.WriteLine($"O número que faltava era o {proximoNumero}.");
    Console.WriteLine(string.Join(", ", numerosDaLista));
}

void Exercicio3C()
{
    // EXERCICIO 3, QUESTÃO C: Sequência de números elevado ao quadrado
    // Esse exercício faz os números em sequência serem elevados ao quadrado

    List<int> listaDeNumeros = new List<int>() { 0, 1, 4, 9, 16, 25, 36 };
    int limite = listaDeNumeros.Count + 1;

    for (int i = 1; i < limite; i++)
    {
        int quadrado = i * i;
        if (listaDeNumeros.Contains(quadrado))
        {
            continue;
        }
        else
        {
            listaDeNumeros.Add(quadrado);
        }
    }
    int numFaltante = listaDeNumeros[listaDeNumeros.Count - 1];
    Console.WriteLine($"O número que faltava era: {numFaltante}"); //RESPOSTA
    Console.WriteLine(string.Join(", ", listaDeNumeros));
}

void Exercicio3D()
{
    // EXERCICIO 3, QUESTÃO D: Números pares sendo elevados
    // Esse exercício eleva os números pares em sequência ao quadrado, ex: 2, 4, 6 e 8

    List<int> listaDeNumeros = new List<int> { 4, 16, 36, 64 };

    for (int i = 1; listaDeNumeros.Count == 4; i++)
    {
        int numElevado = i * i;
        if (i % 2 == 1)
        {
            continue;
        }
        else
        {
            if (listaDeNumeros.Contains(numElevado))
            {
                continue;
            }
            else
            {
                listaDeNumeros.Add(numElevado);
                Console.WriteLine($"O número que faltava era o {numElevado}.");
            }
        }
        numElevado++;
    }

    int numFaltante = listaDeNumeros[listaDeNumeros.Count - 1];
    Console.WriteLine(string.Join(", ", listaDeNumeros)); // RESPOSTA

}

void Exercicio3E()
{
    // EXERCICIO 3, QUESTÃO E: Fibonacci

    List<int> numeros = new List<int>() { 1, 1, 2, 3, 5, 8 };
    int limite = numeros.Count + 1;
    int ultimoNumero = numeros[numeros.Count - 1];
    int penultimoNumero = numeros[numeros.Count - 2];
    int proximoNumero = ultimoNumero + penultimoNumero;

    for (int i = 0; numeros.Count < limite; i++)
    {
        proximoNumero = ultimoNumero + penultimoNumero;
        if (numeros.Contains(proximoNumero))
        {
            continue;
        }
        else
        {
            numeros.Add(proximoNumero);
            Console.WriteLine($"O número que faltava era o {proximoNumero}.");
        }
    }
    Console.Write("A lista de números ficou assim: ");
    Console.WriteLine(string.Join(", ", numeros)); // RESPOSTA

}

// EXERCICIO 3, QUESTÃO F: Não consegui entender a lógica da sequência numérica.

void Exercicio5()
{
    // EXERCICIO 5

    Console.WriteLine("----- Invertendo string -----".ToUpper());
    Console.Write("Digite a palavra que deseja ver: ");
    string palavra = Console.ReadLine();
    int quantidadeDeLetras = palavra.Count() - 1;

    Console.Write("\nA palavra escolhida ficou assim:");
    foreach (var letra in palavra)
    { 
        Console.Write(palavra[quantidadeDeLetras]);
        quantidadeDeLetras--;
    }
    Console.WriteLine("");
}
