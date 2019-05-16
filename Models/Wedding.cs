using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WeddingPlanner.Models
{
    public class Wedding
    {
      [Key]
        public int WeddingId {get;set;}
        [Required]
        [MinLength(2)]
        public string WedderOne {get;set;}
        [Required]
        [MinLength(2)]
        public string WedderTwo {get;set;}
        [Required]
        public string Address { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date {get;set;}

        public List<Reservation> GuestList {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}