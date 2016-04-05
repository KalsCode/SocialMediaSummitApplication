using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaSummitApplication.Models
{
    public class FilePath
    {
        public int FilePathId { get; set; }
        public string FileName { get; set; }
        public FileType FileType { get; set; }
    }
}