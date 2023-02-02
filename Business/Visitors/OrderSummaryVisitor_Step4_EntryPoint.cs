﻿// ReSharper disable once CheckNamespace

namespace JJ.Demos.Architecture.Business.Visitors.
          OrderSummaryVisitor_Step4_EntryPoint;

class OrderSummaryVisitor : OrderVisitorBase
{
    StringBuilder _sb = new();

    /// <summary>
    /// This Execute method is the only one that's public.
    /// This makes it clear where the process starts.
    /// The Visit methods are kept protected
    /// for internal processing.
    /// </summary>
    public string Execute(Order order)
    {
        VisitOrder(order);
        return _sb.ToString();
    }

    // ...
}
