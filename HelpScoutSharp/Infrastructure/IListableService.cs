using System.Threading.Tasks;

namespace HelpScoutSharp;

public interface IListableService<TEntity, TListOptions>
    where TEntity : IHasId
    where TListOptions : ListOptions, new()
{
    Task<IPage<TEntity>> ListAsync(TListOptions listOptions = null);
}
