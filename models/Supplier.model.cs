public class Supplier{
    public Supplier()
    {
        Products = new HashSet<Product>();
    }
    public int ID{get;set;}
    public int Name{get;set;}
    public virtual HashSet<Product> Products{get;set;}
}