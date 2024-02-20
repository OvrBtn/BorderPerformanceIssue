namespace BorderPerformanceIssue
{
    public partial class CarouselWithBorder : ContentPage
    {
        public CarouselWithBorder()
        {
            BindingContext = new SharedViewModel();
            InitializeComponent();
        }
    }

}
