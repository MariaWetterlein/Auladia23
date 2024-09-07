using SRC.Interfaces;
namespace SRC.Entites;

public class Cliente: Pessoa

{
	
	public string Endereco{ get; set; }
	
	public Cliente {string nome, string cpf, string endereco} : base(nome, cpf)
	
	{
		Endereco = endereco;
		
	}
	
	public override void ObterIdentificacao()
	
	{
		Console.WriteLine($"Cliente : {Nome}, CPF: {CPF}, Endereco{Endereco}");
	}
}