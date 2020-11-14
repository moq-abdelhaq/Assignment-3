using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class DatabaseService
    {
        //This is a class supposed to handle query and connection to SQLite database 
        public void Connect(DBConnection connection) {
            //This is an example of data coupling where a DBconnection is needed to be passed 
            //for this function in order to further create the connection to Database
        }

    }
}
