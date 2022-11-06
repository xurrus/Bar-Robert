using System;
using System.Collections.Generic;
using System.Text;

namespace Bar.Models
{
    public class Carta : ModelBase
    {
        //ATRIB
        private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private String _nom;
        public String Nom { get { return _nom; } set { _nom = value; OnPropertyChanged(); } }
        private Carta _pare;
        public Carta Pare { get { return _pare; } set { _pare = value; OnPropertyChanged(); } }
        private String _etiqueta;
        public String Etiqueta
        {
            get
            {
                if (this._pare != null)
                {
                    return _pare.Etiqueta + " "+this._nom;
                }
                else
                {
                    return this._nom;
                }
                
            }
        }


        //CONSTRUCTOR
        public Carta() { }
        public Carta(int id, String nom, Carta pare)
        {
            _id = id;
            _nom = nom;
            _pare = pare;
        }


    }
}
