using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CVLookup_WebAPI.Models.ViewModel
{
    public class EmployerVM : UserVM
    {
        public string EmployerName { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

    }
}
