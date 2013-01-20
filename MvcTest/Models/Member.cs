using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SocialFruits.Domain.Entities;
using SocialFruits.Domain.ValueTypes;

namespace MvcTest.Models
{
    [Serializable]
    public class Member : Entity, IMember
    {
        #region Relations


        #endregion

        #region x-to-many relations
        
        #endregion


        public Member()
        {
            //
            JoinDate = DateTime.UtcNow;
            LastVisitDate = DateTime.UtcNow;
            FacebookAccesstokenExpiration = DateTime.UtcNow;

            GeoLocation=new GeoLocation();
            //
            ActivationGuid = Guid.NewGuid();
            DateCreated = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public string DeviceToken { get; set; }

        public bool RedirectToWelcome { get; set; }
        public string Language { get; set; }
        #region Implementation of IMember

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public string Password { get; set; }
        public string Salt { get; set; }
        public string Gender { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "MsgInvalidEmailFormat", ErrorMessageResourceType = typeof(SocialFruits.Localization.UI))]
        
        public string Email { get; set; }

        public bool IsEmailActivated { get; set; }
        public bool IsEmailVerified { get; set; }
        public string EmailVerfificationCode { get; set; }
        public Guid ActivationGuid { get; set; }

        [RegularExpression(@"01[0-2][0-9]{8}", ErrorMessageResourceName = "MsgMobileNumIsInvalid", ErrorMessageResourceType = typeof(SocialFruits.Localization.UI))]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        public bool IsMobileActivated{ get; set; }


        [DataType(DataType.ImageUrl)]
        public string Picture { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime JoinDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime LastVisitDate { get; set; }

        public GeoLocation GeoLocation { get; set; }


        [ScaffoldColumn(false)]
        public string FacebookAccessToken { get; set; }

        [ScaffoldColumn(false)]
        public DateTime FacebookAccesstokenExpiration { get; set; }

        [DataType(DataType.Url)]
        public string FacebookProfileLink { get; set; }

        [ScaffoldColumn(false)]
        public long TwitterId { get; set; }

        [ScaffoldColumn(false)]
        public string TwitterName { get; set; }

        
        [DataType(DataType.ImageUrl)]
        public string TwitterProfileImageUrl { get; set; }

        [ScaffoldColumn(false)]
        public string TwitterSecret { get; set; }

        [ScaffoldColumn(false)]
        public string TwitterToken { get; set; }


        public long LinkedInId { get; set; }

        [DataType(DataType.Url)]
        public string LinkedInProfileLink { get; set; }

        [ScaffoldColumn(false)]
        public string LinkedInSecret { get; set; }

        [ScaffoldColumn(false)]
        public string LinkedInToken { get; set; }
        
        #endregion
    }

}