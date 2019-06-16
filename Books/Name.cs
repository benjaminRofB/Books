
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Books
{
    public class Name
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string SName { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }
}
