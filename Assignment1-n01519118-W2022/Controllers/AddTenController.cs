using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01519118_W2022.Controllers
{
    //Assignment 1 - Exercise 1
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Description: This method is design to Add 10 to the integer number {id} received in a get request.
        /// Method: GET api/AddTen/{id}
        /// Examples:
        /// Request: GET localhost/api/AddTen/21 Response: 31
        /// Request: GET localhost/api/AddTen/0 Response: 10
        /// Request: GET localhost/api/AddTen/-9 Response: 1
        /// </summary>
        /// <params name="id">The input representing the number which is going to Add 10</params>
        /// <returns>input number plus 10</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
