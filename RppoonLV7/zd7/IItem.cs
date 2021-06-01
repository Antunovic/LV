namespace zd7
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }

}
