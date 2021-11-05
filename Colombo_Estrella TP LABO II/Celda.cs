namespace Colombo_Estrella_TP_LABO_II
{
    public class Celda
    {
        public enum Color_Celda
        {
            BLANCO,
            NEGRO
        };

        public int NroColumna { get; set; }
        public int NroFila { get; set; }
        public bool Ocupados { get; set; }
        public bool Legal_Movim { get; set; }
        public Pieza_Ajedrez Pieza1 { get; set; }
        public Pieza_Ajedrez Pieza2 { get; set; }
        public Color_Celda Color { get; set; }
        public int aux { get; set; }


        public Celda(int x, int y)
        {
            NroFila = x;
            NroColumna = y;

            if (NroFila % 2 == 0 && NroColumna % 2 == 0)
            {
                Color = Color_Celda.BLANCO;
            }
            else if (NroFila % 2 != 0 && NroColumna % 2 == 0)
            {
                Color = Color_Celda.NEGRO;
            }
            else if (NroFila % 2 == 0 && NroColumna % 2 != 0)
            {
                Color = Color_Celda.NEGRO;
            }
            else if (NroFila % 2 != 0 && NroColumna % 2 != 0)
            {
                Color = Color_Celda.BLANCO;
            }

        }
    }
}
