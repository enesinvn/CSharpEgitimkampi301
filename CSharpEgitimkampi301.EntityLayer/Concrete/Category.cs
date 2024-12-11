using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimkampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId{ get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
/*
 Field-Variable-Property
 */

/*
 Bir değişken direkt sınıfın içine tanımlanırsa. -> Field
 int x; --> Field

 Eğer sonuna get; ve set; alırsa -> Property
 public int y { get; set; }

 Eğer bir değer metot içinde tanımlıysa -> Variable
 void test()
 {
    int z;
 }
 */
