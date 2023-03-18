using System.Threading.Tasks;

namespace MyFunctions;

public class NonVirtualKlassWrapper : NonVirtualKlass
{
    public NonVirtualKlassWrapper(int number) : base(number)
    {
        
    }

    public virtual async Task<int> GetNumber()
    {
        return 2;
    }
}