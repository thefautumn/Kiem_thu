using dapm_final.Models;
using System.Collections.Generic;

namespace dapm_final.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
