using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public static class LoanDataSorter
    {
        public static  IEnumerable<LoanData> SortAscending(String property, IEnumerable<LoanData> loanDataQuery)
        {
            IEnumerable<LoanData> result = loanDataQuery;
            if (property == LoanDataProperties.LoanAmount.ToString())
            {
                result = loanDataQuery.OrderBy(l => l.LoanAmount);
            }
            else if (property == LoanDataProperties.InterestRate.ToString())
            {
                result = loanDataQuery.OrderBy(l => l.InterestRates);
            }
            else if (property == LoanDataProperties.LoanTerm.ToString())
            {
                result = loanDataQuery.OrderBy(l => l.LoanTerm);
            }
            else if (property == LoanDataProperties.TotalCost.ToString())
            {
                result = loanDataQuery.OrderBy(l => l.TotalCost);
            }
            else if (property == LoanDataProperties.MonthlyBill.ToString())
            {
                result = loanDataQuery.OrderBy(l => l.MonthlyBill);
            }
            else if (property == LoanDataProperties.Id.ToString())
            {
                result = loanDataQuery.OrderBy(l => l.Id);
            }
            return result;
        }

        public static IEnumerable<LoanData> SortDescending(String property, IEnumerable<LoanData> loanDataQuery)
        {
            IEnumerable<LoanData> result = loanDataQuery;
            if (property == LoanDataProperties.LoanAmount.ToString())
            {
                result = loanDataQuery.OrderByDescending(l => l.LoanAmount);
            }
            else if (property == LoanDataProperties.InterestRate.ToString())
            {
                result = loanDataQuery.OrderByDescending(l => l.InterestRates);

            }
            else if (property == LoanDataProperties.LoanTerm.ToString())
            {
                result = loanDataQuery.OrderByDescending(l => l.LoanTerm);

            }
            else if (property == LoanDataProperties.TotalCost.ToString())
            {
                result = loanDataQuery.OrderByDescending(l => l.TotalCost);

            }
            else if (property == LoanDataProperties.MonthlyBill.ToString())
            {
                result = loanDataQuery.OrderByDescending(l => l.MonthlyBill);

            }
            else if (property == LoanDataProperties.Id.ToString())
            {
                result = loanDataQuery.OrderByDescending(l => l.Id);

            }
            return result;
        }

    }
}
