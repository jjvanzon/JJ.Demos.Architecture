﻿using JJ.Demos.Architecture.Business.Enums;
using JJ.Demos.Architecture.Data.Entities;
using JJ.Framework.Exceptions.InvalidValues;

namespace JJ.Demos.Architecture.Business.Visitors;

public abstract class PolymorphicVisitorBase_Step2_SwichOnEnum
{
    protected virtual void VisitProductPolymorphic(Product product)
    {
        ProductTypeEnum productTypeEnum = product.GetProductTypeEnum();
        switch (productTypeEnum)
        {
            case ProductTypeEnum.Physical:
                VisitPhysicalProduct(product);
                break;

            case ProductTypeEnum.Digital:
                VisitDigitalProduct(product);
                break;
        }
    }

    protected virtual void VisitPhysicalProduct(Product product)
        => VisitProductBase(product);

    protected virtual void VisitDigitalProduct(Product product)
        => VisitProductBase(product);

    protected virtual void VisitProductBase(Product product) { }
}
