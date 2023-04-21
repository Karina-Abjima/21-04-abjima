using ProjectLinq.EntityClasses;
using ProjectLinq.RepositoryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinq.ViewModelClasses
{
    public class SamplesViewModel
    {
        #region GetAllLooping
        /// <summary>
        /// Put all products into a collection via Looping, no LINQ
        /// </summary>
        public void GetAllLooping()
        {
            List<Product> list = new List<Product>();
            foreach (Product item in Products)
            {
                list.Add(item);
            }

            ResultText = $"Total Products : {list.Count}";
        }
        #endregion

        public SamplesViewModel()
        {
            Products = ProductRepository.GetAll();
        }

        public bool UseQuerySyntax = true;
        public List<Product> Products;
        public string ResultText;
        public void GetAll()
        {
            List<Product> list;
            if (UseQuerySyntax)
            {
                //Query Syntax
                list = (from prod in Products select prod).ToList();
            }
            else
            {
                //Method Syntax
                list = Products.Select(prod => prod).ToList();
            }

            ResultText = $"Total Products: {list.Count}";
        }

        public void GetSingleColumn() {
        }
    }

}
