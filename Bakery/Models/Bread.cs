namespace Bakery.Models
{
  public class Bread
  {
    public int NumBread {get; set;}    

    public Bread(int numBread)
    {
      NumBread = numBread;
    }

    public int BreadPrice()
    {
      if (NumBread % 3 == 0)
      {
        int orderTotal = (NumBread - (NumBread / 3)) * 5;
        return orderTotal;
      }
      else
      {
        return NumBread * 5;
      }
    }
  }
}