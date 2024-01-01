using Merchgram.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchgram.Application
{
    public interface IMerchRepository
    {
        List<Merch> GetAllMerches();
    }
}
