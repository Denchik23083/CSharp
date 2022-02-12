using Blazor.Db.Entities.Test;
using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.Shared.Test
{
    public partial class Counter
    {

        [Inject] private SingletonService Singleton { get; set; }

        [Inject] private TransientService Transient { get; set; }

        [Inject] private ScopedService Scoped { get; set; }

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