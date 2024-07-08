// funcionarioMP mp1 =new funcionarioMP("ryan",1,100,10);
// mp1.calcularSalario();
// mp1.AdicionarProjeto("projeto1");
// List<string> projetos = new List<string> { "Projeto B", "Projeto C" };
// mp1.AdicionarProjeto(projetos);
// // mp1.exibirinformacoes();
// funcionarioTempoIntegral integral1 = new funcionarioTempoIntegral("larissa",2,1400.00);
// // integral1.exibirinformacoes();
// emp1.AdicionarFuncionario(mp1);
// emp1.AdicionarFuncionario(integral1);
// emp1.ExibirFuncionarios();
// Implemente a classe Program com o método Main.
// Dentro do método Main, crie uma instância da classe Empresa.
// Implemente um menu interativo no console onde o usuário pode:
// Adicionar um funcionário de tempo integral.
// Adicionar um funcionário de meio período.
// Remover um funcionário.
// Exibir informações de todos os funcionários.
// Adicionar projeto(s) a um funcionário.
// Sair do programa
Empresa emp1 = new Empresa();
Console.WriteLine($"Seja bem vindo, me informe seu nome: ");
string nome = Console.ReadLine();
int opcao = 0;

do
{
    Console.WriteLine($"{nome}, Escolha uma opção: \n1-Adicionar um funcionário de tempo integral\n2-Adicionar um funcionário de meio período\n3-Remover um funcionário\n4-Exibir informações de todos os funcionários\n5-Adicionar projeto(s) a um funcionário\n6-Sair do programa");
    string? input = Console.ReadLine();
    opcao = Convert.ToInt32(input);
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Passe as informações: ");
            Console.WriteLine("Nome:");
            string? ftp1Nome = Console.ReadLine();
            Console.WriteLine("Matricula:");
            string? matriculaInput = Console.ReadLine();
            int ftp1Matricula = Convert.ToInt32(matriculaInput);
            Console.WriteLine("Salario mensal:");
            string? salarioInput = Console.ReadLine();
            double ftp1SalarioMen = Convert.ToDouble(salarioInput);
            funcionarioTempoIntegral ftp1 = new funcionarioTempoIntegral(ftp1Nome, ftp1Matricula, ftp1SalarioMen);
            emp1.AdicionarFuncionario(ftp1);
            Console.WriteLine($"{ftp1.nome} adicionado");
            break;

        case 2:
            Console.WriteLine("Passe as informações: ");
            Console.WriteLine("Nome:");
            string? mp1Nome = Console.ReadLine();
            Console.WriteLine("Matricula:");
            string? matricula1Input = Console.ReadLine();
            int mp1Matricula = Convert.ToInt32(matricula1Input);
            Console.WriteLine("Salario Hora:");
            string? salario1Input = Console.ReadLine();
            double mp1SalarioHora = Convert.ToDouble(salario1Input);
            Console.WriteLine("Horas trabalhadas:");
            string? horasInput = Console.ReadLine();
            double mp1oHora = Convert.ToDouble(horasInput);
            funcionarioMP mp1 = new funcionarioMP(mp1Nome, mp1Matricula, mp1SalarioHora, mp1oHora);
            emp1.AdicionarFuncionario(mp1);
            Console.WriteLine($"{mp1.nome} adicionado");
            break;

        case 3:
            Console.WriteLine("Informe a matricula do funcionario: ");
            string inputmatricula = Console.ReadLine();
            int matriculaParaRemover = Convert.ToInt32(inputmatricula);
            emp1.RemoverFuncionario(matriculaParaRemover);
            Console.WriteLine($"Funcionario removido");
            break;

        case 4:
            emp1.ExibirFuncionarios();
            break;

        case 5:
            Console.WriteLine("Informe a matricula do funcionario: ");
            string inputmatricula2 = Console.ReadLine();
            int matri = Convert.ToInt32(inputmatricula2);
            emp1.AdicionarProjetoAoFuncionario(matri);
            break;
    }
}
while (opcao != 6);
