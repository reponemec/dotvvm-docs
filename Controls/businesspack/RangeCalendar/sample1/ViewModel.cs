using System;

namespace DotvvmWeb.Views.Docs.Controls.businesspack.RangeCalendar.sample1
{
    public class ViewModel
    {
        public DateTime StartDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);
    }
}