using System;

namespace Gra_przegladarkowa.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //testowa zmiana
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
