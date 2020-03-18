﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NonFactors.Mvc.Grid
{
    public interface IGrid
    {
        String Name { get; set; }
        String EmptyText { get; set; }
        String CssClasses { get; set; }

        ViewContext ViewContext { get; set; }
        IQueryCollection Query { get; set; }

        IGridColumns<IGridColumn> Columns { get; }

        IGridRows<Object> Rows { get; }

        IGridPager Pager { get; }
        ModelExpressionProvider ModelExpressionProvider { get; }
    }

    public interface IGrid<T> : IGrid
    {
        IList<IGridProcessor<T>> Processors { get; set; }
        IQueryable<T> Source { get; set; }

        new IGridColumnsOf<T> Columns { get; }
        new IGridRowsOf<T> Rows { get; }

        new IGridPager<T> Pager { get; set; }
    }
}
