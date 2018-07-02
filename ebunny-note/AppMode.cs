using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ebunny_note
{
    public class AppMode : INotifyPropertyChanged
    {
        public MainWindow Window { get; set; }


        /// <summary>
        /// Check tab open
        /// </summary>
        public bool IsTabOpen
        {
            get
            {
                return Window.TabControl.Items.Count > 0;
            }
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
       
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
