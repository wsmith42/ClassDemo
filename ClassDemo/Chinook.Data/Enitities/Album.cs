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
    [Table("Albums")]
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        [Required(ErrorMessage ="Title is required.")]
        [StringLength(160,ErrorMessage ="Title exceeds maximun length of 160 characters")]
        public string Title { get; set; }
        public int ArtistId { get; set; }
        [Required(ErrorMessage ="Release year is required.")]
        public int ReleaseYear { get; set; }
        [StringLength(50, ErrorMessage = "Label exceeds maximun length of 50 characters")]
        public string ReleaseLabel { get; set; }

        //navigational properties
        //the virtual Artist property points to a single parent
        public virtual Artist Artist { get; set; }
    }
}
