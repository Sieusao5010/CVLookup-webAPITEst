using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CVLookup_WebAPI.Models.ViewModel
{
    public class AccountVM
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

		public string Password { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; } = false;

        public DateTime IssuedAt { get; set; }

        public DateTime ActivedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
		
	}
}
