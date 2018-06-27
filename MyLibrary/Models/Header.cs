using System;
using System.Collections.Generic;

namespace MyLibrary.Models
{
    public partial class Header
    {
        public Header()
        {
            Body = new HashSet<Body>();
        }

        public string FileName { get; set; }
        public string InterfaceType { get; set; }
        public string BeginRec { get; set; }
        public string HeadSymbol { get; set; }
        public string BeginFromSys { get; set; }
        public string FromSys { get; set; }
        public string BeginToSys { get; set; }
        public string ToSysName { get; set; }
        public string BeginFileName { get; set; }
        public string BeginInterfaceName { get; set; }
        public string InterfaceName { get; set; }
        public string BeginRecLength { get; set; }
        public string RecLength { get; set; }
        public string EndRec { get; set; }
        public string Flag { get; set; }

        public Tailer Tailer { get; set; }
        public ICollection<Body> Body { get; set; }
    }
}
