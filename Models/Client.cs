using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PH.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Это обязательное поле :")]
        [Display(Name = "Наименование заказчика")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [NotMapped] 
        public virtual List<OrderName> OrderNames { get; set; }
    }
}