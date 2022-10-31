namespace VisTu.Models
{
    public class Setor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor informar o nome do setor")]
        [MaxLength(200), MinLength(2)]
        [Display(Name ="Setor")]
        public string NomeSetor { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Favor informar um email válido")]
        public string Email { get; set; }
        public IList<Usuario>? Usuarios { get; set; }

    }
}
