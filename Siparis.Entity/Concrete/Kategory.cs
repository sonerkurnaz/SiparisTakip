using Siparis.Entity.Abstract;
using System.Collections.Generic;

namespace Siparis.Entity.Concrete
{
    public class Kategory : BaseEntity
    {
        public string KategoriKodu { get; set; }
        public string Aciklama { get; set; }
        public IList<SiparisMaster> Siparisler { get; set; }
    }
}