namespace DayOffRequest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the date of leave (YYYY-MM-DD): ");
            string submittedDate = Console.ReadLine();

            // Use the static method for validation
            DayOffValidator validator = DayOffValidator.ValidateDayOff(submittedDate);

            // check the validation result
            if (validator.IsValidDayOff)
            {
                Console.WriteLine("Day-off submitted successfully!");
            }
            else
            {
                Console.WriteLine(validator.Error);
            }
        }

        struct DayOffValidator
        {
            public bool IsValidDayOff { get; set; }
            public string? Error { get; set; }

            //static method to validate the day-off
            public static DayOffValidator ValidateDayOff(string submittedDate)
            {
                DayOffValidator validator = new DayOffValidator();

                if (DateTime.TryParse(submittedDate, out DateTime leaveDate))
                {
                    validator.IsValidDayOff = IsDateValid(leaveDate);
                    validator.Error = validator.IsValidDayOff ? null : $"Error: {GetErrorMessage(leaveDate)}";
                }
                else
                {
                    validator.IsValidDayOff = false;
                    validator.Error = "Error: Invalid date format.Please enter a valid date.";
                }

                return validator;
            }

            // method check if the date is valid based on the criteria
            public static bool IsDateValid(DateTime leaveDate)
            {
                return leaveDate.Date >= DateTime.Today &&
                    leaveDate.DayOfWeek != DayOfWeek.Saturday &&
                    leaveDate.DayOfWeek != DayOfWeek.Sunday;
            }

            //method to get an error message based on the validation outcome
            public static string GetErrorMessage(DateTime leaveDate)
            {
                if (leaveDate.Date < DateTime.Today)
                {
                    return "Cannot submit a day-off in the past.";
                }
                else
                {
                    return "Cannot submit a day-off on the weekend.";
                }
            }
        }
    }
}
