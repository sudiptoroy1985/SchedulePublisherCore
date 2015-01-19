using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using SchedulePublisherCore.DataLayer;

namespace SchedulePublisherCore.Business
{
    public class ExpressionFilter
    {
        public string FilterName { get; set; }
        public object Value { get; set; }
    }

    public static class ExpressionHelper<T> where T:class
    {
        public static List<Expression<Func<T, bool>>> GenerateFilterExpression(List<ExpressionFilter> filters)
        {
            List<Expression<Func<T, bool>>> filterExpressionList = null;
            if (filters.Any())
            {
                foreach (var filterToItem in filters)
                {
                    filterExpressionList = new List<Expression<Func<T, bool>>>();
                    var entityType = typeof (T);
                    var propertyName = filterToItem.FilterName;
                    var id = filterToItem.Value;
                    var parameter = Expression.Parameter(entityType);

                    filterExpressionList.Add((Expression<Func<T, bool>>)Expression.Lambda(Expression.Equal(Expression.Property(parameter, propertyName), Expression.Constant(id)),
                                parameter));
                }
            }
            return filterExpressionList;
        }
    }
}