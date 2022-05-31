﻿using Siparis.Entity.Abstract;
using System.Collections.Generic;

namespace Siparis.Entity.Concrete
{
    public class Personel : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public ICollection<SiparisMaster> Siparisler { get; set; }

    }
}