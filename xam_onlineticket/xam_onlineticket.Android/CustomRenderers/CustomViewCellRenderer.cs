using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using xam_onlineticket.CustomControls;
using xam_onlineticket.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]
namespace xam_onlineticket.Droid.CustomRenderers
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        private Android.Views.View cellCore;
        private Drawable unselectedBackground;
        private bool selected;

        protected override Android.Views.View GetCellCore(Cell item,
                                                          Android.Views.View convertView,
                                                          ViewGroup parent,
                                                          Context context)
        {
            cellCore = base.GetCellCore(item, convertView, parent, context);
            selected = false;
            unselectedBackground = cellCore.Background;
            return cellCore;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnCellPropertyChanged(sender, e);

            if(e.PropertyName == "IsSelected")
            {
                selected = !selected;

                if (selected)
                {
                    var customViewCell = sender as CustomViewCell;
                    cellCore.SetBackgroundColor(customViewCell.SelectedBackgroundColor.ToAndroid());
                }
                else
                {
                    cellCore.SetBackground(unselectedBackground);
                }
            }
        }
    }
}
