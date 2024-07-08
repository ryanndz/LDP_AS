public class funcionarioMP : funcionario{
    private double salarioPH;
    private double horasTrab;

    public funcionarioMP(string nome, int matricula, double salarioPH, double horasTrab) :base(nome, matricula){
        this.salarioPH = salarioPH;
        this.horasTrab = horasTrab;
    }
    public override double calcularSalario()
    {
        return salarioPH*horasTrab;
    }
    
    public override void exibirinformacoes()
    {
        Console.WriteLine($"Nome:{nome}\nMatricula:{matricula}\nSalario Por Hora:{salarioPH}\nHoras Trabalhadas:{horasTrab}\nSalario Total:{calcularSalario()}\nBonus: {CalcularBonus()}");

        Console.Write("Projetos: ");
        if (Projetos.Count == 0)
        {
            Console.WriteLine("Nenhum projeto");
        }
        else
        {
            foreach (var projeto in Projetos)
            {
                Console.Write($"{projeto} \n");
            }
            Console.WriteLine();
        }
    }
    public double CalcularBonus(){  
        
        return calcularSalario()*0.05;
    }
}