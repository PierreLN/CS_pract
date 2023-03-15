using BuberBreakfast.Models;
namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfast = new();
    public void CreateBreakfast(Breakfast breakfasts)
    {
        _breakfast.Add(breakfasts.Id, breakfasts);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfast[id];
    }
}
