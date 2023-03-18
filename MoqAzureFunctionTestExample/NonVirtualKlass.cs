using System.Threading.Tasks;

namespace MyFunctions;

public class NonVirtualKlass
{
   private int Number { get; set; }

   public NonVirtualKlass(int number)
   {
      Number = number;
   }
   
   public async Task<int> GetNumber()
   {
      await Task.Delay(1000);
      return Number;
   }
}