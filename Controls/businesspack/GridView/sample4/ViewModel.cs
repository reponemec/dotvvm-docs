using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.Controls;

namespace DotvvmWeb.Views.Docs.Controls.businesspack.GridView.sample4
{
    public class ViewModel
    {
        public GridViewDataSet<Customer> Customers { get; set; }

        public override Task Init()
        {
            Customers = new GridViewDataSet<Customer> {
                OnLoadingData = GetData
            };
            Customers.SetSortExpression(nameof(Customer.Id));

            return base.Init();
        }

        public GridViewDataSetLoadedData<Customer> GetData(IGridViewDataSetLoadOptions gridViewDataSetOptions)
        {
            var queryable = GetQueryable(15);
            return queryable.GetDataFromQueryable(gridViewDataSetOptions);
        }

        private IQueryable<Customer> GetQueryable(int size)
        {
            var numbers = new List<Customer>();
            for (var i = 0; i < size; i++)
            {
                numbers.Add(new Customer { Id = i + 1, Name = $"Customer {i + 1}", Orders = i });
            }
            return numbers.AsQueryable();
        }
    }
}