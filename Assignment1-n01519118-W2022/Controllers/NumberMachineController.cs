using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01519118_W2022.Controllers
{
    // Assignment 1 - Exercise 5
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Description: This method is design to calculate the result of the input {id} raised to 2, 3, 4 and 5.
        /// The result of each mathmatical operation is returned as an element in the response array.
        /// The parameter {id} is received via GET request.
        /// Method: GET api/NumberMachine/{id}
        /// Examples:
        /// Request: GET localhost/api/NumberMachine/1 Response: {1,1,1,1}
        /// Request: GET localhost/api/NumberMachine/-2 Response: {4,-8,16,-32}
        /// Request: GET localhost/api/NumberMachine/3 Response: {9,27,81,243}
        /// </summary>
        /// <params name="id">The input to be powered by 2, 3, 4, and 5</params>
        /// <returns>List of integers containing the result of each operation</returns>

        public IEnumerable<int> Get(int id)
        {
            return (new int[] { (int)Math.Pow(id, 2), (int)Math.Pow(id, 3), (int)Math.Pow(id, 4), (int)Math.Pow(id, 5) });
        }
    }
}
