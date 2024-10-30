using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace ProjetoQuestoesCSharp
{
    // Classe principal do programa, responsável pelo menu e pela execução das questões
    class Program
    {
        static void Main(string[] args)
        {
            // Menu Inicial: permite ao usuário escolher uma questão ou sair do programa
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha um número de 1 a 100 para selecionar a questão que deseja executar ou digite 0 para sair:");

                // Converte a entrada do usuário para um número inteiro
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break; // Sai do programa se o usuário digitar 0
                }

                // Estrutura switch para escolher a questão com base na opção selecionada
                switch (opcao)
                {
                    case 1:
                        Questao01();
                        break;
                    case 2:
                        Questao02();
                        break;
                    case 3:
                        Questao03();
                        break;
                    case 4:
                        Questao04();
                        break;
                    case 5:
                        Questao05();
                        break;
                    case 6:
                        Questao06();
                        break;
                    case 7:
                        Questao07();
                        break;
                    case 8:
                        Questao08();
                        break;
                    case 9:
                        Questao09();
                        break;
                    case 10:
                        Questao10();
                        break;
                    case 11:
                        Questao11();
                        break;
                    case 12:
                        Questao12();
                        break;
                    case 13:
                        Questao13();
                        break;
                    case 14:
                        Questao14();
                        break;
                    case 15:
                        Questao15();
                        break;
                    case 16:
                        Questao16();
                        break;
                    case 17:
                        Questao17();
                        break;
                    case 18:
                        Questao18();
                        break;
                    case 19:
                        Questao19();
                        break;
                    case 20:
                        Questao20();
                        break;
                    case 21:
                        Questao21();
                        break;
                    case 22:
                        Questao22();
                        break;
                    case 23:
                        Questao23();
                        break;
                    case 24:
                        Questao24();
                        break;
                    case 25:
                        Questao25();
                        break;
                    case 26:
                        Questao26();
                        break;
                    case 27:
                        Questao27();
                        break;
                    case 28:
                        Questao28();
                        break;
                    case 29:
                        Questao29();
                        break;
                    case 30:
                        Questao30();
                        break;
                    case 31:
                        Questao31();
                        break;
                    case 32:
                        Questao32();
                        break;
                    case 33:
                        Questao33();
                        break;
                    case 34:
                        Questao34();
                        break;
                    case 35:
                        Questao35();
                        break;
                    case 36:
                        Questao36();
                        break;
                    case 37:
                        Questao37();
                        break;
                    case 38:
                        Questao38();
                        break;
                    case 39:
                        Questao39();
                        break;
                    case 40:
                        Questao40();
                        break;
                    case 41:
                        Questao41();
                        break;
                    case 42:
                        Questao42();
                        break;
                    case 43:
                        Questao43();
                        break;
                    case 44:
                        Questao44();
                        break;
                    case 45:
                        Questao45();
                        break;
                    case 46:
                        Questao46();
                        break;
                    case 47:
                        Questao47();
                        break;
                    case 48:
                        Questao48();
                        break;
                    case 49:
                        Questao49();
                        break;
                    case 50:
                        Questao50();
                        break;
                    case 51:
                        Questao51();
                        break;
                    case 52:
                        Questao52();
                        break;
                    case 53:
                        Questao53();
                        break;
                    case 54:
                        Questao54();
                        break;
                    case 55:
                        Questao55();
                        break;
                    case 56:
                        Questao56();
                        break;
                    case 57:
                        Questao57();
                        break;
                    case 58:
                        Questao58();
                        break;
                    case 59:
                        Questao59();
                        break;
                    case 60:
                        Questao60();
                        break;
                    case 61:
                        Questao61();
                        break;
                    case 62:
                        Questao62();
                        break;
                    case 63:
                        Questao63();
                        break;
                    case 64:
                        Questao64();
                        break;
                    case 65:
                        Questao65();
                        break;
                    case 66:
                        Questao66();
                        break;
                    case 67:
                        Questao67();
                        break;
                    case 68:
                        Questao68();
                        break;
                    case 69:
                        Questao69();
                        break;
                    case 70:
                        Questao70();
                        break;
                    case 71:
                        Questao71();
                        break;
                    case 72:
                        Questao72();
                        break;
                    case 73:
                        Questao73();
                        break;
                    case 74:
                        Questao74();
                        break;
                    case 75:
                        Questao75();
                        break;
                    case 76:
                        Questao76();
                        break;
                    case 77:
                        Questao77();
                        break;
                    case 78:
                        Questao78();
                        break;
                    case 79:
                        Questao79();
                        break;
                    case 80:
                        Questao80();
                        break;
                    case 81:
                        Questao81();
                        break;
                    case 82:
                        Questao82();
                        break;
                    case 83:
                        Questao83();
                        break;
                    case 84:
                        Questao84();
                        break;
                    case 85:
                        Questao85();
                        break;
                    case 86:
                        Questao86();
                        break;
                    case 87:
                        Questao87();
                        break;
                    case 88:
                        Questao88();
                        break;
                    case 89:
                        Questao89();
                        break;
                    case 90:
                        Questao90();
                        break;
                    case 91:
                        Questao91();
                        break;
                    case 92:
                        Questao92();
                        break;
                    case 93:
                        Questao93();
                        break;
                    case 94:
                        Questao94();
                        break;
                    case 95:
                        Questao95();
                        break;
                    case 96:
                        Questao96();
                        break;
                    case 97:
                        Questao97();
                        break;
                    case 98:
                        Questao98();
                        break;
                    case 99:
                        Questao99();
                        break;
                    case 100:
                        Questao100();
                        break;
                    default:
                        Console.WriteLine("Questão não encontrada. Verifique se digitou uma questão válida para o programa.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                Console.ReadKey(); // Aguarda que o usuário pressione uma tecla para voltar ao menu
            }
        }

        // Nível Básico 1 - 25.
        // Questão 1: Criação de um objeto da classe Produto com propriedades Nome e Preco
        static void Questao01()
        {
            Console.Clear();
            Console.WriteLine("Questão 1: Criando um objeto da classe Produto");

            // Instanciando um objeto da classe Produto com nome e preço
            Produto produto = new Produto("Fone ANC", 400.00m);

            // Exibindo os valores do objeto Produto
            Console.WriteLine($"Nome do Produto: {produto.Nome}");
            Console.WriteLine($"Preço do Produto: {produto.Preco}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 2: Instancia um novo objeto da classe Produto e exibe seus valores
        static void Questao02()
        {
            Console.Clear();
            Console.WriteLine("Questão 2: Instanciar um objeto da classe Produto e exibir valores");

            // Instancia um novo Produto com nome e preço
            Produto produto = new Produto("Nebulizador Portátil", 70.00m);

            // Exibe os valores do Produto
            Console.WriteLine($"Nome do Produto: {produto.Nome}");
            Console.WriteLine($"Preço do Produto: R${produto.Preco:F2}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 3: Método que soma dois números inteiros fornecidos pelo usuário
        static void Questao03()
        {
            Console.Clear();
            Console.WriteLine("Questão 3: Soma de dois números inteiros");

            // Solicita dois números inteiros e realiza a soma
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 4: Verifica se um número é par ou ímpar
        static void Questao04()
        {
            Console.Clear();
            Console.WriteLine("Questão 4: Verificação de número par ou ímpar");
            Console.WriteLine("Digite um número: ");

            int numero = int.Parse(Console.ReadLine());

            // Lógica para verificar se o número é par ou ímpar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é par.");
            }
            else
            {
                Console.WriteLine($"{numero} é ímpar.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 5: Converte um valor em metros para centímetros
        static void Questao05()
        {
            Console.Clear();
            Console.WriteLine("Questão 5: Conversão de metros para centímetros");
            Console.WriteLine("Digite um valor em metros: ");

            double metros = double.Parse(Console.ReadLine());
            double centimetros = metros * 100; // 1 metro = 100 centímetros

            Console.WriteLine($"{metros} metros equivalem a {centimetros} centímetros.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 6: Verifica se uma pessoa é maior de idade com base na idade
        static void Questao06()
        {
            Console.Clear();
            Console.WriteLine("Questão 6: Verificação de maioridade");
            Console.WriteLine("Digite a idade: ");

            int idade = int.Parse(Console.ReadLine());

            // Verifica se a idade é maior ou igual a 18 anos
            if (idade >= 18)
            {
                Console.WriteLine("A pessoa é maior de idade.");
            }
            else
            {
                Console.WriteLine("A pessoa é menor de idade.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 7: Calcula a área de um círculo com base no raio fornecido
        static void Questao07()
        {
            Console.Clear();
            Console.WriteLine("Questão 7: Cálculo da área de um círculo");
            Console.WriteLine("Digite o valor do raio: ");

            double raio = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(raio, 2); // Fórmula da área do círculo: π * raio²

            Console.WriteLine($"A área do círculo com raio {raio} é {area:F2}.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 8: Exibe a tabuada de um número fornecido
        static void Questao08()
        {
            Console.Clear();
            Console.WriteLine("Questão 8: Exibição da tabuada de um número");
            Console.WriteLine("Digite um número: ");

            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 1; i <= 10; i++) // Loop de 1 a 10 para calcular a tabuada
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 9: Calcula a soma de todos os números de 1 a N
        static void Questao09()
        {
            Console.Clear();
            Console.WriteLine("Questão 9: Soma de todos os números de 1 a N");
            Console.WriteLine("Digite o valor de N: ");

            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            // Loop que soma cada número de 1 até o valor de N
            for (int i = 1; i <= n; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma de todos os números de 1 a {n} é: {soma}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 10: Converte temperatura de Celsius para Fahrenheit
        static void Questao10()
        {
            Console.Clear();
            Console.WriteLine("Questão 10: Conversão de Celsius para Fahrenheit");
            Console.WriteLine("Digite a temperatura em Celsius: ");

            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32; // Fórmula de conversão de Celsius para Fahrenheit

            Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 11: Verifica se um número é positivo, negativo ou zero
        static void Questao11()
        {
            Console.Clear();
            Console.WriteLine("Questão 11: Verificar se uma string é vazia ou nula");

            // Solicita ao usuário que insira uma string
            Console.Write("Digite uma string (ou deixe em branco): ");
            string input = Console.ReadLine();

            // Verifica se a string é nula ou vazia
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("A string é vazia ou nula.");
            }
            else
            {
                Console.WriteLine("A string possui valor.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao12()
        {
            Console.Clear();
            Console.WriteLine("Questão 12: Exibir todos os números pares entre 1 e 50");

            for (int i = 1; i <= 50; i++)
            {
                // Verifica se o número é par
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao13()
        {
            Console.Clear();
            Console.WriteLine("Questão 13: Receber três números e retornar o maior");

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = Math.Max(num1, Math.Max(num2, num3));

            Console.WriteLine($"O maior número entre {num1}, {num2}, e {num3} é: {maior}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao14()
        {
            Console.Clear();
            Console.WriteLine("Questão 14: Inverter uma string");

            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine("String invertida: " + new string(charArray));
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void Questao15()
        {
            Console.Clear();
            Console.WriteLine("Questão 15: Verificar se uma pessoa pode votar");

            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = DateTime.Now.Year - anoNascimento;

            if (idade >= 18)
            {
                Console.WriteLine("Você pode votar.");
            }
            else
            {
                Console.WriteLine("Você não pode votar.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void Questao16()
        {
            Console.Clear();
            Console.WriteLine("Questão 16: Verificar se um número é positivo ou negativo");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao17()
        {
            Console.Clear();
            Console.WriteLine("Questão 17: Calcular a média de três notas");

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"Média: {media:F2}");
            Console.WriteLine(media >= 6 ? "Aprovado" : "Reprovado");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao18()
        {
            Console.Clear();
            Console.WriteLine("Questão 18: Contar letras 'a' em uma string");

            Console.Write("Digite uma string: ");
            string input = Console.ReadLine().ToLower();

            int count = input.Count(c => c == 'a');

            Console.WriteLine($"A letra 'a' aparece {count} vezes.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void Questao19()
        {
            Console.Clear();
            Console.WriteLine("Questão 19: Imprimir números de 1 a 10 em ordem decrescente");

            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao20()
        {
            Console.Clear();
            Console.WriteLine("Questão 20: Calcular a soma dos quadrados dos números de 1 a N");

            Console.Write("Digite o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            int somaQuadrados = 0;
            for (int i = 1; i <= N; i++)
            {
                somaQuadrados += i * i;
            }

            Console.WriteLine($"A soma dos quadrados de 1 a {N} é: {somaQuadrados}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao21()
        {
            Console.Clear();
            Console.WriteLine("Questão 21: Mensagem de boas-vindas");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Bem-vindo(a), {nome}! Com {idade} anos, você está pronto(a) para aprender C#!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao22()
        {
            Console.Clear();
            Console.WriteLine("Questão 22: Recebe um número e exibe seu dobro e triplo.");

            // Solicita o número ao usuário
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            // Calcula o dobro e triplo
            int dobro = numero * 2;
            int triplo = numero * 3;

            // Exibe os resultados
            Console.WriteLine($"Dobro de {numero}: {dobro}");
            Console.WriteLine($"Triplo de {numero}: {triplo}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void Questao23()
        {
            Console.Clear();
            Console.WriteLine("Questão 23: Retorna o último caractere de uma string fornecida.");

            // Solicita uma string ao usuário
            Console.Write("Digite uma palavra ou frase: ");
            string input = Console.ReadLine();

            // Verifica se a string não é vazia e obtém o último caractere
            if (!string.IsNullOrEmpty(input))
            {
                char ultimoCaractere = input[input.Length - 1];
                Console.WriteLine($"O último caractere da string é: '{ultimoCaractere}'");
            }
            else
            {
                Console.WriteLine("A string fornecida é vazia.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao24()
        {
            Console.Clear();
            Console.WriteLine("Questão 24: Converte horas em segundos.");

            // Solicita a quantidade de horas ao usuário
            Console.Write("Digite a quantidade de horas: ");
            int horas = int.Parse(Console.ReadLine());

            // Converte horas para segundos
            int segundos = horas * 3600;

            Console.WriteLine($"{horas} horas equivalem a {segundos} segundos.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao25()
        {
            Console.Clear();
            Console.WriteLine("Questão 25: Verifica se um número é divisível por 3 e por 5.");

            // Solicita um número ao usuário
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            // Verifica divisibilidade por 3 e 5
            bool divisivelPor3 = numero % 3 == 0;
            bool divisivelPor5 = numero % 5 == 0;

            if (divisivelPor3 && divisivelPor5)
            {
                Console.WriteLine($"{numero} é divisível por 3 e por 5.");
            }
            else
            {
                Console.WriteLine($"{numero} não é divisível por 3 e por 5 simultaneamente.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        //Nível Intermediário
        static void Questao26()
        {
            Console.Clear();
            Console.WriteLine("Questão 26: Ordena três números fornecidos.");

            // Solicita três números
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            // Coloca os números em uma lista e ordena
            List<int> numeros = new List<int> { num1, num2, num3 };
            numeros.Sort();

            Console.WriteLine($"Números em ordem crescente: {string.Join(", ", numeros)}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao27()
        {
            Console.Clear();
            Console.WriteLine("Questão 27: Calcula o fatorial de um número.");

            // Solicita o número ao usuário
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        // Questão 28: Classe Aluno com propriedades Nome e Nota
        // Questão 28: Exibir informações de um aluno
        static void Questao28()
        {
            Console.Clear();
            Console.WriteLine("Questão 28: Exibindo informações de um aluno");

            // Solicita ao usuário o nome e a nota do aluno
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            // Instancia um objeto Aluno e define as propriedades
            Aluno aluno = new Aluno(nome, nota);

            // Chama o método ExibirInformacoes para exibir nome e nota do aluno
            Console.WriteLine("\nInformações do Aluno:");
            aluno.ExibirInformacoes();

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Questão 29: Método que calcula a média de uma lista de números
        static void Questao29()
        {
            Console.Clear();
            Console.WriteLine("Questão 29: Calcula a média de uma lista de números.");

            List<double> numeros = new List<double>();

            Console.WriteLine("Digite os números (Digite 'sair' para terminar):");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "sair") break;
                numeros.Add(double.Parse(input));
            }

            double media = numeros.Average();
            Console.WriteLine($"A média dos números fornecidos é: {media}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        // Questão 30: Programa que verifica se uma palavra é um palíndromo
        static void Questao30()
        {
            Console.Clear();
            Console.WriteLine("Questão 30: Verifica se uma palavra é um palíndromo.");

            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            string reverso = new string(palavra.Reverse().ToArray());

            if (palavra.Equals(reverso, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{palavra} é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"{palavra} não é um palíndromo.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void Questao31()
        {
            Console.Clear();
            Console.WriteLine("Questão 31: Encontrar o menor número em um array");

            // Solicita ao usuário o tamanho do array
            Console.Write("Digite o número de elementos do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];

            // Preenchimento do array com os valores fornecidos pelo usuário
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Chama a função para encontrar o menor número e exibe o resultado
            int menorNumero = EncontrarMenorNumero(numeros);
            Console.WriteLine($"O menor número no array é: {menorNumero}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para encontrar o menor número em um array
        static int EncontrarMenorNumero(int[] array)
        {
            int menor = array[0]; // Assume que o primeiro elemento é o menor
            foreach (int numero in array)
            {
                if (numero < menor) // Se o número atual for menor, atualiza "menor"
                {
                    menor = numero;
                }
            }
            return menor; // Retorna o menor número encontrado
        }

        static void Questao32()
        {
            Console.Clear();
            Console.WriteLine("Questão 32: Multiplicar todos os elementos de um array por um valor");

            // Solicita o tamanho do array e os valores
            Console.Write("Digite o número de elementos do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o valor pelo qual deseja multiplicar os elementos: ");
            int multiplicador = int.Parse(Console.ReadLine());

            // Chama a função para multiplicar os elementos
            int[] resultado = MultiplicarArray(numeros, multiplicador);

            Console.WriteLine("Array após a multiplicação:");
            foreach (int numero in resultado)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para multiplicar cada elemento de um array por um valor
        static int[] MultiplicarArray(int[] array, int multiplicador)
        {
            int[] resultado = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                resultado[i] = array[i] * multiplicador; // Multiplica cada elemento
            }
            return resultado; // Retorna o array resultante
        }

        static void Questao33()
        {
            Console.Clear();
            Console.WriteLine("Questão 33: Soma dos números ímpares em um array");

            // Solicita o tamanho do array e os valores
            Console.Write("Digite o número de elementos do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Chama a função para somar os números ímpares e exibe o resultado
            int somaImpares = SomarNumerosImpares(numeros);
            Console.WriteLine($"A soma dos números ímpares é: {somaImpares}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para somar os números ímpares em um array
        static int SomarNumerosImpares(int[] array)
        {
            int soma = 0;
            foreach (int numero in array)
            {
                if (numero % 2 != 0) // Verifica se o número é ímpar
                {
                    soma += numero; // Soma os números ímpares
                }
            }
            return soma; // Retorna a soma dos ímpares
        }

        static void Questao34()
        {
            Console.Clear();
            Console.WriteLine("Questão 34: Exibindo informações de um Carro");

            Console.Write("Digite a marca do carro: ");
            string marca = Console.ReadLine();

            Console.Write("Digite o ano do carro: ");
            int ano = int.Parse(Console.ReadLine());

            // Cria um objeto da classe Carro e exibe as informações
            Carro carro = new Carro(marca, ano);
            carro.ExibirInformacoes();

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Classe Carro com propriedades Marca e Ano
        class Carro
        {
            public string Marca { get; set; }
            public int Ano { get; set; }

            // Construtor da classe Carro
            public Carro(string marca, int ano)
            {
                Marca = marca;
                Ano = ano;
            }

            // Método para exibir as informações do carro
            public void ExibirInformacoes()
            {
                Console.WriteLine($"Marca: {Marca}, Ano: {Ano}");
            }
        }

        static void Questao35()
        {
            Console.Clear();
            Console.WriteLine("Questão 35: Verificar se um ano é bissexto");

            // Solicita o ano ao usuário
            Console.Write("Digite um ano para verificar se é bissexto: ");
            int ano = int.Parse(Console.ReadLine());

            // Verifica se o ano é bissexto e exibe o resultado
            bool eBissexto = VerificarAnoBissexto(ano);
            Console.WriteLine(eBissexto ? $"{ano} é um ano bissexto." : $"{ano} não é um ano bissexto.");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para verificar se um ano é bissexto
        static bool VerificarAnoBissexto(int ano)
        {
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }

        static void Questao36()
        {
            Console.Clear();
            Console.WriteLine("Questão 36: Exibir os 10 primeiros números da sequência de Fibonacci");

            ExibirFibonacci();

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para exibir os 10 primeiros números da sequência de Fibonacci
        static void ExibirFibonacci()
        {
            int a = 0, b = 1, c;

            Console.Write($"{a} {b} "); // Exibindo os dois primeiros números

            for (int i = 2; i < 10; i++) // Loop para calcular e exibir o restante
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }
        }

        static void Questao37()
        {
            Console.Clear();
            Console.WriteLine("Questão 37: Substituir espaços em uma string por '_'");

            // Solicita a string ao usuário
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();

            // Chama a função para substituir os espaços
            string resultado = SubstituirEspacos(input);
            Console.WriteLine($"String com espaços substituídos: {resultado}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para substituir espaços por '_'
        static string SubstituirEspacos(string texto)
        {
            return texto.Replace(" ", "_"); // Substitui espaços por '_'
        }

        static void Questao38()
        {
            Console.Clear();
            Console.WriteLine("Questão 38: Retornar o índice do maior elemento em um array");

            Console.Write("Digite o número de elementos do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];

            // Populando o array com valores fornecidos pelo usuário
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Chama a função para encontrar o índice do maior elemento
            int indiceMaior = EncontrarIndiceMaiorElemento(numeros);
            Console.WriteLine($"O índice do maior elemento é: {indiceMaior}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para retornar o índice do maior elemento
        static int EncontrarIndiceMaiorElemento(int[] array)
        {
            int indiceMaior = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[indiceMaior])
                {
                    indiceMaior = i;
                }
            }
            return indiceMaior;
        }

        static void Questao39()
        {
            Console.Clear();
            Console.WriteLine("Questão 39: Calcular o Máximo Divisor Comum (MDC)");

            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Chama a função para calcular o MDC
            int mdc = CalcularMDC(numero1, numero2);
            Console.WriteLine($"O MDC de {numero1} e {numero2} é: {mdc}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para calcular o MDC usando o algoritmo de Euclides
        static int CalcularMDC(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        static void Questao40()
        {
            Console.Clear();
            Console.WriteLine("Questão 40: Contar o número de vogais em uma string");

            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();

            // Chama a função para contar as vogais
            int quantidadeVogais = ContarVogais(input);
            Console.WriteLine($"A quantidade de vogais na string é: {quantidadeVogais}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para contar o número de vogais
        static int ContarVogais(string texto)
        {
            int contador = 0;
            foreach (char c in texto.ToLower()) // Converte para minúsculas para uniformizar
            {
                if ("aeiou".Contains(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        static void Questao41()
        {
            Console.Clear();
            Console.WriteLine("Questão 41: Converter um número decimal para binário");

            Console.Write("Digite um número decimal: ");
            int numeroDecimal = int.Parse(Console.ReadLine());

            // Chama a função para converter para binário
            string binario = ConverterParaBinario(numeroDecimal);
            Console.WriteLine($"O número {numeroDecimal} em binário é: {binario}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para converter número decimal para binário
        static string ConverterParaBinario(int numero)
        {
            if (numero == 0) return "0";

            string binario = "";
            while (numero > 0)
            {
                binario = (numero % 2) + binario; // Concatena o resto
                numero /= 2;
            }
            return binario;
        }

        static void Questao42()
        {
            Console.Clear();
            Console.WriteLine("Questão 42: Representação de número por extenso");

            Console.Write("Digite um número (0-9): ");
            int numero = int.Parse(Console.ReadLine());

            // Verifica se o número está no intervalo e exibe o resultado
            string resultado = RepresentacaoPorExtenso(numero);
            Console.WriteLine($"Número por extenso: {resultado}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para representar um número por extenso
        static string RepresentacaoPorExtenso(int numero)
        {
            string[] numerosExtenso = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            if (numero >= 0 && numero <= 9)
            {
                return numerosExtenso[numero];
            }
            return "Número fora do intervalo";
        }

        static void Questao43()
        {
            Console.Clear();
            Console.WriteLine("Questão 43: Simulação de lançamento de dado 100 vezes");

            // Array para armazenar a frequência de cada valor (1 a 6)
            int[] frequencia = new int[6];
            Random random = new Random();

            // Simulação de 100 lançamentos
            for (int i = 0; i < 100; i++)
            {
                int lancamento = random.Next(1, 7);
                frequencia[lancamento - 1]++; // Incrementa a frequência do valor lançado
            }

            // Exibindo a frequência de cada valor
            for (int i = 0; i < frequencia.Length; i++)
            {
                Console.WriteLine($"Valor {i + 1}: {frequencia[i]} vezes");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void Questao44()
        {
            Console.Clear();
            Console.WriteLine("Questão 44: Calcular o IMC e determinar a categoria");

            Console.Write("Digite o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            // Chama a função para calcular o IMC e a categoria
            (double imc, string categoria) = CalcularIMC(peso, altura);
            Console.WriteLine($"IMC: {imc:F2} - Categoria: {categoria}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função que calcula o IMC e determina a categoria
        static (double, string) CalcularIMC(double peso, double altura)
        {
            double imc = peso / (altura * altura);
            string categoria;

            if (imc < 18.5)
                categoria = "Abaixo do peso";
            else if (imc < 24.9)
                categoria = "Peso normal";
            else if (imc < 29.9)
                categoria = "Sobrepeso";
            else
                categoria = "Obesidade";

            return (imc, categoria);
        }

        static void Questao45()
        {
            Console.Clear();
            Console.WriteLine("Questão 45: Encontrar o segundo maior número em um array");

            Console.Write("Digite o número de elementos do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Chama a função para encontrar o segundo maior número
            int segundoMaior = EncontrarSegundoMaior(numeros);
            Console.WriteLine($"O segundo maior número é: {segundoMaior}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para encontrar o segundo maior número
        static int EncontrarSegundoMaior(int[] array)
        {
            int maior = int.MinValue, segundoMaior = int.MinValue;
            foreach (int numero in array)
            {
                if (numero > maior)
                {
                    segundoMaior = maior;
                    maior = numero;
                }
                else if (numero > segundoMaior && numero < maior)
                {
                    segundoMaior = numero;
                }
            }
            return segundoMaior;
        }

        static void Questao46()
        {
            Console.Clear();
            Console.WriteLine("Questão 46: Inverter os elementos de um array");

            Console.Write("Digite o número de elementos do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Chama a função para inverter o array
            InverterArray(numeros);
            Console.WriteLine("Array invertido: " + string.Join(", ", numeros));

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para inverter o array
        static void InverterArray(int[] array)
        {
            int inicio = 0, fim = array.Length - 1;
            while (inicio < fim)
            {
                int temp = array[inicio];
                array[inicio] = array[fim];
                array[fim] = temp;
                inicio++;
                fim--;
            }
        }

        static void Questao47()
        {
            Console.Clear();
            Console.WriteLine("Questão 47: Somar duas matrizes 2x2");

            // Criação e preenchimento das duas matrizes 2x2
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];

            Console.WriteLine("Digite os elementos da Matriz A:");
            PreencherMatriz(matrizA);

            Console.WriteLine("Digite os elementos da Matriz B:");
            PreencherMatriz(matrizB);

            // Soma as duas matrizes
            int[,] resultado = SomarMatrizes(matrizA, matrizB);

            // Exibe o resultado
            Console.WriteLine("Resultado da soma das matrizes:");
            ExibirMatriz(resultado);

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para somar duas matrizes 2x2
        static int[,] SomarMatrizes(int[,] a, int[,] b)
        {
            int[,] resultado = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultado[i, j] = a[i, j] + b[i, j];
                }
            }
            return resultado;
        }

        // Função auxiliar para preencher a matriz
        static void PreencherMatriz(int[,] matriz)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Função auxiliar para exibir a matriz
        static void ExibirMatriz(int[,] matriz)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Questao48()
        {
            Console.Clear();
            Console.WriteLine("Questão 48: Exibir o dia da semana de uma data");

            Console.Write("Digite uma data (formato: dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            // Chama a função para obter o dia da semana
            string diaDaSemana = ObterDiaDaSemana(data);
            Console.WriteLine($"O dia da semana é: {diaDaSemana}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para obter o dia da semana a partir de uma data
        static string ObterDiaDaSemana(DateTime data)
        {
            return data.ToString("dddd"); // Retorna o dia da semana por extenso
        }

        static void Questao49()
        {
            Console.Clear();
            Console.WriteLine("Questão 49: Verificar se uma string contém apenas letras e números");

            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();

            bool apenasLetrasENumeros = VerificarApenasLetrasENumeros(input);
            Console.WriteLine(apenasLetrasENumeros ? "A string contém apenas letras e números." : "A string contém outros caracteres.");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para verificar se a string contém apenas letras e números
        static bool VerificarApenasLetrasENumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

        static void Questao50()
        {
            Console.Clear();
            Console.WriteLine("Questão 50: Calcular a potência de um número");

            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            int resultado = CalcularPotencia(baseNum, expoente);
            Console.WriteLine($"Resultado: {baseNum}^{expoente} = {resultado}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Função para calcular a potência sem usar Math.Pow
        static int CalcularPotencia(int baseNum, int expoente)
        {
            int resultado = 1;
            for (int i = 0; i < expoente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        // Nível Intermediário - Avançado
        // QUESTÃO 51: Verificar se uma matriz é simétrica
        static void Questao51()
        {
            int[,] matriz = {
            { 1, 2, 3 },
            { 2, 4, 5 },
            { 3, 5, 6 }
        };

            if (VerificarSimetria(matriz))
                Console.WriteLine("A matriz é simétrica.");
            else
                Console.WriteLine("A matriz não é simétrica.");
        }

        static bool VerificarSimetria(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            if (linhas != colunas) return false;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] != matriz[j, i]) return false;
                }
            }

            return true;
        }

        // QUESTÃO 52: Ordenar lista de nomes em ordem alfabética
        static void Questao52()
        {
            string[] nomes = { "Maria", "Ana", "Carlos", "Beatriz", "João" };
            OrdenarNomes(nomes);
        }

        static void OrdenarNomes(string[] nomes)
        {
            Array.Sort(nomes);
            Console.WriteLine("Lista de nomes em ordem alfabética:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        // QUESTÃO 53: Encontrar o elemento mais frequente em um array
        static void Questao53()
        {
            int[] array = { 1, 3, 2, 3, 4, 3, 5 };
            Console.WriteLine("Elemento mais frequente: " + ElementoMaisFrequente(array));
        }

        static int ElementoMaisFrequente(int[] array)
        {
            return array.GroupBy(x => x)
                        .OrderByDescending(g => g.Count())
                        .First().Key;
        }


        // QUESTÃO 54: Calcular valor absoluto de um número
        static void Questao54()
        {
            int numero = -5;
            Console.WriteLine("Valor absoluto: " + ValorAbsoluto(numero));
        }

        static int ValorAbsoluto(int numero)
        {
            return numero < 0 ? -numero : numero;
        }

        // QUESTÃO 55: Implementar busca linear em um array
        static void Questao55()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int valor = 3;
            int resultado = BuscaLinear(array, valor);

            if (resultado != -1)
                Console.WriteLine("Valor encontrado no índice: " + resultado);
            else
                Console.WriteLine("Valor não encontrado.");
        }

        static int BuscaLinear(int[] array, int valor)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valor) return i;
            }
            return -1;
        }

        // QUESTAO 56 - Simular Cronômetro
        static void Questao56()
        {
            Console.Write("Digite a duração do cronômetro em segundos: ");
            int duracao = int.Parse(Console.ReadLine());
            SimularCronometro(duracao);
        }

        static void SimularCronometro(int segundos)
        {
            for (int i = 1; i <= segundos; i++)
            {
                Console.Clear();
                Console.WriteLine("Cronômetro: " + i + " segundos");
                Thread.Sleep(1000); // Pausa de 1 segundo
            }
            Console.WriteLine("Tempo finalizado!");
        }

        // QUESTAO 57 - Contar Palavras
        static void Questao57()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Número de palavras: " + ContarPalavras(frase));
        }

        static int ContarPalavras(string frase)
        {
            string[] palavras = frase.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            return palavras.Length;
        }

        // QUESTAO 58 - Exibir nome de uma Pessoa
        static void Questao58()
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Pessoa pessoa = new Pessoa { Nome = nome };
            pessoa.Falar();
        }

        class Pessoa
        {
            public string Nome { get; set; }
            public void Falar()
            {
                Console.WriteLine($"Olá, meu nome é {Nome}.");
            }
        }

        // QUESTAO 59 - Intersecção de Arrays
        static void Questao59()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };
            int[] intersecao = IntersecaoArrays(array1, array2);
            Console.WriteLine("Interseção dos arrays: " + string.Join(", ", intersecao));
        }

        static int[] IntersecaoArrays(int[] array1, int[] array2)
        {
            return array1.Intersect(array2).ToArray();
        }

        // QUESTAO 60 - Alternar Maiúsculas e Minúsculas
        static void Questao60()
        {
            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();
            Console.WriteLine("Texto alternado: " + AlternarMaiusculasMinusculas(texto));
        }

        static string AlternarMaiusculasMinusculas(string texto)
        {
            char[] caracteres = texto.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (char.IsUpper(caracteres[i]))
                    caracteres[i] = char.ToLower(caracteres[i]);
                else
                    caracteres[i] = char.ToUpper(caracteres[i]);
            }

            return new string(caracteres);
        }

        // QUESTAO 61 - Contar Caracteres Únicos
        static void Questao61()
        {
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();
            int caracteresUnicos = ContarCaracteresUnicos(input);
            Console.WriteLine($"Número de caracteres únicos: {caracteresUnicos}");
        }

        static int ContarCaracteresUnicos(string input)
        {
            return input.Distinct().Count();
        }

        // QUESTAO 62 - Números Primos até um valor fornecido
        static void Questao62()
        {
            Console.Write("Digite o valor limite: ");
            int limite = int.Parse(Console.ReadLine());
            ExibirNumerosPrimos(limite);
        }

        static void ExibirNumerosPrimos(int limite)
        {
            for (int i = 2; i <= limite; i++)
            {
                if (EhPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool EhPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        // QUESTAO 63 - Verificar se um número é perfeito
        static void Questao63()
        {
            Console.Write("Digite um número para verificar se é perfeito: ");
            int numero = int.Parse(Console.ReadLine());
            bool perfeito = EhNumeroPerfeito(numero);
            Console.WriteLine(perfeito ? $"{numero} é um número perfeito." : $"{numero} não é um número perfeito.");
        }

        static bool EhNumeroPerfeito(int numero)
        {
            int somaDivisores = 0;
            for (int i = 1; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                    somaDivisores += i;
            }
            return somaDivisores == numero;
        }

        // QUESTAO 64 - Exibir divisores de um número
        static void Questao64()
        {
            Console.Write("Digite um número para exibir os divisores: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Divisores: " + string.Join(", ", ObterDivisores(numero)));
        }

        static int[] ObterDivisores(int numero)
        {
            return Enumerable.Range(1, numero).Where(i => numero % i == 0).ToArray();
        }

        // QUESTAO 65 - Calcular a Transposta de uma Matriz
        static void Questao65()
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];
            Console.WriteLine("Digite os elementos da matriz:");

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] transposta = CalcularTransposta(matriz, linhas, colunas);

            Console.WriteLine("Matriz Transposta:");
            for (int i = 0; i < colunas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    Console.Write(transposta[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] CalcularTransposta(int[,] matriz, int linhas, int colunas)
        {
            int[,] transposta = new int[colunas, linhas];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }
            return transposta;
        }


        // QUESTAO 66 - Exibir Horário Continuamente
        static void Questao66()
        {
            Console.WriteLine("Pressione qualquer tecla para parar o relógio.");
            while (!Console.KeyAvailable)
            {
                Console.Clear();
                Console.WriteLine("Horário atual: " + DateTime.Now.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
            }
            Console.ReadKey(); // Aguarda pressionamento de tecla para interromper
        }

        // QUESTAO 67 - Simular Calculadora Simples
        static void Questao67()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação (+, -, *, /): ");
            char operacao = Console.ReadLine()[0];

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = CalculadoraSimples(num1, num2, operacao);
            Console.WriteLine($"Resultado: {resultado}");
        }

        static double CalculadoraSimples(double num1, double num2, char operacao)
        {
            switch (operacao)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        throw new DivideByZeroException("Divisão por zero não permitida.");
                default:
                    throw new InvalidOperationException("Operação inválida.");
            }
        }

        // QUESTAO 68 - Converter Valor Monetário para Extenso
        static void Questao68()
        {
            Console.Write("Digite o valor em reais: ");
            decimal valor = decimal.Parse(Console.ReadLine());
            string valorExtenso = ConversorMonetarioParaExtenso(valor);
            Console.WriteLine("Valor por extenso: " + valorExtenso);
        }

        static string ConversorMonetarioParaExtenso(decimal valor)
        {
            return new CultureInfo("pt-BR").TextInfo.ToTitleCase(valor.ToString("C", new CultureInfo("pt-BR")));
        }

        // QUESTAO 69 - Calcular Média Ponderada
        static void Questao69()
        {
            Console.Write("Digite o número de notas: ");
            int quantidade = int.Parse(Console.ReadLine());

            double somaPonderada = 0;
            double somaPesos = 0;

            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Nota {i}: ");
                double nota = double.Parse(Console.ReadLine());

                Console.Write($"Peso da nota {i}: ");
                double peso = double.Parse(Console.ReadLine());

                somaPonderada += nota * peso;
                somaPesos += peso;
            }

            double mediaPonderada = CalcularMediaPonderada(somaPonderada, somaPesos);
            Console.WriteLine($"Média ponderada: {mediaPonderada}");
        }

        static double CalcularMediaPonderada(double somaPonderada, double somaPesos)
        {
            return somaPonderada / somaPesos;
        }

        // QUESTAO 70 - Simular Caixa Eletrônico para Saques
        static void Questao70()
        {
            Console.Write("Digite o valor do saque: ");
            int valor = int.Parse(Console.ReadLine());

            int[] notasDisponiveis = { 100, 50, 20, 10, 5, 2 };
            int[] notas = SimularSaqueCaixaEletronico(valor, notasDisponiveis);

            Console.WriteLine("Notas fornecidas:");
            for (int i = 0; i < notasDisponiveis.Length; i++)
            {
                if (notas[i] > 0)
                    Console.WriteLine($"{notas[i]} nota(s) de {notasDisponiveis[i]}");
            }
        }

        static int[] SimularSaqueCaixaEletronico(int valor, int[] notasDisponiveis)
        {
            int[] notasUsadas = new int[notasDisponiveis.Length];
            for (int i = 0; i < notasDisponiveis.Length; i++)
            {
                notasUsadas[i] = valor / notasDisponiveis[i];
                valor %= notasDisponiveis[i];
            }

            if (valor > 0)
                Console.WriteLine("Valor não pode ser sacado com as notas disponíveis.");

            return notasUsadas;
        }

        // QUESTAO 71 - Verificar Igualdade de Arrays
        static void Questao71()
        {
            Console.Write("Digite o tamanho dos arrays: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] array1 = new int[tamanho];
            int[] array2 = new int[tamanho];

            Console.WriteLine("Digite os elementos do primeiro array:");
            for (int i = 0; i < tamanho; i++)
                array1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os elementos do segundo array:");
            for (int i = 0; i < tamanho; i++)
                array2[i] = int.Parse(Console.ReadLine());

            bool arraysIguais = VerificarIgualdadeArrays(array1, array2);
            Console.WriteLine(arraysIguais ? "Os arrays são iguais." : "Os arrays são diferentes.");
        }

        static bool VerificarIgualdadeArrays(int[] array1, int[] array2)
        {
            return array1.SequenceEqual(array2);
        }

        // QUESTAO 72 - Gerar Senha Aleatória com Letras e Números
        static void Questao72()
        {
            Console.Write("Digite o comprimento da senha: ");
            int comprimento = int.Parse(Console.ReadLine());

            string senha = GerarSenhaAleatoria(comprimento);
            Console.WriteLine("Senha gerada: " + senha);
        }

        static string GerarSenhaAleatoria(int comprimento)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder senha = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < comprimento; i++)
            {
                int index = random.Next(caracteres.Length);
                senha.Append(caracteres[index]);
            }

            return senha.ToString();
        }

        // QUESTAO 73 - Gerar Tabela de Multiplicação
        static void Questao73()
        {
            Console.Write("Digite o número para gerar a tabela de multiplicação: ");
            int numero = int.Parse(Console.ReadLine());

            GerarTabelaMultiplicacao(numero);
        }

        static void GerarTabelaMultiplicacao(int numero)
        {
            Console.WriteLine($"Tabela de multiplicação do {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        // QUESTAO 74 - Calcular a Área de um Triângulo com Três Lados
        static void Questao74()
        {
            Console.Write("Digite o valor do lado A: ");
            double ladoA = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            double ladoB = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            double ladoC = double.Parse(Console.ReadLine());

            double area = CalcularAreaTriangulo(ladoA, ladoB, ladoC);
            Console.WriteLine("Área do triângulo: " + area);
        }

        static double CalcularAreaTriangulo(double a, double b, double c)
        {
            double semiPerimetro = (a + b + c) / 2;
            return Math.Sqrt(semiPerimetro * (semiPerimetro - a) * (semiPerimetro - b) * (semiPerimetro - c));
        }

        // QUESTAO 75 - Gerar Números Aleatórios Únicos entre 1 e N
        static void Questao75()
        {
            Console.Write("Digite o valor de N para gerar números aleatórios únicos de 1 a N: ");
            int n = int.Parse(Console.ReadLine());

            int[] numerosAleatorios = GerarNumerosAleatoriosUnicos(n);
            Console.WriteLine("Números gerados: " + string.Join(", ", numerosAleatorios));
        }

        static int[] GerarNumerosAleatoriosUnicos(int n)
        {
            Random random = new Random();
            return Enumerable.Range(1, n).OrderBy(x => random.Next()).ToArray();
        }

        // QUESTÃO 76 - Jogo "Adivinhe o Número"
        static void Questao76()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativa = 0;

            Console.WriteLine("Adivinhe o número entre 1 e 100!");

            while (true)
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());

                if (tentativa < numeroSecreto)
                    Console.WriteLine("Tente um número maior!");
                else if (tentativa > numeroSecreto)
                    Console.WriteLine("Tente um número menor!");
                else
                {
                    Console.WriteLine("Parabéns! Você adivinhou o número.");
                    break;
                }
            }
        }


        // QUESTÃO 77 - Verificar se dois arrays têm os mesmos elementos (independente da ordem)
        static void Questao77()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 5, 4, 3, 2, 1 };

            bool iguais = ArraysIguais(array1, array2);
            Console.WriteLine("Os arrays possuem os mesmos elementos: " + iguais);
        }

        static bool ArraysIguais(int[] array1, int[] array2)
        {
            return array1.OrderBy(x => x).SequenceEqual(array2.OrderBy(x => x));
        }

        // QUESTÃO 78 - Fila de Atendimento (FIFO) usando List<T>
        static void Questao78()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Cliente 1");
            fila.Enqueue("Cliente 2");
            fila.Enqueue("Cliente 3");

            Console.WriteLine("Atendendo os clientes:");
            while (fila.Count > 0)
            {
                Console.WriteLine("Atendendo: " + fila.Dequeue());
            }
        }

        // QUESTÃO 79 - Jogo "Pedra, Papel e Tesoura" contra o computador
        static void Questao79()
        {
            string[] opcoes = { "Pedra", "Papel", "Tesoura" };
            Random random = new Random();
            int escolhaComputador = random.Next(0, 3);

            Console.WriteLine("Escolha: 0 - Pedra, 1 - Papel, 2 - Tesoura");
            int escolhaUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você escolheu: {opcoes[escolhaUsuario]}");
            Console.WriteLine($"Computador escolheu: {opcoes[escolhaComputador]}");

            if (escolhaUsuario == escolhaComputador)
                Console.WriteLine("Empate!");
            else if ((escolhaUsuario == 0 && escolhaComputador == 2) ||
                     (escolhaUsuario == 1 && escolhaComputador == 0) ||
                     (escolhaUsuario == 2 && escolhaComputador == 1))
                Console.WriteLine("Você ganhou!");
            else
                Console.WriteLine("Computador ganhou!");
        }

        // QUESTÃO 80 - Soma dos dígitos de um número
        static void Questao80()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int soma = SomaDigitos(numero);
            Console.WriteLine("Soma dos dígitos: " + soma);
        }

        static int SomaDigitos(int numero)
        {
            int soma = 0;
            while (numero > 0)
            {
                soma += numero % 10;
                numero /= 10;
            }
            return soma;
        }

        // QUESTÃO 81 - Encontrar e exibir números pares em uma lista
        static void Questao81()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> pares = EncontrarPares(numeros);

            Console.WriteLine("Números pares: " + string.Join(", ", pares));
        }

        static List<int> EncontrarPares(List<int> numeros)
        {
            return numeros.Where(n => n % 2 == 0).ToList();
        }

        // QUESTÃO 82 - Calcular a média e o maior valor informado
        static void Questao82()
        {
            List<int> valores = new List<int>();
            Console.WriteLine("Digite valores inteiros (digite 0 para encerrar):");

            while (true)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                    break;
                valores.Add(valor);
            }

            if (valores.Count > 0)
            {
                double media = valores.Average();
                int maior = valores.Max();

                Console.WriteLine($"Média dos valores: {media}");
                Console.WriteLine($"Maior valor informado: {maior}");
            }
            else
            {
                Console.WriteLine("Nenhum valor foi informado.");
            }
        }

        // QUESTÃO 83 - Armazenar 10 nomes e exibir em ordem alfabética
        static void Questao83()
        {
            List<string> nomes = new List<string>();
            Console.WriteLine("Digite 10 nomes:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                nomes.Add(Console.ReadLine());
            }

            nomes.Sort();
            Console.WriteLine("Nomes em ordem alfabética:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        // QUESTÃO 84 - Verificar se uma string é um palíndromo
        static void Questao84()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            bool isPalindromo = VerificarPalindromo(palavra);
            Console.WriteLine($"A palavra é um palíndromo: {isPalindromo}");
        }

        static bool VerificarPalindromo(string palavra)
        {
            string invertida = new string(palavra.Reverse().ToArray());
            return palavra.Equals(invertida, StringComparison.OrdinalIgnoreCase);
        }

        // QUESTÃO 85 - Gerar 10 números aleatórios e exibir o menor e o maior
        static void Questao85()
        {
            Random random = new Random();
            List<int> numeros = new List<int>();

            Console.WriteLine("Números aleatórios gerados:");
            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(1, 51);
                numeros.Add(numero);
                Console.WriteLine(numero);
            }

            Console.WriteLine($"Menor número: {numeros.Min()}");
            Console.WriteLine($"Maior número: {numeros.Max()}");
        }

        // QUESTÃO 86 - Classe ContaBancaria com métodos de depósito e saque
        public class ContaBancaria
        {
            public decimal Saldo { get; private set; }

            public void Depositar(decimal valor)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R${valor} realizado. Saldo atual: R${Saldo}");
            }

            public void Sacar(decimal valor)
            {
                if (valor > Saldo)
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
                else
                {
                    Saldo -= valor;
                    Console.WriteLine($"Saque de R${valor} realizado. Saldo atual: R${Saldo}");
                }
            }
        }

        static void Questao86()
        {
            ContaBancaria conta = new ContaBancaria();
            conta.Depositar(500);
            conta.Sacar(200);
            conta.Sacar(100);
        }

        // QUESTÃO 87 - Calcular salário líquido com desconto de 10%
        static void Questao87()
        {
            Console.Write("Digite o salário bruto: R$");
            decimal salarioBruto = decimal.Parse(Console.ReadLine());
            decimal salarioLiquido = salarioBruto * 0.90m;

            Console.WriteLine($"Salário líquido: R${salarioLiquido}");
        }

        // QUESTÃO 88 - Converter número decimal para binário
        static void Questao88()
        {
            Console.Write("Digite um número decimal: ");
            int numero = int.Parse(Console.ReadLine());
            string binario = Convert.ToString(numero, 2);

            Console.WriteLine($"Representação binária: {binario}");
        }

        // QUESTÃO 89 - Verificar se aluno foi aprovado com média >= 7
        static void Questao89()
        {
            Console.WriteLine("Digite as três notas:");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"Média: {media}");
            Console.WriteLine(media >= 7 ? "Aluno aprovado!" : "Aluno reprovado.");
        }

        // QUESTÃO 90 - Soma dos elementos de uma matriz 2x2
        static void Questao90()
        {
            int[,] matriz = new int[2, 2];
            Console.WriteLine("Digite os elementos da matriz 2x2:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int soma = SomarMatriz(matriz);
            Console.WriteLine($"Soma dos elementos da matriz: {soma}");
        }

        static int SomarMatriz(int[,] matriz)
        {
            int soma = 0;
            foreach (int valor in matriz)
            {
                soma += valor;
            }
            return soma;
        }

        // QUESTÃO 91 - Simulação de votação com três candidatos
        static void Questao91()
        {
            int votosCandidato1 = 0;
            int votosCandidato2 = 0;
            int votosCandidato3 = 0;

            Console.WriteLine("Simulação de Votação - Escolha entre três candidatos (1, 2, ou 3). Digite 0 para encerrar.");

            while (true)
            {
                Console.Write("Voto para o candidato (1, 2, ou 3): ");
                int voto = int.Parse(Console.ReadLine());

                if (voto == 0) break;

                switch (voto)
                {
                    case 1:
                        votosCandidato1++;
                        break;
                    case 2:
                        votosCandidato2++;
                        break;
                    case 3:
                        votosCandidato3++;
                        break;
                    default:
                        Console.WriteLine("Voto inválido.");
                        break;
                }
            }

            Console.WriteLine("\nResultado da votação:");
            Console.WriteLine($"Candidato 1: {votosCandidato1} votos");
            Console.WriteLine($"Candidato 2: {votosCandidato2} votos");
            Console.WriteLine($"Candidato 3: {votosCandidato3} votos");

            int vencedor = votosCandidato1 > votosCandidato2 ? (votosCandidato1 > votosCandidato3 ? 1 : 3) : (votosCandidato2 > votosCandidato3 ? 2 : 3);
            Console.WriteLine($"O vencedor é o Candidato {vencedor}!");
        }

        // QUESTÃO 92 - Verificar se um número é múltiplo de 3 e 7
        static void Questao92()
        {
            Console.Write("Digite um número para verificar se é múltiplo de 3 e 7: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 3 == 0 && numero % 7 == 0)
            {
                Console.WriteLine($"{numero} é múltiplo de 3 e 7.");
            }
            else
            {
                Console.WriteLine($"{numero} não é múltiplo de 3 e 7.");
            }
        }

        // QUESTÃO 93 - Calcular a distância entre dois pontos no plano cartesiano
        static void Questao93()
        {
            Console.Write("Digite a coordenada X do ponto 1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada Y do ponto 1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a coordenada X do ponto 2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada Y do ponto 2: ");
            double y2 = double.Parse(Console.ReadLine());

            double distancia = CalcularDistancia(x1, y1, x2, y2);
            Console.WriteLine($"A distância entre os pontos é: {distancia:F2}");
        }

        static double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        // QUESTÃO 94 - Gerar lista de 5 números aleatórios e exibir em ordem crescente
        static void Questao94()
        {
            Random random = new Random();
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numeros.Add(random.Next(1, 101));
            }

            numeros.Sort();
            Console.WriteLine("Números aleatórios em ordem crescente: " + string.Join(", ", numeros));
        }

        // QUESTÃO 95 - Agenda de contatos simples (adicionar e listar contatos)
        static List<(string Nome, string Telefone)> agenda = new List<(string, string)>();

        static void Questao95()
        {
            while (true)
            {
                Console.WriteLine("\nAgenda de Contatos:");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Listar contatos");
                Console.WriteLine("0. Voltar ao menu principal");
                Console.Write("Selecione uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarContato();
                        break;
                    case 2:
                        ListarContatos();
                        break;
                    case 0:
                        return; // Volta ao menu principal
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarContato()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            agenda.Add((nome, telefone));
            Console.WriteLine("Contato adicionado com sucesso.");
        }

        static void ListarContatos()
        {
            Console.WriteLine("\nLista de Contatos:");
            foreach (var contato in agenda)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
            }
        }

        // QUESTÃO 96 - Exibir todos os números primos entre 1 e 100
        static void Questao96()
        {
            Console.WriteLine("Números primos entre 1 e 100:");
            for (int i = 2; i <= 100; i++)
            {
                if (EPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool EPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        // QUESTÃO 97 - Exibir a tabuada de um número até 10
        static void Questao97()
        {
            Console.Write("Digite um número para exibir sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        // QUESTÃO 98 - Retornar o maior número em uma matriz 3x3
        static void Questao98()
        {
            int[,] matriz = new int[3, 3];
            Console.WriteLine("Digite 9 números para preencher a matriz 3x3:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int maiorNumero = EncontrarMaiorNumero(matriz);
            Console.WriteLine("O maior número na matriz é: " + maiorNumero);
        }

        static int EncontrarMaiorNumero(int[,] matriz)
        {
            int maior = matriz[0, 0];
            foreach (int num in matriz)
            {
                if (num > maior)
                    maior = num;
            }
            return maior;
        }

        // QUESTÃO 99 - Calcular a soma dos quadrados de 1 a N
        static void Questao99()
        {
            Console.Write("Digite um número N para calcular a soma dos quadrados de 1 a N: ");
            int n = int.Parse(Console.ReadLine());

            int soma = SomaDosQuadrados(n);
            Console.WriteLine("A soma dos quadrados de 1 a " + n + " é: " + soma);
        }

        static int SomaDosQuadrados(int n)
        {
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                soma += i * i;
            }
            return soma;
        }

        // QUESTÃO 100 - Jogo da Forca com até 5 tentativas
        static void Questao100()
        {
            string palavra = "PROGRAMACAO"; // Palavra a ser adivinhada
            HashSet<char> letrasUsadas = new HashSet<char>();
            int tentativas = 5;
            char[] estadoAtual = new string('_', palavra.Length).ToCharArray();

            while (tentativas > 0 && new string(estadoAtual) != palavra)
            {
                Console.WriteLine("Palavra: " + new string(estadoAtual));
                Console.WriteLine($"Tentativas restantes: {tentativas}");
                Console.Write("Digite uma letra: ");
                char letra = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (letrasUsadas.Contains(letra))
                {
                    Console.WriteLine("Você já tentou essa letra. Tente outra.");
                    continue;
                }

                letrasUsadas.Add(letra);

                if (palavra.Contains(letra))
                {
                    for (int i = 0; i < palavra.Length; i++)
                    {
                        if (palavra[i] == letra)
                            estadoAtual[i] = letra;
                    }
                }
                else
                {
                    tentativas--;
                    Console.WriteLine("Letra incorreta.");
                }
            }

            if (new string(estadoAtual) == palavra)
            {
                Console.WriteLine("Parabéns! Você adivinhou a palavra: " + palavra);
            }
            else
            {
                Console.WriteLine("Você perdeu! A palavra era: " + palavra);
            }
        }


        // Classe Produto que representa um produto com nome e preço
        class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }

            // Construtor da classe Produto que inicializa as propriedades Nome e Preco
            public Produto(string nome, decimal preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }

        // Questão 28: Classe Aluno com propriedades Nome e Nota
        class Aluno
        {
            public string Nome { get; set; }
            public double Nota { get; set; }

            // Construtor da classe Aluno
            public Aluno(string nome, double nota)
            {
                Nome = nome;
                Nota = nota;
            }

            // Método que exibe o nome e a nota do aluno
            public void ExibirInformacoes()
            {
                Console.WriteLine($"Nome: {Nome}, Nota: {Nota:F2}"); // Exibe a nota formatada com duas casas decimais
            }
        }

    }
}
