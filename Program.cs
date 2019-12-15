using System;
using System.Linq;
using GigaSpaces.Core;
using GigaSpaces.Core.Document;
using GigaSpaces.Core.Exceptions;
using GigaSpaces.Core.Linq;

namespace BOAFirstNETApp
{
	class Program
    {
        static void Main(string[] args)
        {            
            String url = "jini://*/*/sql_demo?locators=localhost";
            Console.WriteLine("Connecting to data grid " + url);
            ISpaceProxy spaceProxy = GigaSpacesFactory.FindSpace(url);

            Console.WriteLine("Read a document from the space");

            // Read a person by template
            SpaceDocument template = new SpaceDocument("com.bofa.common.Person");
            //can add condition:
            //template[lastName]="Yael";
            SpaceDocument result = spaceProxy.Read(template);
            Console.WriteLine("Result read by templat: " + result);            
            Console.WriteLine("Demo completed - press ENTER to exit");
            Console.ReadLine();           
        }
    }
}
