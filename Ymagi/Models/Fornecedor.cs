using System;
using System.Collections.Generic;

namespace Ymagi.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string InscEstadual { get; set; }
        public string Contato { get; set; }
        public string Cep { get; set; }
        public string Endereço { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Membro Membro { get; set; }
        public int MembroId { get; set; }
        
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public List<Recebimento> Recebimentos { get; set; } = new List<Recebimento>();

    }
}
