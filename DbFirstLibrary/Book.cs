﻿using System;
using System.Collections.Generic;

namespace DbFirstLibrary;

public partial class Book
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public long YearOfPubliction { get; set; }

    public long AuthorId { get; set; }

    public virtual Author Author { get; set; } = null!;
}
