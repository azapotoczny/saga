using System.Threading.Tasks;

namespace Saga
{
    public interface IOperationInvoker
    {
        Task CommitAsync(IAtomicOperation operation);
        Task CommitAsync(ICommitingOperation operation);
    }
}