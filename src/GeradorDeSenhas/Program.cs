/*
        Feito Por Bruno Miranda 
            Em 24/08/2023

*/
using System;
class Projeto6
{
    static void Main()
    {
        Console.WriteLine("\n---------Bem Vindo ao Gerador de Senhas!---------\n");

    inicio:
        Console.WriteLine("Digite o comprimento da senha: ");
        int compSenha = int.Parse(Console.ReadLine());

        Console.WriteLine("A senha terá letras maiusculas? [s/n] ");
        char letraMaiuscula = char.Parse(Console.ReadLine());

        Console.WriteLine("A senha terá letras minusculas? [s/n] ");
        char letraMinuscula = char.Parse(Console.ReadLine());

        Console.WriteLine("A senha terá números? [s/n] ");
        char numeros = char.Parse(Console.ReadLine());

        Console.WriteLine("A senha terá caracters especiais? [s/n] ");
        char caractersEspeciais = char.Parse(Console.ReadLine());

        string senha = geradorSenha(compSenha, letraMaiuscula, letraMinuscula, numeros, caractersEspeciais);

        Console.WriteLine("\nA sua senha é: " + senha);
        Console.WriteLine("\nDeseja fazer outra senha? [s/n] ");
        char aux = char.Parse(Console.ReadLine());
        if (aux == 's')
        {
            Console.Clear();
            goto inicio;

        }
        else
        {
            Console.WriteLine("Programa finalizado!...");
        }

    }

    static string geradorSenha(int compSenha, char teraMaiuscula, char teraMinuscula, char teraNumeros, char teraCaractersEspeciais)
    {

        char[] letraMaiscula = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] letraMinuscula = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] numeros = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] caractersEspeciais = new char[9] { '!', '@', '#', '$', '%', '^', '&', '*', '_' };

        Random random = new Random();
        char[] senha = new char[compSenha];
        int i = 0;
        while (i < compSenha)
        {

            int ale = random.Next(21);
            if (teraMaiuscula == 's' & i < compSenha)
            {
                if (ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21))
                {
                    senha[i] = letraMaiscula[random.Next(26)];
                    i++;
                }

            }

            if (teraMinuscula == 's' & i < compSenha)
            {
                if (ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21))
                {
                    senha[i] = letraMinuscula[random.Next(26)];
                    i++;
                }
            }

            if (teraNumeros == 's' & i < compSenha)
            {
                if (ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21))
                {
                    senha[i] = numeros[random.Next(10)];
                    i++;
                }
            }

            if (teraCaractersEspeciais == 's' & i < compSenha)
            {
                if (ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21) | ale == random.Next(21))
                {
                    senha[i] = caractersEspeciais[random.Next(9)];
                    i++;
                }
            }

        }
        string s = new string(senha);
        return s;
    }
}