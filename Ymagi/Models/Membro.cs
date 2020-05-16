using System;
using System.Collections.Generic;

namespace Ymagi.Models
{
    public class Membro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Filhos { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Osc Osc { get; set; }
        public int OscId { get; set; }

        public ICollection<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public List<Entrega> Entregas { get; set; } = new List<Entrega>();
        public List<Recebimento> Recebimentos { get; set; } = new List<Recebimento>();


        public void AddFornecedor(Fornecedor fornecedor)
        {
            Fornecedores.Add(fornecedor);
        }

        public void RemFornecedor(Fornecedor fornecedor)
        {
            Fornecedores.Remove(fornecedor);
        }


        public void AddProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void RemProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }

        public void AddEntrega(Entrega entrega)
        {
            Entregas.Add(entrega);
        }

        public void RemEntrega(Entrega entrega)
        {
            Entregas.Remove(entrega);
        }


        public void AddRecebimento(Recebimento recebe)
        {
            Recebimentos.Add(recebe);
        }

        public void RemRecebimento(Recebimento recebe)
        {
            Recebimentos.Remove(recebe);
        }

    }
}
