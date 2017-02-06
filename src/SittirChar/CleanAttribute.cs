using System;
using System.Linq;
using System.Text;

namespace SittirChar
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CleanAttribute : BaseCleanCharAttribute, IClean
    {
        public virtual string Clean(string model, char[] exclude)
        {
            var newString = new StringBuilder();

            foreach (var c in model)
            {
                if (exclude.Contains(c))
                {
                    continue;
                }

                if (!char.IsControl(c))
                {
                    newString.Append(c);
                }
            }

            return newString.ToString();
        }
    }
}
