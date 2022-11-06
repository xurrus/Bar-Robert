using System;
using System.Collections.Generic;
using System.Text;

namespace Bar.Models
{
    public class Producte : ModelBase
    {
        //PROPIEDADES
        private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private String _nom;
        public String Nom { get { return _nom; } set { _nom = value; OnPropertyChanged(); } }
        private String _descripcio;
        public String Descripcio { get { return _descripcio; } set { _descripcio = value; OnPropertyChanged(); } }
        private double _pvp;
        public double PVP { get { return _pvp; } set { _pvp = value; OnPropertyChanged(); } }
        private String _alergens;
        public String Alergens { get { return _alergens; } set { _alergens = value; OnPropertyChanged(); } }
        private Carta _carta;
        public Carta Carta { get { return _carta; } set { _carta = value; OnPropertyChanged(); } }

        //CONSTUCTOR
        public Producte(int id, String nom, String descripcio, double pvp, String alergens, Carta cart)
        {
            this._id = id;
            this._nom = nom;
            this._descripcio = descripcio;
            this._pvp = pvp;
            this._alergens = alergens;
            this._carta = cart;
        }

        //CONSTRUCTOR VACIO
        public Producte() { }
    }
}
