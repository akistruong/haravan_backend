public class Image{
    public int ID{get;set;}
    public string URL {get;set;}
    public int ProductID{get;set;}
    public DateTime? CreatedAT {get;set;}
    public DateTime? UpdatedAT{get;set;}
    public DateTime? DeletedAT{get;set;}
    public virtual Product ProductNavigation{get;set;}
}