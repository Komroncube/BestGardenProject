using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestGarden.Domain;

namespace BestGarden.Application.Contracts;
public interface IGenericRepository<T> where T : BaseDomainEntity
{
    Task<T> GetAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<bool> ExistsAsync(int id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(T entity);
}
