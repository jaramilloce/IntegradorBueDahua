using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkerXtract.Dto.DtoXtract;

public class ProviderDto
{
    public int Id { get; set; }

    [JsonPropertyName("tax_id")]
    public string TaxId { get; set; }

    [JsonPropertyName("business_name")]
    public string BusinessName { get; set; }

    public bool Configured { get; set; }
    public ProviderImputationsDto Imputations { get; set; }
}