using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkerXtract.Dto.DtoXtract;

public class InvoiceDto
{
    public int Id { get; set; }
    public string Number { get; set; }

    [JsonPropertyName("client_tax_id")]
    public string ClientTaxId { get; set; }

    [JsonPropertyName("client_business_name")]
    public string ClientBusinessName { get; set; }

    [JsonPropertyName("provider_tax_id")]
    public string ProviderTaxId { get; set; }

    [JsonPropertyName("provider_business_name")]
    public string ProviderBusinessName { get; set; }

    public string Date { get; set; }
    public List<ProductDto> Products { get; set; }
    public List<TaxDto> Taxes { get; set; }
    public ImputationsDto Imputations { get; set; }
    public List<AssignmentDto> Assignments { get; set; }

    [JsonPropertyName("approval_status")]
    public string ApprovalStatus { get; set; }
    public ProviderDto Provider { get; set; }
    public ExtrasDto Extras { get; set; }

    [JsonPropertyName("total_amount")]
    public decimal TotalAmount { get; set; }

    [JsonPropertyName("electronic_authorization_id")]
    public string ElectronicAuthorizationId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("expiration_date")]
    public string ExpirationDate { get; set; }
    public string Accounted { get; set; }

    [JsonPropertyName("accounted_details")]
    public string AccountedDetails { get; set; }
}

