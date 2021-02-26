namespace Bakery.Models
{
  public class Bread
  {
    public int NumBread {get; set;}
    public static int Price(int num)
    {
      int NumBread = num;
      int price = 5;

      if (NumBread == 1)
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