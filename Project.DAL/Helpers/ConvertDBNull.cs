using System;

namespace Project.DAL.Helpers
{
    /// <summary>
    /// Converts DBNull to the default value passed
    /// </summary>
    /// <remarks>
    /// Saves lot of code rather than checking for 
    /// DBNull everywhere and then casting
    /// </remarks>
    public class ConvertDBNull
    {
        public static T To<T>(object value, T defaultValue)
        {
            if (value == DBNull.Value) return defaultValue;
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
