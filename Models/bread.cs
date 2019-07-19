using System;

namespace GreenHouse.plant
{
  class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadQty { get; set; }
    public int BreadTotal { get; set; }


    public Bread(int breadqty)
    {
      BreadPrice = 5;
      BreadQty = breadqty;
      BreadTotal = BreadAddTotal();
    }

    private void BreadAddTotal()
    {
      int freeBread = BreadQty / 3;
      int breadtotal = (BreadQty - freeBread) * BreadPrice);
      return breadtotal;
    }
  }

  class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryDeal { get; set; }
    public int PastryQty { get; set; }
    public int PastryTotal { get; set; }


    public Pastry(int pastryqty)
    {
      PastryPrice = 2;
      PastryDeal = 5;
      PastryQty = pastryqty;
      PastryTotal = PastryAddTotal();
    }

    private void PastryAddTotal()
    {
      int qtyPrice = PastryQty % 3;
      int qtyDeal = PastryQty / 3;
      int pastrytotal = (qtyPrice * PastryPrice) + (qtyDeal * PastryDeal);
      return pastrytotal;
    }
  }
}
