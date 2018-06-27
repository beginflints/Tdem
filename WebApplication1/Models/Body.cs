using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Body
    {
        public string FileName { get; set; }
        public int RecId { get; set; }
        public string ShipmentCode { get; set; }
        public string ExCompany { get; set; }
        public string ExCode { get; set; }
        public string ImCompany { get; set; }
        public string ImCode { get; set; }
        public string Inv { get; set; }
        public DateTime InvDate { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? Atd { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Ata { get; set; }
        public string ShipmentStatus { get; set; }
        public string ShipCca { get; set; }
        public string Vessel { get; set; }
        public string ContainerNo { get; set; }
        public string RpackOwner { get; set; }
        public string RpackType { get; set; }
        public int? RpackQty { get; set; }
        public string Terminal { get; set; }
        public int? Ftstorage { get; set; }
        public int? Ftdemurrage { get; set; }
        public int? Ftdetention { get; set; }
        public DateTime EndFtstorage { get; set; }
        public DateTime? EndFtdemurrage { get; set; }
        public DateTime? EndFtdetention { get; set; }
        public DateTime? CompleteInpectionDate { get; set; }
        public DateTime? DateYusenCy { get; set; }
        public DateTime? DateTdemwh { get; set; }
        public string LocationTdem { get; set; }
        public string ExpenseFixContainer { get; set; }
        public string ExpenseOverFt { get; set; }
        public string OtherExpense { get; set; }
        public string EndRec { get; set; }

        public Header FileNameNavigation { get; set; }
    }
}
