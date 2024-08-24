namespace SRC.Interfaces;

public interface IPessoa

{
	string Nome { get; set; }
	string CPF { get; set; }
	
	void ObterIdentificacao();
}