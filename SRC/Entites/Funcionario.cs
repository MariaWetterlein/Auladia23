using SRC.Interfaces;
namespace SRC.Entites;

public class Funcionario: Pessoa

{
	
	public string Cargo{ get; set; }
	
	public Funcionario {string nome, string cpf, string cargo} : base(nome, cpf)
	
	{
		Cargo =cargo;
		
	}
	
	public override void ObterIdentificacao()
	
	{
		Console.WriteLine($"Funcionario : {Nome}, CPF: {CPF}, Cargo:{Cargo}");
	}
}
