using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.tool;

namespace WorkstationStudioGarment_WinForm.modules
{
    public class LogicModelModule
    {
        private ProductService productS = new ProductService();

        public List<string> AllProductNames()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    
                    var tmpList = db.PRODUCTs.Select(x => x.title).Distinct().ToList();

                    for(int i = 0; i < tmpList.Count; i++)
                    {
                        tmpList[i] = Parser.ParseStringToStringArray(tmpList[i], ' ')[0];
                    }

                    return tmpList;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
