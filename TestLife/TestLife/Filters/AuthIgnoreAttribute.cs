using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLife.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthIgnoreAttribute : Attribute
    {
    }
}