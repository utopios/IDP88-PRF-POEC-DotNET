using Microsoft.AspNetCore.Components;

namespace CoursDemosBlazor.Pages
{
    public partial class Counter
    {
        [Parameter]
        public int Value { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        private int currentCount = 0;

        void IncrementCount()
        {
            currentCount++;
            if (currentCount == 13)
                NavigationManager.NavigateTo("counter2/13");

        }
    }
}
