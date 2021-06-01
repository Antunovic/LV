namespace zd6
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }

}
