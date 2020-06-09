using System;
using System.Linq.Expressions;

namespace NonFactors.Mvc.Grid
{
    public abstract class NumberFilter : BaseGridFilter
    {
        public override Expression Apply(Expression expression)
        {
            Object value = GetNumericValue();
            if (value == null) return null;

            return Type switch
            {
                "Equals" => Expression.Equal(expression, Expression.Constant(value, expression.Type)),
                "NotEquals" => Expression.NotEqual(expression, Expression.Constant(value, expression.Type)),
                "LessThan" => Expression.LessThan(expression, Expression.Constant(value, expression.Type)),
                "GreaterThan" => Expression.GreaterThan(expression, Expression.Constant(value, expression.Type)),
                "LessThanOrEqual" => Expression.LessThanOrEqual(expression, Expression.Constant(value, expression.Type)),
                "GreaterThanOrEqual" => Expression.GreaterThanOrEqual(expression, Expression.Constant(value, expression.Type)),
                _ => null,
            };
        }

        public abstract Object GetNumericValue();
    }
}
