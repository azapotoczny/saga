namespace Saga
{
    public interface IOperationHandlerLocator 
    {
        object GetAtomicOperationHandler(IAtomicOperation operation);

        object GetCommitingOperationHandler(ICommitingOperation operation);
    }
}