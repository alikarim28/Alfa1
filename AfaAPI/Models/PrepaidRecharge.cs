using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlfaAPI.Models;

public partial class PrepaidRecharge
{

    [DisplayFormat(DataFormatString ="{0,0}")]
    public decimal? PrId { get; set; }

    public string? PrMsisdn { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy,HH:mm:ss}")]
    public DateTime? PrDate { get; set; }

    public string? PrTransaction { get; set; }

    public string? PrRequestUrl { get; set; }

    public string? PrSessionId { get; set; }

    public string? PrResponseUrl { get; set; }

    public string? PrStatus { get; set; }

    public string? PrCsStatus { get; set; }

    public string? PrSvStatus { get; set; }

    public DateTime? PrCsDate { get; set; }

    public DateTime? PrSvDate { get; set; }

    public string? PrAmount { get; set; }

    public string? PrPaymentId { get; set; }

    public string? PrRate { get; set; }

    public string? PrRates { get; set; }

    public string? UsdAmount { get; set; }

    public string? LbpAmount { get; set; }

    public string? PayCurrency { get; set; }

    public decimal? PrFiscalstamp { get; set; }

    public string? Creditcard { get; set; }

    public static implicit operator PrepaidRecharge(List<PrepaidRecharge> v)
    {
        throw new NotImplementedException();
    }
}
