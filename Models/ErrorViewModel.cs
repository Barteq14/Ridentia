using System;

namespace Gra_przegladarkowa.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //testoasaswa ostatnia zamina
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
