namespace DbFirstLibrary;

public partial class Book
{
    public override string ToString()
    {
        return $"{Title} {YearOfPublication}";
    }
}
