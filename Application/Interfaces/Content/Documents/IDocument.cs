using Application.Dtos;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Content.Documents
{
	public interface IDocument
	{
		Task<List<DocumentDto>> GetAll();

		Task<Product> Add(Document model);

		Product Update(Document model);

		Product Delete(Document model);

		Task<bool> DocumentIsExist(string docName);
		void SaveChanges();
	}
}
