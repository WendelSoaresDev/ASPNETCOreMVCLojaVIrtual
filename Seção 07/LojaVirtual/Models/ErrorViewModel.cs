using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class ErrorViewModel
    {
        public string RequestID { get; set; }

        public bool ShowRequesId => !string.IsNullOrEmpty(RequestID);
    }
}
