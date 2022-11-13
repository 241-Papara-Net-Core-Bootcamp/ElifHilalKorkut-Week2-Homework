using System;
using ExceptionHandling.Model;
using System.Text;

namespace ExceptionHandling.Services
{
    public class OwnerServices : IOwnerServices
    {
        public string Add()
        {
            return "Owner Eklendi";
        }

        public bool Delete()
        {
            return true;
        }

        public string Get()
        {
            return "Ownerlar getirildi";
        }
        public string GetColorEnum()
        {
            var sringBuilder = new StringBuilder();
            foreach (var color in Enum.GetNames(typeof(ColorEnum)))
            {
                sringBuilder.Append(color + "|");
            }
            return sringBuilder.ToString();
        }
    }
}

