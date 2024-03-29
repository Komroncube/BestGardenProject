﻿namespace BestGarden.Domain.Models;
public class Catalog : BaseDomainEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string PlantSystem { get; set; }
    public string ImagePath { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}
