using System.ComponentModel.DataAnnotations;

namespace domain.Attributes.Validations
{
    public class NotEqualAttribute : ValidationAttribute
    {
        private readonly object value;

        public NotEqualAttribute(object value)
        {
            this.value = value;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            switch (this.value.GetType().Name)
            {
                case "Int32": return (int)value == (int)this.value ? new ValidationResult(ErrorMessage) : ValidationResult.Success;
                case "String": return (string)value == (string)this.value ? new ValidationResult(ErrorMessage) : ValidationResult.Success;
                case "Double": return (double)value == (double)this.value ? new ValidationResult(ErrorMessage) : ValidationResult.Success;
                case "Char": return (char)value == (char)this.value ? new ValidationResult(ErrorMessage) : ValidationResult.Success;
                default: return (int)value == (int)this.value ? new ValidationResult(ErrorMessage) : ValidationResult.Success;
            }
        }
    }
}
