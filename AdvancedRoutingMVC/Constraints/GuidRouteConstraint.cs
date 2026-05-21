using Microsoft.AspNetCore.Routing;

namespace AdvancedRoutingMVC.Constraints
{
    // Custom route constraint to check valid GUID
    public class GuidRouteConstraint : IRouteConstraint
    {
        public bool Match(
            HttpContext? httpContext,
            IRouter? route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            if (!values.ContainsKey(routeKey))
            {
                return false;
            }

            string? value = values[routeKey]?.ToString();

            return Guid.TryParse(value, out _);
        }
    }
}