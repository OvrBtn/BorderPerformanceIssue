namespace BorderPerformanceIssue
{
    public partial class CarouselWithFrame : ContentPage
    {
        public CarouselWithFrame()
        {
            BindingContext = new SharedViewModel();
            InitializeComponent();
        }
    }

}
