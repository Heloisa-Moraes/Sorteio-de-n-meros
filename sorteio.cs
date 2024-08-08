using System;

class Program
{
    static void Main()
    {
    
        // Cria uma instância da classe Random para gerar números aleatórios
        Random random = new Random();
       
        // Gera um número aleatório entre 0 e 10 (11 é exclusivo)
        int sorteado = random.Next(0, 11);
        
        int tentativas = 0; // Contador de tentativas
        bool acertou = false; // Verificação se o usuário acertou

        // O usuário pode tentar acertar 3 vezes.
        while (tentativas < 3)
        {
            Console.Write("Digite um numero de 0 a 10: ");
         
            // Lê o que o usuário digitou 
            string input = Console.ReadLine();
       
            // Converte o que o usuário digitou para um numero inteiro
            int numero;
            bool sucesso = int.TryParse(input, out numero);
       
            // Verifica se a conversão deu certo e se o número esta dentro do intervalo permitido
            if (sucesso && numero >= 0 && numero <= 10)
            {
                tentativas++; // Incrementa o contador de tentativas
                
                if (numero == sorteado)
                {
                    // Se o usuário acertou o número
                    Console.WriteLine("Parabens, voce acertou o numero: " + numero);
                    acertou = true; // Se o usuário acertar = true.
                    break; // Sai do loop
                }
                else
                {
                    // Se o número estiver errado e ainda há tentativas restantes
                    if (tentativas < 3)
                    {
                        Console.WriteLine("Voce digitou o numero incorreto, tente novamente!");
                    }
                }
            }
            else
            {
                // Se a entrada for inválida ou fora do intervalo
                Console.WriteLine("Voce digitou um caractere invalido ou um número fora do intervalo de 0 a 10, tente novamente!");
                // Não incrementa o contador de tentativas
            }
        }

        // Se o usuário não acertou o número após 3 tentativas
        if (!acertou)
        {
            Console.WriteLine("Você perdeu. O numero sorteado era: " + sorteado);
        }
    }
}
