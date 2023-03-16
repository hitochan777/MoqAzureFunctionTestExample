using System.Threading.Tasks;

namespace MyFunctions;

public class Klass
{
   private int Number { get; set; }
   public Klass() {}

   public Klass(int number)
   {
      Number = number;
   }
   
   public virtual async Task<int> GetNumber()
   {
      await Task.Delay(1000);
      return Number;
   }
}