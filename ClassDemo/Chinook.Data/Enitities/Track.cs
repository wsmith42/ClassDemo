using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace Chinook.Data.Enitities
{
    [Table("Tracks")]
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        [StringLength(200, ErrorMessage = "Name is limited to 200 characters")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        public int? AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int? GenreId { get; set; }
        [StringLength(220, ErrorMessage = "Composer is limited to 220 characters")]
        public string Composer { get; set; }
        [Required(ErrorMessage ="Milliseconds is a required field")]
        [Range(1.0, double.MaxValue, ErrorMessage ="Value out of range. must be greater than zero")]
        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        [Range(0.00, double.MaxValue, ErrorMessage = "UnitPrice out of range. must be greater than zero")]
        public decimal UnitPrice { get; set; }

        //Navigation properties
        public virtual Album Album { get; set; }
        public virtual MediaType MediaType { get; set; }

        //public virtual Genre Genre{get;set;}
        //public virtual ICollection<PlaylistTrack> PlaylistTracks {get;set;}
        //public virtual ICollection<InvoiceLine> InvoiceLines{get;set;}

    }
}
