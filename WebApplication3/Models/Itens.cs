using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication3.Models
{
    [Table("Notas Fiscais")]
    public class Itens
    {
        [Column("Id")]
        [Display(Name = "ID")]
        [Key]
        public Guid notaFiscalId { get; set; }
        [Column("numeroNf")]
        [Display(Name = "Nota Fiscal")]
        public string numeroNf { get; set; }
        [Column("valorTotal")]
        [Display(Name = "Valor Total")]
        public float valorTotal { get; set; }
        [Column("dataNf")]
        [Display(Name = "Data")]
        public string dataNf { get; set; }
        [Column("cnpfEmissorNf")]
        [Display(Name = "CNPJ EMISSOR")]
        public string cnpjEmissorNf { get; set; }
        [Column("cnpjDestinatarioNf")]
        [Display(Name = "CNPJ DESTINATARIO")]
        public string cnpjDestinatarioNf { get; set; }
    }
    
}
