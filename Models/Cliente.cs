using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ECS.Aplicacao.WebApi.Models
{
    public class Cliente
    {
        [Key]
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
