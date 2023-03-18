namespace MyFunctions;

public class NumberGenerator
{
   private int Number { get; set; }

   public NumberGenerator(int number)
   {
      Number = number;
   }
   
   public int GetNumber()
   {
      return Number;
   }
}