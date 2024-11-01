﻿using System.ComponentModel.DataAnnotations;

namespace PetProvei.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }

        // Relação com Vendas
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();
    }
}
