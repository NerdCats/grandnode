using System;

namespace Grand.Core.Data
{
    public static class CollectionExtensions
    {
        private static string CollectionNamePrefix = "GrandNode.";
        public static string GetCollectionName(this Type entityType)
        {
            if (!typeof(BaseEntity).IsAssignableFrom(entityType))               
                throw new ArgumentException(nameof(entityType));

            return CollectionNamePrefix + entityType.Name;
        }
    }
}
