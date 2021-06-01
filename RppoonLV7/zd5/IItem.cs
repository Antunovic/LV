namespace zd5
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }

}
