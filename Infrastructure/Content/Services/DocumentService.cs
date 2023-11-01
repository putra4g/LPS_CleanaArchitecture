using Application.Dtos;
using Application.Interfaces.Content.Documents;
using Application.Interfaces.Content.Products;
using Domain.Models;
using Infrastructure.Content.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Content.Services
{
	public class DocumentService : IDocument
	{
		private readonly AppDbContext _context;

		public DocumentService(AppDbContext context)
		{
			_context = context;
		}
		public Task<Product> Add(Document model)
		{
			throw new NotImplementedException();
		}

		public Product Delete(Document model)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DocumentIsExist(string docName)
		{
			throw new NotImplementedException();
		}

		public Task<List<DocumentDto>> GetAll()
		{
			throw new NotImplementedException();
		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}

		public Product Update(Document model)
		{
			throw new NotImplementedException();
		}
	}
}