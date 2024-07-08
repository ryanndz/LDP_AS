// Crie uma classe FuncionarioTempoIntegral que herda de Funcionario.
// Adicione uma variável privada para armazenar o salário mensal.
// Implemente o construtor para inicializar o nome, a matrícula e o salário mensal.
// Implemente os métodos CalcularSalario() e ExibirInformacoes().

public class funcionarioTempoIntegral : funcionario, IBonus{
    private double salarioMens;
    public funcionarioTempoIntegral(string nome, int matricula, double salarioMens) :base(nome, matricula){
        this.salarioMens=salarioMens;
    }
    public override double calcularSalario()
    {
        return salarioMens;
    }
    public override void exibirinformacoes()
    {
        Console.WriteLine($"Nome:{nome}\nMatricula:{matricula}\nSalario:{salarioMens}\nBonus : {CalcularBonus()}");
        Console.Write("Projetos: ");
        if (Projetos.Count == 0)
        {
            Console.WriteLine("Nenhum projeto");
        }
        else
        {
            foreach (var projeto in Projetos)
            {
                Console.Write($"\n{projeto}\n");
            }
            Console.WriteLine();
        }
    }
    public double CalcularBonus(){  
        return salarioMens =salarioMens*0.1;
    
    }
}