using Abp.Domain.Entities.Auditing;

namespace SalesManagement.Entities
{
    public class ProductConfiguration : FullAuditedEntity<long>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string TradeMark { get; set; }
        public string MainBroad { get; set; }
        public string Hhd { get; set; }
        public string Ssd { get; set; }
        public string Card { get; set; }
        public string Cpu { get; set; }
        public string Chip { get; set; }
        public string Ram { get; set; }
        public string Vga { get; set; }
        public string Screen { get; set; }
        public string KeyBroad { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public long Gurantee { get; set; }
        public long Total { get; set; }
    }
}
