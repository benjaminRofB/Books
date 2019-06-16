
using System.ComponentModel.DataAnnotations;

namespace Books
{
    public class Book
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }
        public int? Year { get; set; }
        public int NameId { get; set; }
        public virtual Name Name { get; set; }

    }
}
