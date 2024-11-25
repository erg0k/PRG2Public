using System;
using System.Collections.Generic;
using System.IO;

namespace Week02
{
    class Question03
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader("loaninfo.csv"))
            {
                string? s = sr.ReadLine();

                if (s != null)
                {
                    string[] heading = s.Split(',');
                    Console.WriteLine($"{heading[0], -12} {heading[1], -16} {heading[2], -18} {heading[3], -18} {"Days Loan", -14} {"Days Overdue", -17} {"Fine", -9}");
                }

                List<string> overdueInfo = new List<string> {"Book ID,Borrower ID,Days Overdue,Fine Amount"};
                int overdueCount = 0;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] bookInfo = s.Split(",");
                    string[] borrowTemp = bookInfo[2].Split("/");
                    string[] returnTemp = bookInfo[3].Split("/");

                    DateTime borrowDate = new DateTime(Convert.ToInt32(borrowTemp[0]), Convert.ToInt32(borrowTemp[1]), Convert.ToInt32(borrowTemp[2]));
                    DateTime returnDate = new DateTime(Convert.ToInt32(returnTemp[0]), Convert.ToInt32(returnTemp[1]), Convert.ToInt32(returnTemp[2]));

                    int daysLoan = returnDate.Subtract(borrowDate).Days;
                    int? daysOverdue = null;
                    double? overdueFine = null;

                    if (daysLoan > 14)
                    {
                        daysOverdue = daysLoan - 14;
                        overdueFine = daysOverdue * 0.50;

                        overdueInfo.Add($"{bookInfo[0]},{bookInfo[1]},{daysOverdue},{overdueFine}");
                        overdueCount++;
                    }

                    Console.WriteLine($"{bookInfo[0], -12} {bookInfo[1], -16} {borrowDate.ToString("dd/MM/yyyy"), -18} {returnDate.ToString("dd/MM/yyyy"), -18} " +
                        $"{daysLoan, -14} {daysOverdue, -17} {overdueFine:C}");

                }

                using (StreamWriter sw = new StreamWriter("overdueinfo.csv", false))
                {
                    foreach (string overdue in overdueInfo)
                    {
                        sw.WriteLine(overdue);
                    }
                }

                Console.WriteLine($"\n{overdueCount} records written to overdueinfo.csv");
            }
        }
    }
}