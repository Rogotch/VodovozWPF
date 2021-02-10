using System;
using Vodovoz.ENUMs;

namespace Vodovoz.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName   { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public Gender WorkerGender { get; set; }
        public int DepartmentId { get; set; }
    }
}