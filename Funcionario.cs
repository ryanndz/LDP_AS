public abstract class funcionario{
    public string? nome;
    public int? matricula;
    public List<string>Projetos= new List<string>();

    public funcionario(string nome, int matricula){
        this.nome = nome;
        this.matricula = matricula;
    }
    public abstract double calcularSalario();

    public abstract void exibirinformacoes();

     public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);
        Console.WriteLine($"{projeto} adicionado");
    }

    public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);
        Console.WriteLine($"Projeto adicionado");
    }

} 