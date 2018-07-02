using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ebunny_note.Windows
{
    /// <summary>
    /// Interaction logic for Editandpreview.xaml
    /// </summary>
    public partial class Editandpreview : UserControl
    {
        public Editandpreview()
        {
            InitializeComponent();
        }

        private void Separator_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            bool zoom = EditorWebBrowserEditorColumn.Width == GridLengthHelper.Star;
            if (zoom)
            {
                EditorWebBrowserPreviewColumn.Width = GridLengthHelper.Star;
                EditorWebBrowserEditorColumn.Width = GridLengthHelper.Zero;

            }
            else
            {
                EditorWebBrowserPreviewColumn.Width = new GridLength(ebApp.Configuration.WindowPosition.InternalPreviewWidth);
                EditorWebBrowserEditorColumn.Width = GridLengthHelper.Star;
            }
        }
    }
}
