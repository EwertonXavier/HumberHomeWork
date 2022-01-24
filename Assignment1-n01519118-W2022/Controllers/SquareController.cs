using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01519118_W2022.Controllers
{
    // Assignment 1 - Exercise 2
    public class SquareController : ApiController
    {
        /// <summary>
        /// Description: This method is design to return the square of a integer number {id} received via get request.
        /// Method: GET api/AddTen/{id}
        /// Examples:
        /// Request: GET localhost/api/Square/2 Response: 4
        /// Request: GET localhost/api/Square/-2 Response: 4
        /// Request: GET localhost/api/Square/10 Response: 100
        /// </summary>
        /// <params name="id">The input to be squared</params>
        /// <returns>input multplied by itself</returns>

        public int Get(int id)
        {
            return id * id;
        }
    }
}
