using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalesJournal
{
    /// <summary>
    /// Interaction logic for ImageButton.xaml
    /// </summary>
    public partial class ImageButton : Control
    {
        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton),
                new FrameworkPropertyMetadata(typeof(ImageButton)));
        }


        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(ImageButton), new PropertyMetadata(default(ImageSource)));

    }
}
