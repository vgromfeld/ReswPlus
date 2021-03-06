// Copyright (c) Rudy Huyn. All rights reserved.
// Licensed under the MIT License.
// Source: https://github.com/DotNetPlus/ReswPlus

using ReswPlusLib.Interfaces;

namespace ReswPlusLib.Providers
{
    internal class OneOrZeroToOneExcludedProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(double n)
        {
            if (n == 0)
                return PluralTypeEnum.ZERO;
            if ((int)n == 0 || (int)n == 1)
            {
                return PluralTypeEnum.ONE;
            }
            else
            {
                return PluralTypeEnum.OTHER;
            }
        }

    }
}
