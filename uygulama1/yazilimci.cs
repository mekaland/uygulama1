using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama1
{
    public class yazilimci : calisan
    {
        private string diller;
        public yazilimci(int id, string isim, string soyisim, string diller) : base(id, isim, soyisim)
        {
            this.diller = diller;
            //base benim miras almış olduğum classımın yapıcı metodunu temsil eder
        }
        public void formatAt(string isletim_sistemi)
        {
            Console.WriteLine(getIsim() + "suanda"+ "" + isletim_sistemi + "isletim sistemine format atıyor");
        }
    }
}
