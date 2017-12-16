using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XFSamples.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<MyImage> _images;
        public ObservableCollection<MyImage> Images
        {
            get { return _images; }
            set { SetProperty(ref _images, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            Images = new ObservableCollection<MyImage>
            {
                new MyImage
                {
                    Title="Random Image",
                    Url = "http://perlich.auction/userfile/lot/872AB4A1-84C2-473C-8AB4-E01830C29C30.jpg"
                }
            };
        }
    }

    public class MyImage
    {
        public string Title { get; set; }

        public string Url { get; set; }
    }
}