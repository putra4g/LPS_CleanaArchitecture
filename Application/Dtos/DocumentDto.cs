using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class DocumentDto
    {
		public int? Id { get; set; }
		public string? Document_Name { get; set; }

        public string? Type { get; set; }
        public byte[]? File { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }


    }
}
