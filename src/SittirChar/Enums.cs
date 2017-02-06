using System;

namespace SittirChar
{
    public static class Enums
    {
        public static void NullCheck(this object obj, string message)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
