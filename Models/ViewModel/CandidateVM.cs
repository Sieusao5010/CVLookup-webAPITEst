using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CVLookup_WebAPI.Models.ViewModel
{
    public class CandidateVM : UserVM
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
