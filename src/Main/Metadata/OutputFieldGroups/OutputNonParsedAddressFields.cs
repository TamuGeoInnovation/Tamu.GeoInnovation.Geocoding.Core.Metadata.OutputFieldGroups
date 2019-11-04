using System.Collections.Generic;
using USC.GISResearchLab.Common.Databases.FieldMappings;
using USC.GISResearchLab.Common.Databases.TypeConverters;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.OutputFields
{
    public class OutputNonParsedAddressFields
    {

        public static List<DatabaseFieldMapping> GetOutputFields()
        {
            return GetOutputFields(null);
        }

        public static List<DatabaseFieldMapping> GetOutputFields(string prefix)
        {
            List<DatabaseFieldMapping> ret = new List<DatabaseFieldMapping>();

            ret.Add(new DatabaseFieldMapping(prefix + "Address", DatabaseSuperDataType.LongText));
            ret.Add(new DatabaseFieldMapping(prefix + "City", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "State", DatabaseSuperDataType.String, 50));
            ret.Add(new DatabaseFieldMapping(prefix + "Zip", DatabaseSuperDataType.String, 50));

            return ret;
        }
    }
}
