using CodeCamp.Core.ViewModels;
using CrossUI.Touch.Dialog.Elements;
using MonoTouch.UIKit;

namespace CodeCamp.App.iOS.Views
{
    public class SessionsView : DialogViewControllerBase
    {
        public SessionsView()
            : base(UITableViewStyle.Plain)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Sessions";
        }

        protected override void OnLoadingComplete()
        {
            Root = new RootElement("Sessions")
            {
            };
        }

        private new SessionsViewModel ViewModel
        {
            get { return (SessionsViewModel)base.ViewModel; }
        }
    }
}