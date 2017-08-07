using GdNet.Layers.Dtos;
using Mapping.AutoMapper;

namespace GdNet.Layers.AutoMapper
{
    /// <summary>
    /// This base mapper factory will ignore the map on some properties below: Note, State, IsAvailable.
    /// Those properties should be used for some additional logics.
    /// </summary>
    public class DefaultEditableEntityDtoMapperFactory<TSource, TDestination> : AutoMapperFactory<TSource, TDestination>
        where TDestination : EditableEntityDto
    {
        protected override void OnMapperCreated()
        {
            base.OnMapperCreated();

            MappingExpression
                .ForMember(p => p.Note, a => a.Ignore())
                .ForMember(p => p.State, a => a.Ignore())
                .ForMember(p => p.IsAvailable, a => a.Ignore());
        }
    }
}
