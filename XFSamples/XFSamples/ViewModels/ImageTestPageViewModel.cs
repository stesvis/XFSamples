using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using Prism.Navigation;
using XFSamples.Models;

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
                    Url = "https://xamarin.com/content/images/pages/forms/example-app.png",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
                }
            };
        }
    }
}