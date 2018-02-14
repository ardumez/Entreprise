
namespace Entreprise.Models
{
    public class Lead
    {
        public long LeadID { get; set; }
        public string Name { get; set; }
        public Provider Provider { get; set; }
    }
}