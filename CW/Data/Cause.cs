
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
namespace CW.Data
{
        public class Cause
        {

            public int CauseId { get; set; }

            [MaxLength(25)]
            public string Title { get; set; }

            public byte[] Image { get; set; }

            public string Description { get; set; }

            public string Category { get; set; }
            public List<string> Signatures { get; set; }

        public Cause()
        {
            Signatures = new List<string>(); // Initialize the Signatures property
        }

    }
    }

