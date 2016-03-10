using GdNet.Domain.Entity;
using Mapping.AutoMapper;

namespace GdNet.Layers.AutoMapper
{
    public class DefaultEditableEntityTMapperFactory<TSource, TDestination, TId> : AutoMapperFactory<TSource, TDestination>
        where TSource : class
        where TDestination : class, IEditableEntityT<TId>
        where TId : new()
    {
        protected override void OnMapperCreated()
        {
            base.OnMapperCreated();

            MappingExpression
                .ForMember(p => p.Id, a => a.Ignore())
                .ForMember(p => p.CreatedAt, a => a.Ignore())
                .ForMember(p => p.CreatedBy, a => a.Ignore())
                .ForMember(p => p.LastModifiedAt, a => a.Ignore())
                .ForMember(p => p.LastModifiedBy, a => a.Ignore())
                .ForMember(p => p.IsAvailable, a => a.Ignore())
                .ForMember(p => p.StateLastChangedAt, a => a.Ignore());
        }
    }
}