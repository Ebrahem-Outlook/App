namespace Domain.Core.Base;

/// <summary>
/// Represint the entity base calss for all entities
/// </summary>
public abstract class Entity
{
    /// <summary>
    /// Initialize new instance of entity class.
    /// </summary>
    protected Entity(Guid id) =>  Id = id;

    /// <summary>
    /// Get identifier for entity
    /// </summary>
    protected Guid Id { get; private set; }

    /// <summary>
    /// Required by EF Core.
    /// </summary>
    protected Entity() { }
}
