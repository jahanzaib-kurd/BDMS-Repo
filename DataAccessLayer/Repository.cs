using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Database;

namespace DataAccessLayer
{
    public static class Repository
    {
        #region Area CRUD Methods
        public static List<Area> GetAreas()
        {
            using (BDMSEntities dbContext = new BDMSEntities())
            {
                try
                {
                    return dbContext.Areas.ToList();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public static List<Area> GetAreas(string AreaId)
        {
            try
            {
                using (BDMSEntities dbContext = new BDMSEntities())
                {
                    return (dbContext.Areas.Any(x => x.AreaId.Equals(AreaId)) ? dbContext.Areas.Where(x => x.AreaId.Equals(AreaId)).ToList() : null);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void UpdateArea(Area updatedArea)
        {
            try
            {
                using (BDMSEntities dbContext = new BDMSEntities())
                {
                    Area area = dbContext.Areas.FirstOrDefault(x => x.AreaId.Equals(updatedArea.AreaId));
                    if (area != null)
                    {
                        area = updatedArea;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void InsertArea(Area area)
        {
            try
            {
                using (BDMSEntities dbContext = new BDMSEntities())
                {
                    dbContext.Areas.Add(area);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

    }
}
