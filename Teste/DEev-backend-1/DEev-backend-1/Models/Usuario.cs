﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEev_backend_1.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório infomar o Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório infomar a Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Obrigatório infomar o Email")]
        public Perfil Perfil { get; set; }
    }
    public enum Perfil
    {
        Admin,
        User
    }
}
