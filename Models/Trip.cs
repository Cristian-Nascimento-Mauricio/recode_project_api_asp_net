using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace recode_work_api.Models
{
    [Table("trips")]
    public class Trip{

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe a descripção")]
        [StringLength(5000)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Informe a destino")]
        [StringLength(100)]
        public string Destiny { get; set; }

        [Required(ErrorMessage = "Informe a embarque")]
        [StringLength(100)]
        public string Boarding { get; set; }

        public double Price { get; set; }

        public double Promotion { get; set; }

        [Required(ErrorMessage = "Informe a data")]
        [StringLength(25)]
        public string Date { get; set; }

    }
}
