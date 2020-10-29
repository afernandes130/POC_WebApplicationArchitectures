using Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repositories
{
    public interface ICaseRepository
    {
        void Update(Case caseDomain);
    }
}
