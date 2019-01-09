using AdvanceWebJaneTicar.Web.Infrastructures.Data.Helpers;
using AdvanceWebJaneTicar.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebJaneTicar.Web.ViewModels
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
