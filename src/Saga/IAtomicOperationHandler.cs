using System.Threading.Tasks;

namespace Saga
{
    public interface IAtomicOperationHandler<TOperation> where TOperation : IAtomicOperation
    {
        Task CommitAsync();
        Task CompensateAsync();
    }
}