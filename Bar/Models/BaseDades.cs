using System;
using System.Collections.Generic;
using System.Text;

namespace Bar.Models
{
    internal class BaseDades
    {
        //LISTA
        public static List<Producte> Productes { get; set; } = new List<Producte>();
        public static List<Carta> Cartes { get; set; } = new List<Carta>();

        

        //AFEGIR PRODUCTE
        public static Boolean NouProducte(Producte nou)
        {
            Boolean trobat = false;
            foreach (Producte p in Productes)
            {
                if (p.Id == nou.Id)
                {
                    trobat = true;
                    break;
                }
            }
            if (!trobat)
            {
                Productes.Add(nou);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //BORRAR PRODUCTE
        public static Boolean BorrarProducte(Producte prod)
        {
            if (Productes.Contains(prod))
            {
                Productes.Remove(prod);
                return true;
            }
            else
            {
                return false;
            }
        }
        //ACTUALIZA PRODUCTE
        public static Boolean ActualitzaProduce(Producte prod)
        {
            int posicion=0;

            foreach (Producte p in Productes)
            {
                   posicion = Productes.IndexOf(p);
                if (p.Id == prod.Id)
                {
                    Productes[posicion] = prod;
                    return true;
                }
            }
            return false;
        }
        //AFEGIM PRODUCTES DE PROBA
        static BaseDades()
        {
            Carta entrantes = new Carta(1, "Entrante",null); 
            Carta ehelados = new Carta(2, "Helado", entrantes); Cartes.Add(ehelados);
            Carta ecalientes = new Carta(3, "Caliente", entrantes); Cartes.Add(ecalientes);
            Carta platos = new Carta(4, "Plato",null); 
            Carta phelados = new Carta(5, "Helado", platos); Cartes.Add(phelados);
            Carta pcalientes = new Carta(6, "Caliente", platos); Cartes.Add(pcalientes);
            Carta pizzas = new Carta(7, "Pizza",null); Cartes.Add(pizzas);
            Carta bocadillos = new Carta(8, "Bocadillos",null); 
            Carta bhelados = new Carta(9, "Helado", bocadillos); Cartes.Add(bhelados);
            Carta bcalientes = new Carta(10, "Caliente", bocadillos); Cartes.Add(bcalientes);
            Carta bebidas = new Carta(11, "Bebidas",null); 
            Carta refrescos = new Carta(12, "Refresco", bebidas); Cartes.Add(refrescos);
            Carta vinos = new Carta(13, "Vino", bebidas); Cartes.Add(vinos);
            Carta postres = new Carta(14, "Postres",null); 
            Carta postreshelados = new Carta(15, "Helado", postres); Cartes.Add(postreshelados);
            Carta postrescalientes = new Carta(16, "Caliente", postres); Cartes.Add(postrescalientes);

            Producte p1 = new Producte(1, "Ensaladilla", "Patatas,salsa rusa,sepia", 3.99, null, ehelados);
            Producte p2 = new Producte(2, "Bravas", "Patatas bravas,salsa brava", 1.50, null, ecalientes);
            Producte p3 = new Producte(3, "Ensalada", "Tomate,lechuga,atun", 1, null, phelados);
            Producte p4 = new Producte(4, "Solomillo", "Solomillo de 500gr con patatas", 6, "Ternera", pcalientes);
            Producte p5 = new Producte(5, "Mero", "Mero de 500gr con verduras", 8.50, null, pcalientes);
            Producte p6 = new Producte(6, "Barbacoa", "Tomate,queso,carne picada,atun,bacon,salsa barbacoa", 15.99, null, pizzas);
            Producte p7 = new Producte(7, "Vegetal", "Lechuga,tomate,queso fresco,atun", 10.99, null, bhelados);
            Producte p8 = new Producte(8, "Brascada", "Lomo,bacon,pimiento", 2.99, "Ajo", bcalientes);
            Producte p9 = new Producte(9, "Agua", "Botella de 500ml", 4.30, null, bebidas);
            Producte p10 = new Producte(10, "Cocacola", "Botella de 300ml", 5, null, refrescos);
            Producte p11 = new Producte(11, "Tinto", "Botella de 1L", 5, null, vinos);
            Producte p12 = new Producte(12, "Bolas de helado", "Dos bolas de helado de chocolate", 5, null, postreshelados);
            Producte p13 = new Producte(13, "Brownie", "Brownie y helado", 5, null, postrescalientes);
            Productes.Add(p1);  Productes.Add(p2);  Productes.Add(p3);
            Productes.Add(p4); Productes.Add(p5); Productes.Add(p6);
            Productes.Add(p7); Productes.Add(p8); Productes.Add(p9);
            Productes.Add(p10); Productes.Add(p11); Productes.Add(p12);
            Productes.Add(p13);
        }
    }
}
