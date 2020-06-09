using System.Collections.Generic;

namespace Client.Models
{
    public class RootObject
    {
        public string ObjectIdFieldName { get; set; }
        public UniqueIdField UniqueIdField { get; set; }
        public string GlobalIdFieldName { get; set; }
        public string GeometryType { get; set; }
        public SpatialReference SpatialReference { get; set; }
        public List<Field> Fields { get; set; }
        public List<Feature> Features { get; set; }
    }
}
