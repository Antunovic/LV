namespace zd7
{
    interface IVisitor
    {
        double Visit(DVD DVDItem);
        double Visit(VHS VHSItem);

        double Visit(Book bookItem);
    }

}
