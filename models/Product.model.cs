public class Product{
    public Product()
    {
        Images = new HashSet<Image>();
    }
    public int ID {get;set;}
    public string Name{get;set;}
    public int SupplierID{get;set;}
    public decimal ? Price{get;set;}
    public string ? Slug{get;set;}
    public DateTime? CreatedAT {get;set;}
    public DateTime? UpdatedAT{get;set;}
    public DateTime? DeletedAT{get;set;}
    public virtual Supplier SupplierNavigation{get;set;}   
    public virtual HashSet<Image> Images{get;set;}
}