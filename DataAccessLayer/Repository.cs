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
                try { return (dbContext.Areas != null ? dbContext.Areas.ToList() : null); }
                catch (Exception ex)
                {
                    throw;
                }
                finally { dbContext.Dispose(); }
            }
        }

        public static List<Area> GetAreas(string AreaId)
        {
            using (BDMSEntities dbContext = new BDMSEntities())
            {
                try { return (dbContext.Areas.Any(x => x.AreaId.Equals(AreaId)) ? dbContext.Areas.Where(x => x.AreaId.Equals(AreaId)).ToList() : null); }
                catch (Exception ex)
                {
                    throw;
                }
                finally { dbContext.Dispose(); }
            }
        }

        public static void UpdateArea(Area updatedArea)
        {
            using (BDMSEntities dbContext = new BDMSEntities())
            {
                try
                {
                    Area area = dbContext.Areas.FirstOrDefault(x => x.AreaId.Equals(updatedArea.AreaId));
                    if (area != null)
                    {
                        area = updatedArea;
                        dbContext.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally { dbContext.Dispose(); }
            }
        }

        public static void InsertArea(Area area)
        {
            using (BDMSEntities dbContext = new BDMSEntities())
            {
                try
                {
                    dbContext.Areas.Add(area);
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally { dbContext.Dispose(); }
            }
        }

        #endregion

    }
}
