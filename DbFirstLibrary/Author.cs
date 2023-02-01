using System;
using System.Collections.Generic;

namespace DbFirstLibrary;

public partial class Author
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
