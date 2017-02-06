using System;
using System.Collections.Generic;
using System.Reflection;

namespace SittirChar
{
    public class TextCleanerHandler<T> where T : class
    {
        private readonly char[] _exclude;

        public TextCleanerHandler()
        {

        }

        public TextCleanerHandler( char[] exclude)
        {

            exclude.NullCheck(string.Format("{0} parameter cannot be null.", "exclude"));

            _exclude = exclude;
        }

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

                    if (value is string)
                    {
                        var result = attributeInterface.Clean(value.ToString(), _exclude);
                        prop.SetValue(model, result);

                    }
                }
            }
        }
    }
}