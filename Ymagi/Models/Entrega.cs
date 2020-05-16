using System;
using Ymagi.Models.Enums;

namespace Ymagi.Models
{
    public class Entrega
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnit { get; set; }
        public double ValorTotal { get; set; }
        public Usuario Usuario { get; set; }
        public Membro Membro { get; set; }
        public Status Status { get; set; }

        public int ProdutoId { get; set; }
        public int UsuarioId { get; set; }
        public int MembroId { get; set; }
    }
}
