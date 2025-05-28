namespace DtdLab06.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DtdEmployee
    {
        public int DtdId { get; set; }
        public string DtdName { get; set; }
        public DateTime DtdBirthDay { get; set; }
        public string DtdEmail { get; set; }
        public string DtdPhone { get; set; }
        public decimal DtdSalary { get; set; }
        public bool DtdStatus { get; set; }
    }
}