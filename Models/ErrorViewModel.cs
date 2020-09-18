using System;

namespace Gra_przegladarkowa.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //test
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
