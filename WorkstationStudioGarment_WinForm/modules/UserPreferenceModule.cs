using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.modules
{
    class UserPreferenceModule
    {
        private int idClient = 0;

        private ProductService productS = new ProductService();
        private BasketService basketS = new BasketService();

        private List<PRODUCT> clientProducts;
        private List<PRODUCT> allProducts;
        private List<PRODUCT> summaryProducts = new List<PRODUCT>();

        private decimal maxPrice = 0;
        private decimal minPrice = 0;
        private Dictionary<string, int> names = new Dictionary<string, int>();
        private Dictionary<string, int> categories = new Dictionary<string, int>();
        private Dictionary<string, int> colors = new Dictionary<string, int>();


        private List<string> summary = new List<string>();

        public UserPreferenceModule() { }

        public UserPreferenceModule(int idClient)
        {
            this.idClient = idClient;
        }

        public int IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        public void Load()
        {
            try
            {
                if (!LoadClientProducts())
                {
                    return;
                }
                LoadAllProducts();
                LoadCriteriaLists();
                ApplyFilters();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<PRODUCT> GetPreferenceList()
        {
            return summaryProducts;
        }

        private bool LoadClientProducts()
        {
            try
            {
                using(StudioDB db = new StudioDB())
                {
                    var products = from p in db.PRODUCTs
                                   join b in db.BASKETs on p.id_product equals b.id_product
                                   where b.id_client == idClient
                                   select p;

                    clientProducts = products.ToList();
                    if(clientProducts.Count == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private void LoadAllProducts()
        {
            allProducts = productS.All();
        }

        private void LoadCriteriaLists()
        {
            decimal average = 0;
            string[] productName;
            foreach (PRODUCT e in clientProducts)
            {
                average += e.price;

                productName = e.title.Split(' ');
                if (names.ContainsKey(productName[0].ToLower()))
                {
                    names[productName[0].ToLower()] += 1;
                }
                else
                {
                    names.Add(productName[0].ToLower(), 0);
                }

                if (categories.ContainsKey(e.category.ToLower()))
                {
                    categories[e.category.ToLower()] += 1;
                }
                else
                {
                    categories.Add(e.category.ToLower(), 0);
                }

                if (colors.ContainsKey(e.color.ToLower()))
                {
                    colors[e.color.ToLower()] += 1;
                }
                else
                {
                    colors.Add(e.color.ToLower(), 0);
                }
            }

            names.OrderBy(x => x.Value);
            categories.OrderBy(x => x.Value);
            colors.OrderBy(x => x.Value);

            average /= clientProducts.Count;

            maxPrice = average + average * Convert.ToDecimal(0.3);
            minPrice = average - average * Convert.ToDecimal(0.3);
        }


        private void ApplyFilters()
        {
            int count = 0;
            foreach(PRODUCT e in allProducts)
            {
                if (CheckPrice(e))
                {
                    count++;
                }
                if (CheckName(e))
                {
                    count++;
                }
                if (CheckCategory(e))
                {
                    count++;
                }
                if (CheckColor(e))
                {
                    count++;
                }

                if(count == 4 || count == 3)
                {
                    summaryProducts.Add(e);
                }

                count = 0;
            }
        }

        private bool CheckPrice(PRODUCT entity)
        {
            if(entity.price >= minPrice && entity.price <= maxPrice)
            {
                return true;
            }
            return false;
        }

        private bool CheckName(PRODUCT entity)
        {
            string[] productName = entity.title.Split(' ');
            return names.ContainsKey(productName[0].ToLower());
        }

        private bool CheckCategory(PRODUCT entity)
        {
            return categories.ContainsKey(entity.category.ToLower());
        }

        private bool CheckColor(PRODUCT entity)
        {
            return colors.ContainsKey(entity.color.ToLower());
        }
    }
}
