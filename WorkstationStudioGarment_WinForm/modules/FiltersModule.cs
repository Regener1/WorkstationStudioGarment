using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.modules
{
    class FiltersModule
    {
        private ProductService productS = new ProductService();

        public List<string> GetCategoriesList()
        {
            try
            {
                using(StudioDB db = new StudioDB())
                {
                    var tmpList = db.PRODUCTs.Select(x => x.category).Distinct().ToList();

                    return tmpList;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<string> GetColorsList()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var tmpList = db.PRODUCTs.Select(x => x.color).Distinct().ToList();

                    return tmpList;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<string> GetSizeList()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var tmpList = db.PRODUCTs.Select(x => x.size).Distinct().ToList();
                    List<string> sizeList = new List<string>();
                    foreach(var item in tmpList)
                    {
                        sizeList.Add(item.ToString());
                    }

                    return sizeList;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
