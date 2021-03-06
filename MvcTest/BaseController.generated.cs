// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace MvcTest.Controllers
{
    public partial class BaseController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected BaseController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonNetResult JsonNet()
        {
            return new T4MVC_System_Web_Mvc_JsonNetResult(Area, Name, ActionNames.JsonNet);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult RedirectCheckReferrer()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RedirectCheckReferrer);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult RedirectCheckReferrerFromUri()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RedirectCheckReferrerFromUri);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.XmlResult Xml()
        {
            return new T4MVC_System_Web_Mvc_XmlResult(Area, Name, ActionNames.Xml);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public BaseController Actions { get { return MVC.Base; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Base";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Base";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string JsonNet = "JsonNet";
            public readonly string RedirectCheckReferrer = "RedirectCheckReferrer";
            public readonly string RedirectCheckReferrerFromUri = "RedirectCheckReferrerFromUri";
            public readonly string Xml = "Xml";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string JsonNet = "JsonNet";
            public const string RedirectCheckReferrer = "RedirectCheckReferrer";
            public const string RedirectCheckReferrerFromUri = "RedirectCheckReferrerFromUri";
            public const string Xml = "Xml";
        }


        static readonly ActionParamsClass_JsonNet s_params_JsonNet = new ActionParamsClass_JsonNet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_JsonNet JsonNetParams { get { return s_params_JsonNet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_JsonNet
        {
            public readonly string data = "data";
        }
        static readonly ActionParamsClass_RedirectCheckReferrer s_params_RedirectCheckReferrer = new ActionParamsClass_RedirectCheckReferrer();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RedirectCheckReferrer RedirectCheckReferrerParams { get { return s_params_RedirectCheckReferrer; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RedirectCheckReferrer
        {
            public readonly string referrer = "referrer";
        }
        static readonly ActionParamsClass_RedirectCheckReferrerFromUri s_params_RedirectCheckReferrerFromUri = new ActionParamsClass_RedirectCheckReferrerFromUri();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RedirectCheckReferrerFromUri RedirectCheckReferrerFromUriParams { get { return s_params_RedirectCheckReferrerFromUri; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RedirectCheckReferrerFromUri
        {
            public readonly string uri = "uri";
        }
        static readonly ActionParamsClass_Xml s_params_Xml = new ActionParamsClass_Xml();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Xml XmlParams { get { return s_params_Xml; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Xml
        {
            public readonly string data = "data";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_BaseController : MvcTest.Controllers.BaseController
    {
        public T4MVC_BaseController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.JsonNetResult JsonNet(object data)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonNetResult(Area, Name, ActionNames.JsonNet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "data", data);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult RedirectCheckReferrer(string referrer)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RedirectCheckReferrer);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "referrer", referrer);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult RedirectCheckReferrerFromUri(System.Uri uri)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RedirectCheckReferrerFromUri);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "uri", uri);
            return callInfo;
        }

        public override System.Web.Mvc.XmlResult Xml(object data)
        {
            var callInfo = new T4MVC_System_Web_Mvc_XmlResult(Area, Name, ActionNames.Xml);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "data", data);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
