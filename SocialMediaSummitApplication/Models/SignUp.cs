using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialMediaSummitApplication.Models
{
    public class SignUp
    {

        [ScaffoldColumn(false)]
        public int SignUpId { get; set; }

        [Display(Name = "Registering as:")]
        public SignUpCategory SignUpCategory { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Please enter appropriate location name")]
        public string Location { get; set; }

        [Required]
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public int AppId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "App Name")]
        public string AppName { get; set; }

        [Display(Name = "Application Category")]
        public AppCategory AppCategory { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "App Description")]
        public string AppDesc { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "App Download Link")]
        public string HostUrl1 { get; set; }

        [Display(Name = "Download Link 2")]
        public string HostUrl2 { get; set; }

        [Display(Name = "Download Link 3")]
        public string HostUrl3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FilePath> FilePaths { get; set; }

        [ScaffoldColumn(false)]
        private DateTime RegDate { get; set; } = DateTime.Today;
        [ScaffoldColumn(false)]
        private string OsVersion { get; set; } = Environment.OSVersion.VersionString;
    }
}