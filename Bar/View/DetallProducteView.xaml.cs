using Bar.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Bar.View
{
    public partial class DetallProducteView : ContentPage
    {
        //OBJECTE PRODUCTE DE LA CLASE, QUE ENS PASARA LA LLISTA
        private List<Carta> _cartes;
        public List<Carta> Cartes { get { return _cartes; } set { _cartes = value; OnPropertyChanged(); } }
        private Producte _producteDetall;
        public Producte ProducteDetall { get { return _producteDetall; } set { _producteDetall = value; OnPropertyChanged(); } }

        //QUAN OBRIM ESTE DETALL, LA LLISTA ENS PASARA SEMPRE EL OBJECTE PRODUCTE
        public DetallProducteView(Producte producteLlista)
        {
            InitializeComponent();
            //DIGUEM QUE EL PRODUCTE DEL BINDING, ES EL QUE ENS PASA EL CONSTRUCTOR
            ProducteDetall = producteLlista;
            Cartes = BaseDades.Cartes;
            //EL BINDING CONTEXT DE DetallProducte.xaml (Producte.Atribut) APUNTARA A AQUEST _producteDetall
            BindingContext = this;
        }


        private Boolean nou = false;
        private void ClickedNou(object sender, EventArgs e)
        {
            ProducteDetall = new Producte();
            nou = true;
        }

        private void ClickedEsborra(object sender, EventArgs e)
        {
            if (BaseDades.BorrarProducte(ProducteDetall))
            {
                DisplayAlert("INFO","Producte borrat amb exit","OK");
            }
            else
            {
                DisplayAlert("ERROR", "El producte no existeix en la BBDD", "OK");
            }
        }

        private void ClickedDesa(object sender, EventArgs e)
        {
            if (nou)
            {
                if (BaseDades.NouProducte(ProducteDetall))
                {
                    DisplayAlert("INFO", "Producte afegit", "OK");
                }
                else
                {
                    DisplayAlert("ERROR", "El producte ja existeix en la BBDD", "OK");
                }
            }
            else
            {
                if (BaseDades.ActualitzaProduce(ProducteDetall))
                {
                    DisplayAlert("INFO", "Producte actualitzat", "OK");
                }
                else
                {
                    DisplayAlert("ERROR", "El no s'ha actualitzat", "OK");
                }
            }
        }
    }
}