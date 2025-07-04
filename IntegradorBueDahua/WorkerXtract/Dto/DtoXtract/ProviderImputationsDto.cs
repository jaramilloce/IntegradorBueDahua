using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkerXtract.Dto.DtoXtract;

public class ProviderImputationsDto
{
    [JsonPropertyName("branch_office")]
    public string BranchOffice { get; set; }

    [JsonPropertyName("cost_center")]
    public string CostCenter { get; set; }
}