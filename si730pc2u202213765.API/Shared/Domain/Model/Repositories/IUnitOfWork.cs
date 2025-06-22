namespace si730pc2u202213765.API.Shared.Domain.Model.Repositories;

public interface IUnitOfWork
{
    /// <summary>
    ///     Commit changes to the database
    /// </summary>
    Task CompleteAsync();
}