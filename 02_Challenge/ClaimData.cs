using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public enum ClaimType {Car, House, Theft}

    public class ClaimData
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAC { get; set; }
        public DateTime DateC { get; set; }
        public bool IsValid { get; set; }

        public ClaimData(int claimID, ClaimType claimtype, string description, decimal amount, DateTime dateAC, DateTime dateC)
        {
            ClaimID = claimID;
            ClaimType = claimtype;
            Description = description;
            Amount = amount;
            DateAC = dateAC;
            DateC = dateC;
            IsValid = dateC - dateAC < TimeSpan.FromDays(30);

        }
        public ClaimData()
        {

        }
    }
}
