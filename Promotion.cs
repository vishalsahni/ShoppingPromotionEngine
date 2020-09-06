using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingPromotionNew
{
   

  public  interface IPromotion
    {

      int PromotionQuantity {get; set;}
      int PromotionDiscount { get; set; }

      int ApplyDiscount(Cart cart);

    }

 



  public class APromotion : IPromotion
  {

      public int PromotionQuantity { get; set; }
      public int PromotionDiscount { get; set; }

      public APromotion()
      {
          PromotionQuantity = 3;
          //3 of A price is Rs.130 Not Rs. 150 which is actual price so total discount of 20.
          PromotionDiscount = 20;

      }

      public int ApplyDiscount(Cart cart)
      {

          PromotionQuantity = Convert.ToInt32(cart.ProductTypeWithQuantity["A"])/ PromotionQuantity;

          return (PromotionQuantity * PromotionDiscount);


      }

  }


  public class BPromotion : IPromotion
  {

      public int PromotionQuantity { get; set; }
      public int PromotionDiscount { get; set; }

      public BPromotion()
      {
          PromotionQuantity = 2;

          //2 of B price is Rs.45 Not Rs. 60 which is actual price so total discount of 15.
          PromotionDiscount = 15;
         
      }

      public int ApplyDiscount(Cart cart)
      {

          PromotionQuantity = Convert.ToInt32(cart.ProductTypeWithQuantity["B"]) / PromotionQuantity;

          return (PromotionQuantity * PromotionDiscount);


      }

  }


  public class CDPromotion : IPromotion
  {
     
       public int PromotionQuantity { get; set; }
      public Dictionary<string, int> ProductTypeQuantity { get; set; }
      public int PromotionDiscount { get; set; }

     public  CDPromotion()
      {
          ProductTypeQuantity = new Dictionary<string, int>();

          ProductTypeQuantity.Add("C", 1);

          ProductTypeQuantity.Add("D", 1);

          PromotionQuantity = 2;

          PromotionDiscount = 5;

      }

      public int ApplyDiscount(Cart cart)
      {

          if (cart.ProductTypeWithQuantity.ContainsKey("C") && cart.ProductTypeWithQuantity.ContainsKey("D"))
          {


              if (Convert.ToInt32(cart.ProductTypeWithQuantity["C"]) > Convert.ToInt32(cart.ProductTypeWithQuantity["D"]))
              {


                  return (Convert.ToInt32(cart.ProductTypeWithQuantity["D"]) * PromotionDiscount);



              }
              else
              {

                  return (Convert.ToInt32(cart.ProductTypeWithQuantity["C"]) * PromotionDiscount);

              }
          }
          else
          {

              return 0;
          }


       


      }

  }


}
