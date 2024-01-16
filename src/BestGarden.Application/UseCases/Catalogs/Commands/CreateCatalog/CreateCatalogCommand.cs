﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestGarden.Application.DTOs.Catalogs;

namespace BestGarden.Application.UseCases.Catalogs.Commands.CreateCatalog;

public class CreateCatalogCommand : ICommand<Catalog>
{
    public CatalogCreateDTO CatalogCreateDto { get; set; }
}