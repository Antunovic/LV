namespace zd6
{
    interface IVisitor
    {
        double Visit(DVD DVDItem);
        double Visit(VHS VHSItem);

        double Visit(Book bookItem);
    }

}
