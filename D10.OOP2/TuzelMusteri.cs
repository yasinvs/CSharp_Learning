using System;
using System.Collections.Generic;
using System.Text;

namespace D10.OOP2
{
    //Corporate
    //Inheritance -- Miras alma
    //Müşteri classında olan bütün bilgiler TuzelMusteri Classında da olur
    class TuzelMusteri : Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
