using System.ComponentModel.DataAnnotations;

namespace DtdLesson08.Models
{
    public class DtdAccount
    {
        [Key]
        public int DtdId { get; set; }
        public string DtdFullName { get; set; }
        public string DtdEmail { get; set; }
        public string DtdPhone { get; set; }
        public string DtdAddress { get; set; }
        public string DtdAvatar { get; set; }
        public DateTime DtdBirthday  { get; set; }
        public string DtdGender { get; set; }
        public string DtdPassword   { get; set; }
        public string DtdFaceBook { get; set; }
    }
}
