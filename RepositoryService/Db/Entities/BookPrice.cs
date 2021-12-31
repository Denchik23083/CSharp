using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Entities
{
    public class BookPrice
    {
        public int Id { get; set; }

        public int Price { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
