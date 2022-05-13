

namespace CommandLineApi.Models
{
    public class Command
    {
        public int CommandId { get; set; }
        public string CommandCode { get; set; }
        public string CommandUsage { get; set; }
        public string UseEnvironment { get; set; } 
        public string OS { get; set; }

    }
}