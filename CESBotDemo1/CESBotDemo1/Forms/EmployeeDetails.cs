using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CESBotDemo1.Forms
{
    [Serializable]
    public class EmployeeDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
    }
}