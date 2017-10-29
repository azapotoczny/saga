using System;
using System.Threading.Tasks;

namespace Saga 
{
    public class Transaction : IDisposable 
    {
        private bool disposed = false;

        private readonly IOperationInvoker operationInvoker;

        private readonly TransactionState state;

        public Transaction(IOperationInvoker operationInvoker, TransactionState state)
        {
            this.state = state;
            this.operationInvoker = operationInvoker;
        }

        public void Append(IAtomicOperation operation)
        {
            this.state.AppendedOperations.Add(operation);
        }

        public async Task CommitAsync(ICommitingOperation operation)
        {
            // TODO: save state
            await this.operationInvoker.CommitAsync(operation);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed == false)
            {
                if (disposing)
                {
                    // TODO: rollback on error
                }

                disposed = true;
            }
        }

        public Task CompleteAsync() 
        {
            return Task.CompletedTask;
        }

        public Task RollbackAsync() 
        {
            return Task.CompletedTask;
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
        }
    }
}