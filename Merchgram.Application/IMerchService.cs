using Merchgram.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchgram.Application
{
    // In the Application Layer we have the use cases aka business logic.
    // we refrence only the Domain layer 
    public interface IMerchService
    {
        List<Merch> GetAllMerches();
    }
}
