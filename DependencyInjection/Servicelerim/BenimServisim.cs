namespace DependencyInjection.Servicelerim
{

    public class BenimServisim
    {
        public BenimServisim()
        {
            this.ServiceId = Guid.NewGuid();
        }
        public Guid ServiceId { get; }
        public int Sayac { get; set; } = 0;

        public string Print()
        {
            Sayac++;
            return $"{ServiceId} / {Sayac}\n";
        }
    }
}
