using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{

    //Constant mesajları vs. içeren bölümdür.
   public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime=" Sistem bakımda";
        public static string ProductsListed=" Ürünler listelendi";
        public static string ProductCountofCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded="Kategori Limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
