using Bar.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Bar.View
{
    public partial class LlistaProducteView : ContentPage
    {
        //CREEM UN ITEM PER A BINDEJAR
        private ObservableCollection<Producte> _Items;
        public ObservableCollection<Producte> Items { get { return _Items; } set { _Items = value; OnPropertyChanged();  } }

        //CONSTRUCTOR
        public LlistaProducteView()
        {
            InitializeComponent();
            //DIGUEM QUE EL ITEM (PUBLIC) DEL BINDING, APUNTARA A LA LLISTA DE LA BBDD
            Items = new ObservableCollection<Producte>(BaseDades.Productes);
            //EL BINDING CONTEXT DE LlistaProducte.xaml (Binding Items) APUNTARA ACI
            BindingContext = this;
        }

        //METODO QUE SE HACE CUANDO PULSAMOS UNO
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //CUANDO PULSAMOS UNO DE LA LISTA, RECOGEMOS ESE OBJETO
            Producte producte = (Producte)e.Item;
            //SI ES NULL NADA (ESTO RARAMENTE PASA)
            if (producte == null)
                return;
            //CUANDO LO RECOGEMOS, ABRIMOS LA VISTA DE DETALLE, PASANDOLE ESE OBJETO
            await Navigation.PushAsync(new DetallProducteView(producte));
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        //AQUEST METODE SERVEIX PER A QUE ES REFRESQUE LA LLISTA CADA VEGADA QUE APAREGA
        protected override void OnAppearing()
        {
            Items = new ObservableCollection<Producte>(BaseDades.Productes);
        }
    }
}