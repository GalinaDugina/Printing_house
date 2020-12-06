using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PH.Models
{
    public class OrderName
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Это обязательное поле :")]
        [Display(Name = "Наименование продукции")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        [NotMapped]
        public virtual  List<PartOfKit> PartOfKits{ get; set; }
    }
}