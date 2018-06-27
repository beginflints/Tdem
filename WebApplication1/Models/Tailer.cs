using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Tailer
    {
        public string FileName { get; set; }
        public string BeginRec { get; set; }
        public string TailerSymbol { get; set; }
        public string BeginTotalRec { get; set; }
        public string TotalRec { get; set; }
        public string EndRec { get; set; }

        public Header FileNameNavigation { get; set; }
    }
}
