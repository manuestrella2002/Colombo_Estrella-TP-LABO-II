namespace Colombo_Estrella_TP_LABO_II
{
    public class Celda
    {
        public int NroColumna { get; set; }
        public int NroFila { get; set; }
        public bool Ocupados { get; set; }
        public bool Legal_Movim { get; set; }
        public string Pieza { get; set; }

        public Celda(int x, int y)
        {
            NroFila = x;
            NroColumna = y;
        }
    }
}
