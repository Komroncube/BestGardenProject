using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestGarden.Application.DTOs.Catalogs;

namespace BestGarden.Application.UseCases.Catalogs.Queries.GetCatalogDetail;
public class GetCatalogDetailQuery : IQuery<CatalogDetailDTO>
{
    public int Id { get; set; }
}

