using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Case
    {
        public int CaseId { get; set; }
        public string Descricao { get; set; }
        public int ProcessId { get; set; }
    }
}
