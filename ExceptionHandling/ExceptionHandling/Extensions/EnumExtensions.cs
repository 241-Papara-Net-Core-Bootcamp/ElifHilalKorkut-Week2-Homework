using System;
namespace ExceptionHandling.Extensions
{
	
        public static class EnumExtensions
        {
        public static string GetColorEnums(this Enum value)
        {
            return value.ToString();
        }
        }
    
}

