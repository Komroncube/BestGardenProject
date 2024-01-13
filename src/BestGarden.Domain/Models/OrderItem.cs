﻿namespace BestGarden.Domain.Models;
public class OrderItem : BaseDomainEntity
{
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
