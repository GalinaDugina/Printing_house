using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PH.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity{ get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public DateTime DateOfCreator{ get; set; }= DateTime.Today;
        public DateTime DateOfShipment{ get; set; }
      
      
    }
}