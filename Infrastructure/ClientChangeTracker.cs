using System.ComponentModel;
using System.Runtime.CompilerServices;

<<<<<<< HEAD
namespace AspNetcore203.Infrastructure {
=======
namespace AspNetCore203.Infrastructure {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    public class ClientChangeTracker : INotifyPropertyChanged {
        private bool _isDirty;

        public bool IsDirty {
            get { return _isDirty; }
            set { SetWithNotify (value, ref _isDirty); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void SetWithNotify<T>
            (T value, ref T field, [CallerMemberName] string propertyName = "") {
                if (!Equals (field, value)) {
                    field = value;
                    PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (propertyName));
                }
            }
    }
}