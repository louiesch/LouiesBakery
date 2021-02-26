namespace Bakery.Models
{
  public class Bread
  {
    public int NumBread {get; set;}
    
    //Bread: Buy 2, get 1 free. A single loaf costs $5.
    public static int Price(int num)
    {
      int NumBread = num;
      int price = 5;

      if (NumBread == 1 || NumBread == 2)
      {
        return num * price;
      }
      else
      {
        return 0;
      }
    }
  }
}