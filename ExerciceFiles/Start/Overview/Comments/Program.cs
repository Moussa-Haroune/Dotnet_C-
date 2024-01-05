using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// this is the main sample application function
        /// </summary>
        /// /// <param name='args'> An array of strinf arguements from command line </param>
        /// <returns>
        /// No return value
        /// </returns>
        static void Main(string[] args)
        {
            // Single line comments start with twp slashes
            Console.WriteLine("Hello World!");
            /* Multiple line comments start with a slash and a star and can continuefor several lines
            until a closinf star and slash are encountered */

        }
    }
}
