using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonPrinter
{
    public class PrinterService : Printer.PrinterBase
    {
        private int GetAge(char gender, string dateOfBirth)
        {
            string birthDate;

            if (gender == '1' || gender == '2')
            {
                birthDate = "19" + dateOfBirth;
            }
            else
            {
                birthDate = "20" + dateOfBirth;
            }

            return (Int32.Parse(DateTime.Today.ToString("yyyyMMdd")) -
                Int32.Parse(birthDate)) / 10000;
        }

        public override Task<PrintReply> PrintPerson(PrintRequest request, ServerCallContext context)
        {
            string gender = "";
            string age = "";

            if (request.CNP.Length >= 7 )
            {
                var genderNumber = request.CNP.ElementAt(0);
                var dateOfBirth = request.CNP.Substring(1, 6);

                if (genderNumber == '1' || genderNumber == '5')
                {
                    gender = "Male";
                }
                else
                {
                    if (genderNumber == '2' || genderNumber == '6')
                    {
                        gender = "Female";
                    }
                }

                age = GetAge(genderNumber, dateOfBirth).ToString();
                Console.WriteLine(request.Name + " , " + gender + " , " + age + " years old.");
            }
            else
            {
                Console.WriteLine(request.Name + " wrong input!");
            }

            return Task.FromResult(new PrintReply
            {
                MName = request.Name,
                MAge = age,
                MGender = gender
            });
        }
    }
}
