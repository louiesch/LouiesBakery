namespace Bakery.Models
{
  public class Bread
  {
    public int NumBread {get; set;}    
    public static int Price(int num)
    {
      int NumBread = num;
      int price = 5;
      int freeBread = NumBread / 3;

      if (NumBread == 1 || NumBread == 2)
      {
        return num * price;
      }
      else if (NumBread % 3 == 0)
      {
        return (NumBread - freeBread) * price;
      }
      else if (NumBread % 2 == 0 || NumBread % 2 == 1)
      {
        return (NumBread - freeBread) * price;
      }
        else
      {
        return 0;
      }
    }
  }
}