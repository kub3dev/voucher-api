using System;
using Voucher.API.Domain.Entities;

namespace Voucher.API.Domain.Dtos;

public class VoucherCreateRequest
{
  public string? Description { get; set; } = null!;
  public decimal? Amount { get; set; } = null!;
  public string? Kind { get; set; } = null!;

  internal VoucherEntity ToEntity()
  {
    return new VoucherEntity
    {
      Description = Description,
      Amount = Amount,
      Kind = Kind,
    };
  }
}
