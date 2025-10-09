using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obeigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obeigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obeigatório informar o perfil de usuário")]
        public string Perfil { get; set; }

    }

    public enum Perfil
    {
        Admin,
        User
    }
}
