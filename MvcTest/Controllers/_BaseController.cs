using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Script.Serialization;

using Enyim.Caching;
using Enyim.Caching.Memcached;

using NLog;

using SocialFruits.Domain;
using SocialFruits.Domain.Entities;
using SocialFruits.Domain.ValueTypes;
using SocialFruits.Domain.Enums;
using SocialFruits.Domain.Extensions;
using SocialFruits.Domain.Repositories;
using MvcTest.Models;
using SocialFruits.Extensions.Helpers;
using SocialFruits.Localization;
using SocialFruits.Mvc.Common.Controllers;
using SocialFruits.Mvc.Common.Extensions;

namespace MvcTest.Controllers
{
    public partial class BaseController : AbstractBaseController<Member>
    {
        public BaseController()
        {

        }


        public long PageId
        {
            get
            {
                //return 103889821737;
                if (!RouteData.Values.ContainsKey("pageid")) return 0;
                return long.Parse(RouteData.Values["pageid"].ToString());
            }
        }


        public override void ReloadCurrentMemberCache(HttpContextBase context)
        {
            throw new NotImplementedException();
        }

        public override void ReloadCurrentMemberCache(Member member)
        {
            throw new NotImplementedException();
        }
    }
}