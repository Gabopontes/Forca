namespace Forca.Screens;

public static class ComeçarScreen
{
    public static void ComercarJogo()
    {
        Console.Clear();

        Console.WriteLine("Digite uma palavra: ");
        var palavra = Console.ReadLine();
        var resultado = new string[palavra.Length];

        int erros = 0, acertos = 0, checar = 0;

        Console.Clear();
        Console.WriteLine("Digite a letra que contem na palavra");
        while (erros != 7 && checar != resultado.Length)
        {
            char letra = char.Parse(Console.ReadLine());

            int ocorrencias = palavra.IndexOf(letra);

            if (ocorrencias == -1)
            {
                erros++;
            }
            else
            {
                acertos++;

                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i].ToString() == letra.ToString())
                    {
                        resultado[i] = letra.ToString();

                        if (resultado[i] != null && resultado[i] != "_")
                        {
                            checar++;
                        }
                    }
                    else if (resultado[i] is null)
                    {
                        resultado[i] = "_";
                    }
                }
            }
            foreach (string item in resultado)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine();


            if (erros == 7)
            {
                Console.WriteLine("VOCÊ FOI ENFORCADO!");
            }
            else if (checar == resultado.Length)
            {
                Console.WriteLine("VOCÊ GANHOU!");
            }
            else
            {
                Console.WriteLine("Erros:{0}, Acertos{1}", erros, acertos);
            }

        }

    }
}