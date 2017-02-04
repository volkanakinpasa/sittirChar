using System;
using System.Collections.Generic;
using System.Reflection;

namespace SittirChar
{
    public class TextCleanerHandler<T> where T : class
    {
        public void Clean(T model)
        {
            var props = typeof (T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                IEnumerable<Attribute> attributes = prop.GetCustomAttributes();
                foreach (var attr in attributes)
                {
                    var attribute = attr as BaseCleanCharAttribute;
                    if (attribute == null) continue;
                    var attributeInterface = attr as IClean;
                    if (attributeInterface == null) continue;

                    var value = prop.GetValue(model, null);

                    if (value != null && value is string)
                    {

                        var result = attributeInterface.Clean(value.ToString());
                        prop.SetValue(model, result);

                    }
                }
            }
        }
    }
}