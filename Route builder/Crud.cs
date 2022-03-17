using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_builder
{
    internal class Crud
    {
        static MapContext db;
        internal static List<Map> GetDataFromDB()
        {
            db = new MapContext();
            db.Maps.Load();
            return db.Maps.ToList();
        }
        internal static Map AddNameAndImg(string name, Image img)
        {
            Map map = new Map();
            map.name = name;
            map.mapImg = ImgFunc.ImgToByteArr(img);
            db.Maps.Add(map);
            db.SaveChanges();
            return map;
        }

        internal static Map FindById(int id)
        {
            return db.Maps.Find(id);
        }

        internal static void UpdateMap(Map newMap)
        {
            Map map = db.Maps.Find(newMap.id);
            map = newMap;
            db.SaveChanges();
        }

        internal static void DeleteMap(int id)
        {
            Map delMap = db.Maps.Find(id);
            db.Maps.Remove(delMap);
            db.SaveChanges();
        }

        internal static List<Map> SearchMaps(string search)
        {
            db = new MapContext();
            var maps = db.Maps.Where(m => m.name.Contains(search)).ToList();
            return maps;
        }
    }
}
