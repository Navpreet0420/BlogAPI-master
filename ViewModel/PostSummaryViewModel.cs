using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.ViewModel
{
    public class PostSummaryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Keywords { get; set; }
        public string Category { get; set; }
        public string Active { get; set; }
    }
}
