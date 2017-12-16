using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using Prism.Navigation;

namespace XFSamples.ViewModels
{
    public class ImageTestPageViewModel : ViewModelBase
    {
        private ObservableCollection<MyImage> _images;
        public ObservableCollection<MyImage> Images
        {
            get { return _images; }
            set { SetProperty(ref _images, value); }
        }

        public ImageTestPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";

            Images = new ObservableCollection<MyImage>
            {
                new MyImage
                {
                    Title = "Random Image",
                    Url = "https://xamarin.com/content/images/pages/forms/example-app.png"
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