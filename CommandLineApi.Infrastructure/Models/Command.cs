using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Infrastructure.Models
{
    public class Command
    {
        public string CommandId { get; set; }
        public string CommandName { get; set; }
        public string CommandSnippet { get; set; }
        public string TargetEnvironment { get; set; }
        public string OS { get; set; }

    }
}
