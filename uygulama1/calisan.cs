using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama1
{
    public class calisan
    {
        private int id;
        private string isim;
        private string soyisim;

        public calisan(int id, string isim, string soyisim)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
        }
        public int getId() { return this.id; }
        public void setId(int id) { this.id = id;}
        public string getIsim() {  return this.isim; }
        public void setIsim(string isim) {  this.isim = isim; }
        public string getSoyisim() {  return this.soyisim; }
        public  string setSoyisim(string soyisim) { return this.soyisim; }

        public void bilgileriGoster()
        {
            Console.WriteLine("id: "+id);
            Console.WriteLine("isim: "+isim);
            Console.WriteLine("soyisim: "+soyisim);
        }


    }
}
