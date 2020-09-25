using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_from_CBT_AspNet.Areas.Identity.Data
{
    public partial class AspNetEvents
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Topic { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string CompanyName { get; set; }
        public string Subtopic { get; set; }
        public string Description { get; set; }
        public int? Images { get; set; }

    }
}
