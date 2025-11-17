using System;
using System.Globalization;

namespace AtletaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a quantidade de atletas? ");
            int n = int.Parse(Console.ReadLine());
            string nome;
            char sexo;
            double altura;
            double peso;

            double peso_medio = 0;
            string nome_mais_alto;
            double altura_mais_alto = 0.0;
            int qtd_mulheres = 0;
            int qtd_homens = 0;
            double porcentagem_homem = 0; 
            double altura_media_mulheres = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Sexo: ");
                sexo = char.Parse(Console.ReadLine());
                while(sexo != 'M' || sexo != 'F' )
                {
                    Console.Write("Valor inválido! Favor digitar F ou M: ");
                    sexo = char.Parse(Console.ReadLine());
                }

                if (sexo == 'F')
                {
                    qtd_mulheres += 1;
                }
                else 
                { 
                    qtd_homens += 1;
                }

                    Console.Write("Altura: ");
                altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (altura <= 0)
                {
                    Console.Write("Valor inválido! Favor digitar um valor positivo: ");
                    altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                if (sexo == 'M')
                {
                    altura_media_mulheres += altura;
                }

                if (altura > altura_mais_alto)
                {
                    nome_mais_alto = nome;
                }

                Console.Write("Peso: ");
                peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (peso <= 0)
                {
                    Console.Write("Valor inválido! Favor digitar um valor positivo: ");
                    peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                peso_medio += peso;
                porcentagem_homem = qtd_homens / n;

            }

            peso_medio = peso_medio / n;

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO: ");
            Console.WriteLine("Peso médio dos atletas: " + peso_medio.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Atleta mais alto: " + altura_mais_alto);
            Console.WriteLine("Porcentagem homens: " + (porcentagem_homem * 100.00).ToString("F2", CultureInfo.InvariantCulture) + "%");
            if (qtd_mulheres == 0)
            {
                Console.WriteLine("Não há mulheres cadastradas!");
            }
            else
            {
                Console.WriteLine("Altura média das mulheres: " + (altura_media_mulheres / n).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}