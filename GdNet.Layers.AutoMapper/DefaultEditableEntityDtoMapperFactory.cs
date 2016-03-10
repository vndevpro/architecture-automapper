using GdNet.Layers.Dtos;
using Mapping.AutoMapper;

namespace GdNet.Layers.AutoMapper
{
    public class DefaultEditableEntityDtoMapperFactory<TSource, TDestination> : AutoMapperFactory<TSource, TDestination>
        where TDestination : EditableEntityDto
    {
        protected override void OnMapperCreated()
        {
            base.OnMapperCreated();

            MappingExpression
                .ForMember(p => p.Note, a => a.Ignore())
                .ForMember(p => p.State, a => a.Ignore())
                .ForMember(p => p.CreatedAt, a => a.Ignore())
                .ForMember(p => p.CreatedBy, a => a.Ignore())
                .ForMember(p => p.LastModifiedAt, a => a.Ignore())
                .ForMember(p => p.LastModifiedBy, a => a.Ignore())
                .ForMember(p => p.IsAvailable, a => a.Ignore());
        }
    }
}
