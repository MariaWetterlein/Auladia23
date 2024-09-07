using SRC.Services;
using System.Collections.Generic;

namespace SRC.Entities

     public class Biblioteca
        private readonly List<Funcionario> _funcionarios;
private readonly List<Emprestimo> _emprestimos;

private readonly GerenciadorDeArquivo<Livro> _gerenciadorLivros;
private readonly GerenciadorDeArquivo<Cliente> _gerenciadorClientes;
private readonly GerenciadorDeArquivo<Funcionario> _gerenciadorFuncionarios;
private readonly GerenciadorDeArquivo<Emprestimo> _gerenciadorEmprestimos;

public Biblioteca()
{
    _gerenciadorLivros = new GerenciadorDeArquivo<Livro>("livros.json");
    _gerenciadorClientes = new GerenciadorDeArquivo<Cliente>("clientes.json");
    _gerenciadorFuncionarios = new GerenciadorDeArquivo<Funcionario>("funcionarios.json");
    _gerenciadorEmprestimos = new GerenciadorDeArquivo<Emprestimo>("emprestimos.json");

    _livros = _gerenciadorLivros.Carregar();
    _clientes = _gerenciadorClientes.Carregar();
    _funcionarios = _gerenciadorFuncionarios.Carregar();
    _emprestimos = _gerenciadorEmprestimos.Carregar();
}

public void AdicionarLivro(Livro livro)
{
    _livros.Add(livro);
    _gerenciadorLivros.Salvar(_livros);
    Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca.");
}

public void RegistrarCliente(Cliente cliente)
{
    _clientes.Add(cliente);
    _gerenciadorClientes.Salvar(_clientes);
    Console.WriteLine($"Cliente '{cliente.Nome}' registrado.");
}

public void RegistrarFuncionario(Funcionario funcionario)
{
    _funcionarios.Add(funcionario);
    _gerenciadorFuncionarios.Salvar(_funcionarios);
    Console.WriteLine($"Funcionário '{funcionario.Nome}' registrado.");
}

public void RealizarEmprestimo(Livro livro, Cliente cliente)
{
    var emprestimo = new Emprestimo(livro, cliente);
    _emprestimos.Add(emprestimo);
    _gerenciadorEmprestimos.Salvar(_emprestimos);
    emprestimo.ConcluirEmprestimo();
    _gerenciadorLivros.Salvar(_livros);
}
            else
            {
	public void ReceberDevolucao(Livro livro, Cliente cliente)
{
    emprestimo.DevolverLivro();
    _emprestimos.Remove(emprestimo);
    _gerenciadorEmprestimos.Salvar(_emprestimos);
    _gerenciadorLivros.Salvar(_livros);
}
            else
            {