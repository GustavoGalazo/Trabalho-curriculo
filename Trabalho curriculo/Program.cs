using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_curriculo
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String sobrenome;
            String sexo;
            String telefone;
            String CPF;
            String endereço;
            String cidade;
            String CEP;
            String escolaridade; 

            Console.WriteLine("Digte seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite seu sexo ");
            sexo = Console.ReadLine();
            Console.WriteLine("Digite seu telefone");
            telefone = Console.ReadLine();
            Console.WriteLine("Digite seu CPF");
            CPF = Console.ReadLine();
            Console.WriteLine("Digite seu endereço");
            endereço = Console.ReadLine();
            Console.WriteLine("Digite sua cidade");
            cidade = Console.ReadLine();
            Console.WriteLine("Digite seu CEP");
            CEP = Console.ReadLine();
            Console.WriteLine("Digite seu grau de escolaridade");
            escolaridade = Console.ReadLine();

            Console.WriteLine("_________________________________Informações do candidato_______________________________________");
            Console.WriteLine("Nome completo:" + " " + nome+ " " +sobrenome);
            Console.WriteLine("Seu grau de escolaridade:"+ " " +escolaridade);
            Console.WriteLine("Número de telefone:" +" " +telefone);
            Console.WriteLine("Seu CPF:" +" " +CPF);
            Console.WriteLine("Seu endereço:" + " "+endereço +" " +cidade);
            Console.WriteLine("seu CEP:"+ " " +CEP);
            Console.ReadKey();


        }
    }
}
