using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01519118_W2022.Controllers
{
    // Assignment 1 - Exercise 3 and 4

    public class GreetingController : ApiController
    {
        /// <summary>
        /// Description: This method is design to greet the world whenever someone makes a Post request.
        /// Method: POST api/Greeting
        /// Examples:
        /// Request: POST localhost/api/Greeting Response: "Hello World!"
        /// Prompt request: curl -d "" localhost/api/Greeting
        /// </summary>
        /// <params></params>
        /// <returns>Fixed "Hello World!" string</returns>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Description: 
        /// This method is design to greet a number of friends {id} upon a Post request.
        /// I introduced a small validation to check if the number of friends {id} is valid (greater than 0)
        /// Method: POST api/Greeting/{id}
        /// Examples:
        /// Request: POST localhost/api/Greeting/{id} Response: "Greetings to {id} people!"
        /// Request: POST localhost/api/Greeting/3 Response: "Greetings to 3 people!"
        /// Request: POST localhost/api/Greeting/0 Response: "Greetings to 0 people!"
        /// Prompt request: curl -d "" localhost/api/Greeting/{id}
        /// </summary>
        /// <params name="id">The input representing the number of people to be greeted</params>
        /// <returns>
        ///     Phrase greeting the input number of people -> "Greetings to " + id + " people!"
        ///     Or, case the number of people is invalid (lesser or equal 0) hardcoded string ->"There is no one to greet."
        /// </returns>
        public string Post(int id)
        {
            if(0 < id)
            {
                return ("Greetings to " + id + " people!");
            }
            return "There is no one to greet.";
        }
        
    }
}
