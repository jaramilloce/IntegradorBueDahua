using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkerXtract.Dto.DtoXtract;

public class ProductExtrasDto
{
    [JsonPropertyName("decimal_quantity")]
    public string DecimalQuantity { get; set; }
}
