using System;
using System.Collections.Generic;
using System.Text;

namespace D10.OOP2
{
    //Individual
    //Inheritance -- Miras alma
    //Müşteri classında olan bütün bilgiler TuzelMusteri Classında da olur
    class GercekMusteri : Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
