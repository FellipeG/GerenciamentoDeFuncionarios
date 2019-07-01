using System;
using System.Collections.Generic;

namespace ExEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados serão registrados? ");
            int qtdEmpregados = int.Parse(Console.ReadLine());
            List<Empregado> listaEmpregados = new List<Empregado>();

            for(int i=1; i<=qtdEmpregados; i++)
            {
                Console.WriteLine($"Empregado #{i}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                listaEmpregados.Add(new Empregado(id, nome, salario));
            }

            Console.WriteLine("Digite o ID do empregado que terá o salário aumentado: ");
            int idEmp = int.Parse(Console.ReadLine());
            Empregado empregado = listaEmpregados.Find(emp => emp.Id == idEmp);
            if (empregado != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());
                empregado.AumentarSalario(porcentagem);
            } else
                Console.Write("Não existe nenhum empregado com essa ID!");
            
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de empregados:");
            foreach(Empregado empreg in listaEmpregados)
            {
                Console.WriteLine(empreg);
            }
        }
    }
}
