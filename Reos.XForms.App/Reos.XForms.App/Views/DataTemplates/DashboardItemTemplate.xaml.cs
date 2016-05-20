using ImageCircle.Forms.Plugin.Abstractions;
using Reos.App.Model.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Reos.XForms.App
{
    public partial class DashboardItemTemplate : ContentView
    {
        public event EventHandler<WidgetTappedEventArgs> Tapped;

        public DashboardItemTemplate(MainMenuItem menuItem)
        {
            InitializeComponent();

            RelativeLayout layout = new RelativeLayout();
            layout.BackgroundColor = Color.FromHex("#ffffff");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                Tapped?.Invoke(this, new WidgetTappedEventArgs(menuItem.TargetPage));
            };

            layout.GestureRecognizers.Add(tapGestureRecognizer);

            var backgroundImage = new Image()
            {
                Source = new FileImageSource() { File = menuItem.BackgroundImage },
                Aspect = Aspect.AspectFill,
                InputTransparent = false
            };

            layout.Children.Add(backgroundImage,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height;
                }));

            var iconImage = new CircleImage()
            {
                Source = new FileImageSource() { File = menuItem.IconSource },
                Aspect = Aspect.AspectFill,
                BorderColor = Color.Black,
                BorderThickness = 1,
                WidthRequest = 20,
                HeightRequest = 20,
                InputTransparent = false
            };

            layout.Children.Add(
                iconImage,
                Constraint.RelativeToParent((parent) => {
                    return ((parent.Width / 2) - (iconImage.Width / 2));
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height * .25;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width * .45;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width * .45;
                })
            );

            iconImage.SizeChanged += (sender, e) => {
                layout.ForceLayout();
            };

            var dashlabel = new Label()
            {
                Text = menuItem.Title,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontFamily = Device.OnPlatform("AvenirNextCondensed-Bold", "sans-serif-condensed", null),
                InputTransparent = true
            };

            layout.Children.Add(dashlabel,
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height - 30;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height;
                }));

            var dashItemCount = new Label
            {
                Text = menuItem.ItemCount == 0 ? string.Empty : menuItem.ItemCount.ToString(),
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontFamily = Device.OnPlatform("AvenirNextCondensed-Bold", "sans-serif-condensed", null),
                InputTransparent = true
            };

            layout.Children.Add(dashItemCount,
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height - 10;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height;
                }));

            Content = layout;
        }

        public class WidgetTappedEventArgs : EventArgs
        {
            private Type _page;
            public Type Page
            {
                get { return _page; }
            }

            public WidgetTappedEventArgs(Type page)
            {
                _page = page;
            }
        }
    }
}
