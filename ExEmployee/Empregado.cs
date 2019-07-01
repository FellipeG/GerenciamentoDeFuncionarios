namespace ExEmployee
{
    class Empregado
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem = Salario * porcentagem / 100;
            Salario += porcentagem;
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, R$ {Salario:F2}";
        }
    }
}