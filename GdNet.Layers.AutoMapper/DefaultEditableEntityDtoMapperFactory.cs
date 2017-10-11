using GdNet.Layers.Dtos;
using Mapping.AutoMapper;

namespace GdNet.Layers.AutoMapper
{
    /// <summary>
    /// This base mapper factory will ignore the map on some properties below: Note.
    /// Those properties should be used for some additional logics.
    /// </summary>
    public class DefaultEditableEntityDtoMapperFactory<TSource, TDestination> : AutoMapperFactory<TSource, TDestination>
        where TDestination : EditableEntityDto
    {
        /// <summary>
        /// Inherites creation from base class and configured to ignore some properties.
        /// </summary>
        protected override void OnMapperCreated()
        {
            base.OnMapperCreated();

            MappingExpression
                .ForMember(p => p.Note, a => a.Ignore());
        }
    }
}
