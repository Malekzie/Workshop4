using System;

namespace Main.Utils
{
    public static class ValidationUtil
    {
        /// <summary>
        /// Validates the package dates.
        /// Ensures the end date is not earlier than the start date and is at least one month apart.
        /// </summary>
        public static bool ValidatePackageDates(DateTime startDate, DateTime endDate, out string errorMessage)
        {
            if (endDate < startDate)
            {
                errorMessage = "End date cannot be earlier than start date.";
                return false;
            }
            if ((endDate - startDate).Days < 7)
            {
                errorMessage = "End date should be at least a week apart from start date.";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }

        /// <summary>
        /// Validates that the given string can be parsed as a decimal.
        /// </summary>
        public static bool ValidateDecimal(string value, out decimal result, out string errorMessage, bool nonNegative = false)
        {
            if (decimal.TryParse(value, out result))
            {
                if (nonNegative && result < 0)
                {
                    errorMessage = "Value must be a non-negative decimal.";
                    result = 0;
                    return false;
                }
                errorMessage = string.Empty;
                return true;
            }
            errorMessage = "Value must be a valid decimal.";
            result = 0;
            return false;
        }


        /// <summary>
        /// Validates that the given string can be parsed as an integer.
        /// </summary>
        public static bool ValidateInteger(string value, out int result, out string errorMessage)
        {
            if (int.TryParse(value, out result))
            {
                if (result >= 0)
                {
                    errorMessage = string.Empty;
                    return true;
                }
                errorMessage = "Value must be a non-negative integer.";
                result = 0;
                return false;
            }
            errorMessage = "Value must be a valid integer.";
            result = 0;
            return false;
        }

    }
}
