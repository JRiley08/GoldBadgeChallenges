using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class ClaimDataRepo
    {
        Queue<ClaimData> _claimInfo = new Queue<ClaimData>();

        public void AddClaimToQueue(ClaimData claim)
        {
            _claimInfo.Enqueue(claim);
        }
        public Queue<ClaimData> GetClaimInfo()
        {
            return _claimInfo;
        }
        public ClaimData NextClaim()
        {
            ClaimData claim = _claimInfo.Peek();
            return claim; 
        }
        public void RemoveClaimFromQueue()
        {
            _claimInfo.Dequeue();
        }
    }
}
