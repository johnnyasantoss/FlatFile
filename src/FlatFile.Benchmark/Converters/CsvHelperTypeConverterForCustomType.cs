﻿namespace FlatFile.Benchmark.Converters
{
    using System;
    using CsvHelperTypeConversion = CsvHelper.TypeConversion;

    public class CsvHelperTypeConverterForCustomType : CsvHelperTypeConversion.ITypeConverter
    {
        private readonly FlatFileTypeConverterForCustomType converter;

        public CsvHelperTypeConverterForCustomType()
        {
            converter = new FlatFileTypeConverterForCustomType();
        }

        public string ConvertToString(CsvHelperTypeConversion.TypeConverterOptions options, object value)
        {
            return converter.ConvertToString(value);
        }

        public object ConvertFromString(CsvHelperTypeConversion.TypeConverterOptions options, string text)
        {
            return converter.ConvertFromString(text);
        }

        public bool CanConvertFrom(Type type)
        {
            return converter.CanConvertFrom(type);
        }

        public bool CanConvertTo(Type type)
        {
            return converter.CanConvertTo(type);
        }
    }
}
