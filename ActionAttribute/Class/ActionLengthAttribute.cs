using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ActionAttribute.Class
{
    public class ActionLengthAttribute : ActionNameSelectorAttribute
    {
        readonly int _length;
        public ActionLengthAttribute(int length)
        {
            _length = length;
        }
        public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
        {
            return actionName.Length <= _length;
        }
    }
}