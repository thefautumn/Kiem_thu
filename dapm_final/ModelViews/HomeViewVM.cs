using dapm_final.Models;
using System.Collections.Generic;

namespace dapm_final.ModelViews
{
    public class HomeViewVM
    {
        public List<News> TinTucs { get; set; }
        public List<ProductHomeVM> Products { get; set; }
        public QuangCao quangcao { get; set; }
    }
}
