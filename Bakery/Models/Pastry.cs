namespace Bakery.Models
{
  public class Pastry
  {
    public int NumPastry {get; set;}
    
    public Pastry(int numPastry)
    {
      NumPastry = numPastry;
    }
    
    public int PastryPrice()
    {
      if (NumPastry % 3 == 0)
      {
        int price = (NumPastry / 3) * 5;
        return price;
      }
      else if (NumPastry % 3 == 1)
      {
        return ((NumPastry - 1) / 3) * 5 + 2;
      }
      else if (NumPastry % 3 == 2)
      {
        return ((NumPastry - 1) / 3) * 5 + (2 * 2);
      }
      else
      {
        return 0;
      }
    }
  }
}