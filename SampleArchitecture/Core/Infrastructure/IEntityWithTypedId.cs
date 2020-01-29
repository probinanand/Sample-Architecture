namespace TestArchitecture.Core.Infrastructure.Common
{
    public interface IEntityWithTypedId<TId>
    {
        TId Id { get; }
    }
}
