using System;
using System.Collections.Generic;
namespace Ymagi.Models
{
    public class Osc
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string RazaoSocial { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Responsavel { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        public string Endereço { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Contato { get; set; }
        public string Observacao { get; set; }

        public ICollection<Membro> Membros { get; set; } = new List<Membro>();

    }
}