using System.Collections.Generic;
using USC.GISResearchLab.Common.Databases.FieldMappings;
using USC.GISResearchLab.Common.Databases.TypeConverters;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.OutputFields
{
    public class OutputReferenceFeatureFields : OutputAddressFields
    {
        public new static List<DatabaseFieldMapping> GetOutputFields()
        {
            return GetOutputFields(null);
        }

        public new static List<DatabaseFieldMapping> GetOutputFields(string prefix)
        {
            List<DatabaseFieldMapping> ret = OutputAddressFields.GetOutputFields(prefix);

            ret.Add(new DatabaseFieldMapping(prefix + "PrimaryIdField", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PrimaryIdValue", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "SecondaryIdField", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "SecondaryIdValue", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "Area", DatabaseSuperDataType.Float));
            ret.Add(new DatabaseFieldMapping(prefix + "AreaType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "Geometry", DatabaseSuperDataType.LongText));
            ret.Add(new DatabaseFieldMapping(prefix + "GeometrySRID", DatabaseSuperDataType.Int32));
            ret.Add(new DatabaseFieldMapping(prefix + "Source", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "Vintage", DatabaseSuperDataType.String, 255));

            return ret;
        }
    }
}
