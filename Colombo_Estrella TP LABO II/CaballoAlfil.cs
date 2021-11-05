using System;
using System.Collections.Generic;
using System.Text;

namespace Colombo_Estrella_TP_LABO_II
{
    public class CaballoAlfil : Pieza_Ajedrez 
    {
        public Color_Pieza Color_ { get; set; }

        public CaballoAlfil(Color_Pieza aux)
        {
            Color_ = aux;
        }
    }
}
