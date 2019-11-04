using System.Collections.Generic;
using USC.GISResearchLab.Common.Databases.FieldMappings;
using USC.GISResearchLab.Common.Databases.TypeConverters;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.OutputFields
{
    public class OutputAddressFields
    {

        public static List<DatabaseFieldMapping> GetOutputFields()
        {
            return GetOutputFields(null);
        }

        public static List<DatabaseFieldMapping> GetOutputFields(string prefix)
        {
            List<DatabaseFieldMapping> ret = new List<DatabaseFieldMapping>();

            ret.Add(new DatabaseFieldMapping(prefix + "Number", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "NumberFractional", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PreDirectional", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PreQualifier", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PreType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PreArticle", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "Name", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PostArticle", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PostQualifier", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "Suffix", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PostDirectional", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "SuiteType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "SuiteNumber", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "City", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "ConsolidatedCity", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "MinorCivilDivision", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "CountySubRegion", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "County", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "State", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "Zip", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "ZipPlus1", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "ZipPlus2", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "ZipPlus3", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "ZipPlus4", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "ZipPlus5", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PostOfficeBoxType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "PostOfficeBoxNumber", DatabaseSuperDataType.String, 255));

            return ret;
        }
    }
}
