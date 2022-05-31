using Siparis.Entity.Abstract;

namespace Siparis.Entity.Concrete
{
    public class Personel : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public IColelection<SiparisMaster> Siparisler { get; set; }

    }
}