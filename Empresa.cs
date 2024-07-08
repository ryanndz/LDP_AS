public class Empresa
{
    public List<funcionario> Funcionarios = new List<funcionario>();

    public void AdicionarFuncionario(funcionario Funcionario)
    {
        Funcionarios.Add(Funcionario);
    }

    public void RemoverFuncionario(int matricula)
    {
        foreach (var funcionario in Funcionarios.ToList())
        {
            if (funcionario.matricula == matricula)
            {
                Funcionarios.Remove(funcionario);
                break;
            }
        }
    }

    public void ExibirFuncionarios()
    {
        if (Funcionarios.Count <= 0)
        {
            Console.WriteLine("Não há funcionários cadastrados");
        }
        foreach (var funcionario in Funcionarios)
        {
            funcionario.exibirinformacoes();
            Console.WriteLine();
        }
    }

    public void AdicionarProjetoAoFuncionario(int matricula)
    {
        foreach (var funcionario in Funcionarios)
        {
            if (matricula == funcionario.matricula)
            {
                Console.WriteLine("Deseja registrar um ou mais projetos? 1 - Apenas um 2 - Mais de um");
                int qtdProj = Convert.ToInt32(Console.ReadLine());
                if (qtdProj == 1)
                {
                    Console.WriteLine("Nome do projeto:");
                    string proj = Console.ReadLine();
                    funcionario.AdicionarProjeto(proj);
                }
                else
                {
                    List<string> ProjetosParaFunci = new List<string>();
                    Console.WriteLine("Digite os nomes dos projetos separados por vírgula:");
                    string input = Console.ReadLine();

                    string[] projetos = input.Split(',');
                    for (int i = 0; i < projetos.Length; i++)
                    {
                        projetos[i] = projetos[i].Trim(); 
                        }
                    ProjetosParaFunci.AddRange(projetos);
                    funcionario.AdicionarProjeto(ProjetosParaFunci);
                }
            }

        }
    }
}


