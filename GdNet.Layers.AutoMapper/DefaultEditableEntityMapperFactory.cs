using System;
using GdNet.Domain.Entity;

namespace GdNet.Layers.AutoMapper
{
    public class DefaultEditableEntityMapperFactory<TSource, TDestination> : DefaultEditableEntityTMapperFactory<TSource, TDestination, Guid>
        where TSource : class
        where TDestination : class, IEditableEntity
    {
    }
}
