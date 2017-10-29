using System.Threading.Tasks;

namespace Saga
{
    public interface ICommitingOperationHandler<TOperation> where TOperation : ICommitingOperation 
    {
        Task CommitAsync(ICommitingOperation operation);
    }
}