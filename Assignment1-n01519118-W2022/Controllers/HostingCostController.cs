using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01519118_W2022.Controllers
{
    //Assignment 1 - Question 6
    public class HostingCostController : ApiController
    {

        //Parameters if you want to alter prices
        double fortnightPrice = 5.50;
        double hostingPrice = 0.13;

        //Variables Declaration
        double totalCost;
        double hostingCost;
        double fortnightCost;
        int numberOfFortnight;

        /// <summary>
        /// This method expect the number of the days someone has contracted your services {id}.
        /// With that it calculates how much money did your services cost, and return it in a string format.
        /// Conditions: number of days must be equal or greater than 0.
        /// Method: GET localhost/api/HostingCost/{id}
        /// Example:
        ///     Request:
        ///         GET localhost/api/HostingCost/14
        ///     Response:
        ///         2 fortnights at 5.50/FN = $11.00 CAD
        ///         HST 13% = $1.43 CAD
        ///         Total = $12.43 CAD
        /// </summary>
        /// <params name="id">The input representing the number of elapsed days of hosting service</params>
        /// <returns>The breakdown of the service cost and total amount </returns>
        ///
        public IEnumerable<string> Get(int id)
        {
            if (id >= 0)
            {
                numberOfFortnight = (int)Math.Ceiling((double)0.001 + id / 14);
                fortnightCost = Math.Round(numberOfFortnight * fortnightPrice, 2);
                hostingCost = Math.Round(fortnightCost * hostingPrice, 2);
                totalCost = Math.Round(hostingCost + fortnightCost, 2);
                string fnPriceResponse = numberOfFortnight + " fortnights at " + fortnightPrice.ToString("0.00") + "/FN = $" + fortnightCost.ToString("0.00") + " CAD";
                string hstCostResponse = "HST " + hostingPrice * 100 + "% = $" + hostingCost + " CAD";
                string totalCostResponse = "Total = $" + totalCost + " CAD";

                return (new string[] { fnPriceResponse, hstCostResponse, totalCostResponse});

            }
            return new string[] { "Number of days must be greater than 0." };
        }

    }
}
