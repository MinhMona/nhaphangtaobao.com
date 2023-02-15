using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MB.Extensions;
using NHST.Models;
using WebUI.Business;

namespace NHST.Controllers
{
    public class TeamWorkController
    {
        public static string InsertFeedback(string FullName, string IMG, string Description, string CreatedBy, DateTime CreateDate)
        {
            using (var db = new NHSTEntities())
            {
                tbl_TeamWork t = new tbl_TeamWork();
                t.Name = FullName;
                t.IMG = IMG;
                t.Description = Description;
                t.CreatedBy = CreatedBy;
                t.CreatedDate = CreateDate;
                t.Hide = false;
                t.Type = 3;
                db.tbl_TeamWork.Add(t);
                db.SaveChanges();
                return t.ID.ToString();
            }
        }

        public static string InsertStaff(string FullName, string IMG, string Description, string CreatedBy, DateTime CreateDate)
        {
            using (var db = new NHSTEntities())
            {
                tbl_TeamWork t = new tbl_TeamWork();
                t.Name = FullName;
                t.IMG = IMG;
                t.Description = Description;
                t.CreatedBy = CreatedBy;
                t.CreatedDate = CreateDate;
                t.Hide = false;
                t.Type = 1;
                db.tbl_TeamWork.Add(t);
                db.SaveChanges();
                return t.ID.ToString();
            }
        }
        public static string InsertIMG(string IMG, string CreatedBy, DateTime CreateDate)
        {
            using (var db = new NHSTEntities())
            {
                tbl_TeamWork t = new tbl_TeamWork();
                t.IMG = IMG;
                t.CreatedBy = CreatedBy;
                t.CreatedDate = CreateDate;
                t.Hide = false;
                t.Type = 2;
                db.tbl_TeamWork.Add(t);
                db.SaveChanges();
                return t.ID.ToString();
            }
        }

        public static string Update(int ID, string FullName, string IMG, string Position, string Description, bool Hide, string CreatedBy, DateTime CreateDate)
        {
            using (var db = new NHSTEntities())
            {
                var t = db.tbl_TeamWork.Where(x => x.ID == ID).SingleOrDefault();
                if (t != null)
                {
                    t.Name = FullName;
                    if (!string.IsNullOrEmpty(IMG))
                        t.IMG = IMG;
                    t.Position = Position;
                    t.Description = Description;
                    t.ModifiedDate = CreateDate;
                    t.ModifiedBy = CreatedBy;
                    t.Hide = Hide;
                    db.SaveChanges();
                    return t.ID.ToString();
                }
                else return null;
            }
        }

        public static List<tbl_TeamWork> GetAllByType(int Type)
        {
            using (var db = new NHSTEntities())
            {
                var t = db.tbl_TeamWork.Where(x => x.Type == Type).OrderByDescending(x => x.ID).ToList();
                return t;
            }
        }

        public static tbl_TeamWork GetByID(int ID)
        {
            using (var db = new NHSTEntities())
            {
                var t = db.tbl_TeamWork.Where(x => x.ID == ID).SingleOrDefault();
                if (t != null)
                    return t;
                return null;
            }
        }

        public static int GetTotalList(int Type)
        {
            var sql = @"select Total=COUNT(*) ";
            sql += "from tbl_TeamWork ";
            sql += "where Type = " + Type + " ";
            var reader = (IDataReader)SqlHelper.ExecuteDataReader(sql);
            int a = 0;
            while (reader.Read())
            {
                if (reader["Total"] != DBNull.Value)
                    a = reader["Total"].ToString().ToInt(0);
            }
            reader.Close();
            return a;
        }
        public static List<tbl_TeamWork> GetBySQL_DK(int Type, int pageIndex, int pageSize)
        {
            var sql = @"Select * from tbl_TeamWork ";
            sql += "where Type = " + Type + " ";

            sql += "order by id DESC OFFSET " + pageIndex + "*" + pageSize + " ROWS FETCH NEXT " + pageSize + " ROWS ONLY";

            var reader = (IDataReader)SqlHelper.ExecuteDataReader(sql);
            List<tbl_TeamWork> a = new List<tbl_TeamWork>();
            while (reader.Read())
            {
                var entity = new tbl_TeamWork();
                if (reader["ID"] != DBNull.Value)
                    entity.ID = reader["ID"].ToString().ToInt(0);

                if (reader["Name"] != DBNull.Value)
                    entity.Name = reader["Name"].ToString();

                if (reader["Description"] != DBNull.Value)
                {
                    entity.Description = reader["Description"].ToString();
                }

                if (reader["IMG"] != DBNull.Value)
                {
                    entity.IMG = reader["IMG"].ToString();
                }

                if (reader["Position"] != DBNull.Value)
                {
                    entity.Position = reader["Position"].ToString();
                }

                if (reader["Hide"] != DBNull.Value)
                {
                    entity.Hide = Convert.ToBoolean(reader["Hide"].ToString());
                }

                if (reader["CreatedDate"] != DBNull.Value)
                {
                    entity.CreatedDate = Convert.ToDateTime(reader["CreatedDate"].ToString());
                }

                if (reader["CreatedBy"] != DBNull.Value)
                {
                    entity.CreatedBy = reader["CreatedBy"].ToString();
                }

                a.Add(entity);
            }
            reader.Close();
            return a;
        }

        public static string Delete(int ID)
        {
            using (var dbe = new NHSTEntities())
            {
                var tw = dbe.tbl_TeamWork.Where(o => o.ID == ID).SingleOrDefault();
                if (tw != null)
                {
                    dbe.tbl_TeamWork.Remove(tw);
                    dbe.Configuration.ValidateOnSaveEnabled = false;
                    string kq = dbe.SaveChanges().ToString();
                    return kq;
                }
                else return null;
            }
        }

    }
}