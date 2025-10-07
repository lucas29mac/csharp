using System.Text.Json.Serialization;

Random aleatorio = new Random();
int secretNumber = aleatorio.Next(1, 101);

do
{
    Console.Write("Mo fi agora tu escolhes um numero entre 1 e 100");
    int chute = int.Parse(Console.ReadLine());

    if (chute == secretNumber)
    {
        Console.Write("Acerto miseravi");
        break;
    }
    else if (chute < secretNumber)
    {
        Console.Write("abaixo do esperado");
    }
    else if (chute > secretNumber)
    {
        Console.Write("Acima do esperado");
    }



} while (true);

Console.Write("O jogo acabou e voce venceeeeu !!! PARABENS!!!");


