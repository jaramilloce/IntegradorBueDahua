using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkerXtract.Dto.DtoXtract;

public class ExtrasDto
{
    public string Type { get; set; }
    public string Subtype { get; set; }
    public string Currency { get; set; }

    [JsonPropertyName("electronic_authorization_id_expiration_date")]
    public string ElectronicAuthorizationIdExpirationDate { get; set; }

    public string Adenda { get; set; }

    [JsonPropertyName("adherido_debito_automatico")]
    public string AdheridoDebitoAutomatico { get; set; }

    [JsonPropertyName("bl_number")]
    public string BlNumber { get; set; }

    [JsonPropertyName("condicion_de_venta")]
    public string CondicionDeVenta { get; set; }

    [JsonPropertyName("container_number")]
    public string ContainerNumber { get; set; }

    public string Deuda { get; set; }

    [JsonPropertyName("discount_amount")]
    public string DiscountAmount { get; set; }

    public string Domicilio { get; set; }
    public string FormaDePago { get; set; }
    public string Localidad { get; set; }

    [JsonPropertyName("monto_no_gravado")]
    public string MontoNoGravado { get; set; }

    public string Mora { get; set; }

    [JsonPropertyName("numero_de_cliente")]
    public string NumeroDeCliente { get; set; }

    [JsonPropertyName("numero_de_contrato")]
    public string NumeroDeContrato { get; set; }
    public string Provincia { get; set; }

    [JsonPropertyName("punto_de_venta")]
    public string PuntoDeVenta { get; set; }

    [JsonPropertyName("purchase_order")]
    public string PurchaseOrder { get; set; }

    [JsonPropertyName("round_amount")]
    public string RoundAmount { get; set; }
    public string Serie { get; set; }

    [JsonPropertyName("numero_iibb")]
    public string NumeroIibb { get; set; }

    [JsonPropertyName("situacion_iva")]
    public string SituacionIva { get; set; }
}
