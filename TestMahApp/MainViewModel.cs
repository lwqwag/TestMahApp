using GalaSoft.MvvmLight;

namespace TestMahApp
{
    public class MainViewModel:ViewModelBase 
    {
		
        private MContact _mContact=new MContact();
        public MContact MContact
        {
            get => _mContact;
            set => Set(ref _mContact, value);
        }

     
    }
}