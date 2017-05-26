using System;
using System.Collections.Generic;
using USC.GISResearchLab.Common.Databases.FieldMappings;
using USC.GISResearchLab.Common.Databases.TypeConverters;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.OutputFields
{
    [Serializable]
    public class OutputGeocodeFields
    {

        public static List<DatabaseFieldMapping> GetOutputFields()
        {
            return GetOutputFields(null);
        }

        public static List<DatabaseFieldMapping> GetOutputFields(string prefix)
        {
            List<DatabaseFieldMapping> ret = new List<DatabaseFieldMapping>();

            ret.Add(new DatabaseFieldMapping(prefix + "Latitude", DatabaseSuperDataType.Decimal));
            ret.Add(new DatabaseFieldMapping(prefix + "Longitude", DatabaseSuperDataType.Decimal));
            ret.Add(new DatabaseFieldMapping(prefix + "MatchScore", DatabaseSuperDataType.Decimal));
            //PAYTON:MicroMatchStatus
            ret.Add(new DatabaseFieldMapping(prefix + "MicroMatchStatus", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "MatchType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "RegionSize", DatabaseSuperDataType.Decimal));
            ret.Add(new DatabaseFieldMapping(prefix + "RegionSizeUnits", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "GeocodeQualityType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "NAACCRQualCode", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "NAACCRQualType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "LocationType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "FM_ResultType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "FM_ResultCount", DatabaseSuperDataType.Int32));
            ret.Add(new DatabaseFieldMapping(prefix + "FM_Notes", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "FM_TieNotes", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "FM_TieStrategy", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "InterpolationType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "InterpolationSubType", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "FM_SelectionMethod", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "FM_SelectionNotes", DatabaseSuperDataType.String, 255));
            ret.Add(new DatabaseFieldMapping(prefix + "FM_GeographyType", DatabaseSuperDataType.String, 255));
            
            return ret;
        }
    }
}
