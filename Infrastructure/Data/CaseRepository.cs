using System;
using System.Collections.Generic;
using System.Text;
using Orbium.Database;
using Core.Repositories;

namespace Infrastructure.Data
{
    public class CaseRepository : ICaseRepository
    {
        public void Update(Core.Domain.Case caseDomain)
        {
            Case _cases = new Case() {
                CaseId = caseDomain.CaseId
            };
            
            _cases.Add();
        }
    }
}
