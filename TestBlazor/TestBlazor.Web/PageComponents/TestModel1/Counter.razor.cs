using Blazor.Db.Entities.TestModel1;
using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.PageComponents.TestModel1
{
    public partial class Counter
    {
        [Inject] private SingletonService Singleton { get; set; }

        [Inject] private TransientService Transient { get; set; }

        [Inject] private ScopedService Scoped { get; set; }

        [CascadingParameter] public AppStyle Styles { get; set; }

        private int _currentCount;

        private void IncrementCount()
        {
            _currentCount++;

            Singleton.Value = _currentCount;
            Transient.Value = _currentCount;
            Scoped.Value = _currentCount;
        }
    }
}