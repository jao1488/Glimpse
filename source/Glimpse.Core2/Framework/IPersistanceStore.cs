namespace Glimpse.Core2.Framework
{
    public interface IPersistanceStore:IReadOnlyPersistanceStore
    {
        void Save(GlimpseRequest request);
        void Save(GlimpseMetadata metadata);
    }
}