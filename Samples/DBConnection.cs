using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class DBConnection
    { //DB connection class
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";

        //Low Cohesion to include query in a DBconnection class 
        //passing this to DatabaseService also result into Stamp Coupling, since Database service 
        //dont relay on Query for creating a connection 
        public string Query { get; set; }

    }
}
