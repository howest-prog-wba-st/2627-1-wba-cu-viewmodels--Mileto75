namespace cu.ViewModels.Lesvoorbeeld.ViewModels
{
    public class GamesIndexViewModel
    {
        //a list of game titles
        public IEnumerable<BaseViewModel> Games { get; set; }
        public string PageTitle { get; set; }
    }
}
