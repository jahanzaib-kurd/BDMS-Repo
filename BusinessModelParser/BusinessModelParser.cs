using BusinessModels;
using DataAccessLayer;
using DataAccessLayer.Database;
using System.Collections.Generic;
namespace BusinessLogicLayer
{
    public static class BusinessModelParser
    {
        public static List<AreaModel> GetAreas()
        {
            List<AreaModel> areas = new List<AreaModel>();
            foreach (Area dbArea in Repository.GetAreas())
            {
                AreaModel area = new AreaModel();
                area.AreaId = dbArea.AreaId.ToString();
                area.AreaCode = dbArea.AreaCode;
                area.AreaName = dbArea.AreaName;
                area.IsDeleted = dbArea.IsDeleted;
                areas.Add(area);
            }
            return areas;
        }

        public static void UpdateArea()
        {
        }
    }
}
