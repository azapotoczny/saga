using System.Collections.Generic;

namespace Saga
{
    public class TransactionState 
    {
        public TransactionStatus Status { get; set; }
        public List<IAtomicOperation> AppendedOperations { get; } = new List<IAtomicOperation>();

        public TransactionState()
        {
            this.Status = TransactionStatus.Pending;
        }
    }
}