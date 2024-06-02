using Microsoft.EntityFrameworkCore;

public class InventoryService
{
    private readonly IMDatabaseContext _context;

    public InventoryService(IMDatabaseContext context)
    {
        _context = context;
    }

    public async Task DeleteItemAsync(int itemId)
    {
        var item = await _context.Items.FindAsync(itemId);
        if (item != null)
        {
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
    public async Task UpdateItemAsync(Item item){
        if(item != null){
            _context.Items.Update(item);
            await _context.SaveChangesAsync();
        }
    }
    public async Task AddItemAsync(Item item)
    {
        if (item != null)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<List<Item>> GetInventoryItemsAsync()
    {
        return await _context.Items.ToListAsync();
    }
    public async Task<List<Item>> SearchItemsAsync(string partialName)
    {
        return await _context.Items
            .Where(i => i.Name.Contains(partialName))
            .ToListAsync();
    }
    
}