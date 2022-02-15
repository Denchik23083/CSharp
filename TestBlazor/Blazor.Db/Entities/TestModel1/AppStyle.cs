using System.Collections.Generic;

namespace Blazor.Db.Entities.TestModel1
{
    public class AppStyle
    {
        public string Color { get; set; } = "Green";

        public string Size { get; set; } = "65px";

        public List<TableListStyles> TableListStyles { get; set; } = new List<TableListStyles>()
        {
            new() { Text = "Table Dark", Value = "table-dark" },
            new() { Text = "Table Striped", Value = "table-striped" },
            new() { Text = "Table Bordered", Value = "table-bordered" },
        };
    }
}