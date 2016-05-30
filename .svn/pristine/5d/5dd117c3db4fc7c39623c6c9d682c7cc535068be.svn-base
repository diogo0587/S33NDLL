using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Util
{
    public static class ExtendValidation
    {
        public static bool IsValid<T>(this T entity, out IList<string> messages) where T : class
        {
            var validations = new List<ValidationResult>();
            messages = new List<string>();

            bool isValid = Validator.TryValidateObject(entity, new ValidationContext(entity), validations, true);

            if (!isValid)
            {
                foreach (var item in validations)
                {
                    messages.Add(item.ErrorMessage);
                }
            }

            return isValid;
        }
    }
}
