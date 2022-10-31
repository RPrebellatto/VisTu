namespace VisTu.Models
{
    public class Vistoria
    {
        public int Id { get; set; }
        [Display(Name = "Tubulação")]
        public int TubulacaoId { get; set; }
        [Display(Name = "Tubulação")]
        public Tubulacao Tubulacao { get; set; }
        [Display(Name = "Data da Vistoria")]
        public DateTime DataVistoria { get; set; }
        [Display(Name = "Usuário da Vistoria")]
        public int UsuarioVistoriaId { get; set; }
        [Display(Name = "Usuário da Vistoria")]
        public Usuario UsuarioVistoria { get; set; }
        [Display(Name = "Data do Reparo")]
        public DateTime? DataReparo { get; set; }                 
        public string? Observação { get; set; }
    }
}
