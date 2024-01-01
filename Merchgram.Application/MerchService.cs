using Merchgram.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchgram.Application
{
    internal class MerchService : IMerchService
    {
        private readonly IMerchRepository _merchRepository;

        public MerchService(IMerchRepository merchRepository)
        {
            _merchRepository = merchRepository;
        }

        public List<Merch> GetAllMerches()
        {
            var merches = _merchRepository.GetAllMerches();

            return merches; 
        }
    }
}
