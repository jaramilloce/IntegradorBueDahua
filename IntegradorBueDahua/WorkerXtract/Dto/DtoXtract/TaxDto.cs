using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerXtract.Dto.DtoXtract;

public class TaxDto
{
    public string Key { get; set; }
    public string Label { get; set; }
    public decimal? Amount { get; set; }
}
