using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingPromotionNew
{
   public interface IProductType
    {

      string productName {get; set;}
      int productPrice {get; set;}

    }

   public class A : IProductType
   {

      
      public A()
       {
           productName = "A";
           productPrice = 50;
       }

       public int productPrice { get; set; }
       public string productName{get; set;}



       }
   

   public class B : IProductType
   {

      public B()
       {
           productName = "B";
           productPrice = 30;
          
       }

      public int productPrice { get; set; }
      public string productName { get; set; }

     


   }
   public class C : IProductType
   {

      public C()
       {
           productName = "C";
           productPrice = 20;
       }

       public int productPrice { get; set; }
       public string productName { get; set; }


   }

   public class D : IProductType
   {

      public D()
       {
           productName = "C";
           productPrice = 15;
       }

      public int productPrice { get; set; }
      public string productName { get; set; }
   }




}
