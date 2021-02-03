using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Çıplak Class Kalmasın
    public class Category:IEntity // kızarsa: bu satırın solunda çıkan ampülden using'i seç
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
