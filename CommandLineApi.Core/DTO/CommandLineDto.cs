using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommandLineApi.Core.DTO
{
    public class CommandLineDto
    {
        [Required]
        public string CommandName { get; set; }
        [Required]
        public string CommandSnippet { get; set; }
        [Required]
        public string TargetEnvironment { get; set; }
        [Required]
        public string OS { get; set; }
    }
}
