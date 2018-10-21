using System;
using System.Collections.Generic;

namespace YFinance.Models
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string NetWorth { get; set; }
        public string DayGain { get; set; }
        public string DayGainPercent { get; set; }
        public string TotalGain { get; set; }
        public string TotalGainPercent { get; set; }
        public DateTime Date { get; set; }
    }
}