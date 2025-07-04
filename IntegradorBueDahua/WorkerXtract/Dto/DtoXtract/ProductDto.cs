using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkerXtract.Dto.DtoXtract;

public class ProductDto
{
    public int Id { get; set; }

    [JsonPropertyName("external_id")]
    public string ExternalId { get; set; }

    public string Description { get; set; }
    public int Quantity { get; set; }

    [JsonPropertyName("unit_amount")]
    public decimal? UnitAmount { get; set; }

    [JsonPropertyName("discount_amount")]
    public decimal? DiscountAmount { get; set; }

    public decimal? Amount { get; set; }
    public ProductImputationsDto Imputations { get; set; }
    public ProductExtrasDto Extras { get; set; }
}

