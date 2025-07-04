using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkerXtract.Dto.DtoXtract;

public class ImputationsDto
{
    [JsonPropertyName("branch_office")]
    public string BranchOffice { get; set; }

    [JsonPropertyName("cost_center")]
    public string CostCenter { get; set; }

    [JsonPropertyName("payment_method")]
    public string PaymentMethod { get; set; }

    [JsonPropertyName("purchase_order")]
    public string PurchaseOrder { get; set; }

    [JsonPropertyName("purchase_order_position")]
    public string PurchaseOrderPosition { get; set; }

    public string Remito { get; set; }
    public string Status { get; set; }
}
