using System;

namespace Conceitos.Extensoes
{
    public static class DataExtensoes
    {
        public static DateTime RemoverDia(this DateTime data)
        {
            return new DateTime(data.Year, data.Month, data.Day - 1);
        }
    }
}
