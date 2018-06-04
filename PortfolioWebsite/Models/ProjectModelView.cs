using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioWebsite.Models
{
    public enum PROJECT_TYPE
    {
        WEBSITE = 0,
        GAME,
        MOBILE_APP
    }

    public class ProjectModelView
    {
        public PROJECT_TYPE Type { get; set; }
        public string ProjectTitle { get; set; }
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}