using GdNet.Domain.Entity;
using Mapping.AutoMapper;

namespace GdNet.Layers.AutoMapper
{
    /// <summary>
    /// This base mapper factory will ignore the map on some properties below: Id, CreatedAt, CreatedBy, LastModifiedAt, LastModifiedBy, Note, IsAvailable, StateLastChangedAt.
    /// Those properties should be used for some additional logics.
    /// </summary>
    public class DefaultEditableEntityTMapperFactory<TSource, TDestination, TId> : AutoMapperFactory<TSource, TDestination>
        where TSource : class
        where TDestination : class, IEditableEntityT<TId>
        where TId : new()
    {
        /// <summary>
        /// Inherites creation from base class and configured to ignore some properties.
        /// </summary>
        protected override void OnMapperCreated()
        {
            base.OnMapperCreated();

            MappingExpression
                .ForMember(p => p.Id, a => a.Ignore())
                .ForMember(p => p.CreatedAt, a => a.Ignore())
                .ForMember(p => p.CreatedBy, a => a.Ignore())
                .ForMember(p => p.LastModifiedAt, a => a.Ignore())
                .ForMember(p => p.LastModifiedBy, a => a.Ignore())
                .ForMember(p => p.Note, a => a.Ignore())
                .ForMember(p => p.IsAvailable, a => a.Ignore())
                .ForMember(p => p.StateLastChangedAt, a => a.Ignore());
        }
    }
}