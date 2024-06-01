using System.ComponentModel.DataAnnotations;



public class Item

{
    public Item(){ 
    }
    public Item(string name, string description, int quantity){
        
        this.Name = name;
        this.Description = description;
        this.Quantity = quantity;
        
    }
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public int Quantity { get; set; }
}