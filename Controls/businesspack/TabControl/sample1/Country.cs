using System.Collections.Generic;

namespace DotvvmWeb.Views.Docs.Controls.businesspack.TabControl.sample1
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Cities { get; set; } = new List<string>();
        public bool IsSelected { get; set; }
    }
}