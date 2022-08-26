namespace VisTu.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [MaxLength(50), MinLength(3)]
        [Required(ErrorMessage = "Favor informar seu nome")]
        public string Nome { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Favor informar um email válido")]
        public string Email { get; set; }
        [Phone]
        public int Celular { get; set; }  
        public Setor Setor { get; set; }
        [StringLength(maximumLength: 128, MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Favor informar a senha")]
        public string Senha { get; set; }
        public string Salt { get; set; }

    }
}
