using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    // Constant - sabit
    public static class Messages // static: Messages class'ını new()'lemeniz gerekmez. Yani direk Messages. diye yazacağız. Sadece bir Messages olacaktır.
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımı";
        public static string ProductsListed = "Ürünler listelendi";
    }
}
