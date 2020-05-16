using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ymagi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnit { get; set; }
        public double ValorTotal { get; set; }
        public DateTime Date { get; set; }
        public Usuario Usuario { get; set; }
        public Membro Membro { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public int UsuarioId { get; set; }
        public int MembroId { get; set; }
        public int FornecedorId { get; set; }
        
        public ICollection<Entrega> Entregas { get; set; } = new List<Entrega>();
        public ICollection<Recebimento> Recebimentos { get; set; } = new List<Recebimento>();

    }
}
