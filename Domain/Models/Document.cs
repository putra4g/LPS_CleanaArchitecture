using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
	public class Document
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Document_Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string? Document_Name { get; set; }
		[Required]
		[MaxLength(10)]
		public string? Type { get; set; }
		[Required]
		public byte[]? File { get; set; }
		[Required]
		public DateTime? CreatedDate { get; set; }
		[Required]
		[MaxLength(100)]
		public string? CreatedBy { get; set; }


	}
}
