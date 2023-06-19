using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace WebApplication1.Forms
{
    public class FizzBuzzForm
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [Range(1, 1000, ErrorMessage = "Oczekiwana wartość '{0}' z zakresu {1} i {2}")]
        
        public int Number { get; set; }
        public string? AlertInfo { get; set; }
        public string? AlertStyle { get; set; } //invisible alert alert-primary

        public FizzBuzzForm()
        {
            AlertInfo = "";
            AlertStyle = "invisible";
        }
        public void Check()
        {
            if (Number >= 1 && Number <= 1000)
            {
                if (Number % 3 == 0 && Number % 5 == 0)//Podzielna przez 3 i 5
                {
                    AlertInfo = "FizzBuzz";
                    AlertStyle = "alert alert-success";
                }
                else if (Number % 3 == 0) //Podzielna przez 3
                {
                    AlertInfo = "Fizz";
                    AlertStyle = "alert alert-success";
                }
                else if (Number % 5 == 0)//Podzielna przez 5
                {
                    AlertInfo = "Buzz";
                    AlertStyle = "alert alert-success";
                }
                else //W innych przypadkach
                {
                    AlertInfo = "Liczba: " + Number.ToString() + " nie spełnia kryteriów FizzBuzz";
                    AlertStyle = "alert alert-danger";
                }
            }
        }
    }

}
