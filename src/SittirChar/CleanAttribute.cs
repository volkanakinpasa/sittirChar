using System;
using System.Linq;
using System.Text;

namespace SittirChar
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CleanAttribute : BaseCleanCharAttribute, IClean
    {
        private readonly char[] _unIgnored ;

        public CleanAttribute()
        {
            _unIgnored = new[] { '\r', '\n' };
        }
        public virtual string Clean(string model)
        {
            var newString = new StringBuilder();

            foreach (char c in model)
            {
                if (_unIgnored.Contains(c) || !char.IsControl(c))
                    newString.Append(c);
            }

            return newString.ToString();
        }

    }
}
