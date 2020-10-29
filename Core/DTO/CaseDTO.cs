using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class CaseDTO
    {
        public int CaseId { get; set; }
        public string Descricao { get; set; }
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public int ProcessUserId { get; set; }
    }
}
