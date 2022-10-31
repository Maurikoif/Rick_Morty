using System;

namespace Rick_Morty
{
    public class Escape
    {

        static private string[] _incognitasSalas = new string[4];
        static private int _estadoJuego;
        


        static public void InicializarJuego()
        {
            _estadoJuego = 1;
            _incognitasSalas[0]="Sufrimiento";
            _incognitasSalas[1]="Hombre Pajaro";
            _incognitasSalas[2]="Television interdimencional";

        }
        static public bool ResolverSala(int Sala, string Incognita){
            System.Console.WriteLine(Sala + " " + _estadoJuego);
            if(Sala!= _estadoJuego)
            {
                return false;
            }
            else if(Incognita==_incognitasSalas[Sala-1]){
                _estadoJuego++;
                return true;
                
            }
            else
            return false;
        }
       
        static public int EstadoJuego
        {
            get
            {
                return _estadoJuego;
            }
        }
        

    }
}