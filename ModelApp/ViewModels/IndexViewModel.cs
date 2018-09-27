using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelApp.Models;

namespace ModelApp.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Phone> Phones { get; set; }
        public IEnumerable<CompanyModel> Companies { get; set; }
    }
}
