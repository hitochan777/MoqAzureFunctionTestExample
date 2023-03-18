using System.Threading.Tasks;

namespace MyFunctions;

public class NumberGeneratorWrapper : NumberGenerator
{
    public NumberGeneratorWrapper(int number) : base(number)
    {
        
    }

    public virtual int GetNumber()
    {
        return 2;
    }
}