namespace HelpScoutSharp
{
    public interface IPage<TEntity>
    {
        Page page { get; }

        TEntity[] entities { get; }
    }
}
