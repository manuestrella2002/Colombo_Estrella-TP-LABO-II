using System;

namespace Colombo_Estrella_TP_LABO_II
{
    public class Tablero
    {
        //FUNCION PARA OBTENER TAMAÑO DEL TABLERO NxN
        public int Tam { get; set; }

        //FUNCION PARA OBTENER LA CELDA DE LA MATRIZ[i,j]
        public Celda[,] Matriz { get; set; }

        
        //CONSTRUCTOR DEL TABLERO
        public Tablero(int s)
        {

            Tam = s;

            Matriz = new Celda[Tam, Tam];
            //ASIGNA A CADA LUGAR DE LA MATRIZ[i,j] UNA CELDA CON SU POSICION(i,j)
            for (int i = 0; i < Tam; i++)
            {
                for (int j = 0; j < Tam; j++)
                {
                    Matriz[i, j] = new Celda(i, j);
                }
            }
        }

        //FUNCION PARA MARCAR DE ACUERDO A LA PIEZA QUE SE LE PASA LAS POSICIONES A LAS QUE ATACA
        public void MarcarProx_MovLegal(Celda CeldaActual, Pieza_Ajedrez Pieza_)
        {
            int r;
            //CAMBIA LA POSICION DONDE SE COLOCA LA PIEZA A OCUPADO
            Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Ocupados = true;
            Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Legal_Movim = false;
            if (CeldaActual.Pieza1 != null)
            {
                Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza1 = Pieza_;
                if (Pieza_ is Caballo)
                {
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                }
                else if (Pieza_ is Rey)
                {
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }

                }
                else if (Pieza_ is Reina)
                {
                    //ABAJO 
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }
                    }
                    //ARRIBA
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }

                    }

                    //PARA LA DERECHA
                    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }
                    //PARA LA IZQUIERDA
                    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }

                    //DIAGONAL HACIA ABAJO DERECHA
                    r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }

                    }
                }
                else if (Pieza_ is Torre)
                {
                    //ABAJO 
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }
                    }
                    //ARRIBA
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }

                    }

                    //PARA LA DERECHA
                    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }
                    //PARA LA IZQUIERDA
                    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }

                }
                else if (Pieza_ is Alfil)
                {
                    //DIAGONAL HACIA ABAJO DERECHA
                    r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }

                    }
                }
                else if (Pieza_ is CaballoAlfil)
                {
                    //DIAGONAL HACIA ABAJO DERECHA
                    r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }

                    }
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                }

            }
            else
            {
                Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza1 = Pieza_;
                if (Pieza_ is Caballo)
                {
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                }
                else if (Pieza_ is Rey)
                {
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }

                }
                else if (Pieza_ is Reina)
                {
                    //ABAJO 
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }
                    }
                    //ARRIBA
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }

                    }

                    //PARA LA DERECHA
                    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }
                    //PARA LA IZQUIERDA
                    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }

                    //DIAGONAL HACIA ABAJO DERECHA
                    r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }

                    }
                }
                else if (Pieza_ is Torre)
                {
                    //ABAJO 
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }
                    }
                    //ARRIBA
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }

                    }

                    //PARA LA DERECHA
                    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }
                    //PARA LA IZQUIERDA
                    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }

                }
                else if (Pieza_ is Alfil)
                {
                    //DIAGONAL HACIA ABAJO DERECHA
                    r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }

                    }
                }
                else if (Pieza_ is CaballoAlfil)
                {
                    //DIAGONAL HACIA ABAJO DERECHA
                    r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }

                    }
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                }
            }


        }

        public void DesmarcarLugares(Celda CeldaActual, Pieza_Ajedrez Pieza_)
        {
            {
                int r;
                //CAMBIA LA POSICION DONDE SE COLOCA LA PIEZA A OCUPADO
                //Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Ocupados = false;

                //Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza1 = null;

                if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza2 != null)
                {
                    if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza2 is Caballo)
                    {
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                    }
                    else if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza2 is Rey)
                    {
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }

                    }
                    else if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza2 is Reina)
                    {
                        //ABAJO 
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }
                        }
                        //ARRIBA
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }

                        }

                        //PARA LA DERECHA
                        for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }
                        //PARA LA IZQUIERDA
                        for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }

                        //DIAGONAL HACIA ABAJO DERECHA
                        r = CeldaActual.NroColumna;

                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA DERECHA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ABAJO IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }

                        }
                    }
                    else if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza2 is Torre)
                    {
                        //ABAJO 
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }
                        }
                        //ARRIBA
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }

                        }

                        //PARA LA DERECHA
                        for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }
                        //PARA LA IZQUIERDA
                        for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }

                    }
                    else if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza2 is Alfil)
                    {
                        //DIAGONAL HACIA ABAJO DERECHA
                        r = CeldaActual.NroColumna;

                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA DERECHA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ABAJO IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }

                        }
                    }
                    else if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza2 is CaballoAlfil)
                    {
                        //DIAGONAL HACIA ABAJO DERECHA
                        r = CeldaActual.NroColumna;

                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA DERECHA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ABAJO IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }

                        }
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                    }
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza2 = null;
                    CeldaActual.Pieza2 = null;
                }
                else
                {

                    if (Pieza_ is Caballo)
                    {
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                    }
                    else if (Pieza_ is Rey)
                    {
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }

                    }
                    else if (Pieza_ is Reina)
                    {
                        //ABAJO 
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }
                        }
                        //ARRIBA
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }

                        }

                        //PARA LA DERECHA
                        for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }
                        //PARA LA IZQUIERDA
                        for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }

                        //DIAGONAL HACIA ABAJO DERECHA
                        r = CeldaActual.NroColumna;

                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA DERECHA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ABAJO IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }

                        }
                    }
                    else if (Pieza_ is Torre)
                    {
                        //ABAJO 
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }
                        }
                        //ARRIBA
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }

                        }

                        //PARA LA DERECHA
                        for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }
                        //PARA LA IZQUIERDA
                        for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }

                    }
                    else if (Pieza_ is Alfil)
                    {
                        //DIAGONAL HACIA ABAJO DERECHA
                        r = CeldaActual.NroColumna;

                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA DERECHA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ABAJO IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }

                        }
                    }
                    else if (Pieza_ is CaballoAlfil)
                    {
                        //DIAGONAL HACIA ABAJO DERECHA
                        r = CeldaActual.NroColumna;

                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA DERECHA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ABAJO IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }

                        }
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                    }

                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Ocupados = false;
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza1 = null;
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza2 = null;
                    CeldaActual.Pieza1 = null;
                    CeldaActual.Pieza2 = null;
                    CeldaActual.Ocupados = false;
                }



                //PARA VOLVER A MARCAR EL TABLERO
                for (int i = 0; i < Tam; i++)
                {
                    for (int j = 0; j < Tam; j++)
                    {
                        if (Matriz[i, j].Ocupados == true)
                        {
                            if (Matriz[i, j].Pieza2 == null)
                            {
                                MarcarProx_MovLegal(Matriz[i, j], Matriz[i, j].Pieza1);
                                //MiTablero.ImprimirTablero();
                            }
                            else
                            {
                                Matriz[i, j].Legal_Movim = false;
                                MarcarProx_MovLegal(Matriz[i, j], Matriz[i, j].Pieza1);
                                //MiTablero.ImprimirTablero();
                            }

                        }
                    }
                }

            }
        }

        // FUNCION REINICIA TODO EL TABLERO
        public void ReiniciarTablero()
        {
            for (int i = 0; i < Tam; i++)
            {
                for (int j = 0; j < Tam; j++)
                {
                    Matriz[i, j].Ocupados = false;
                    Matriz[i, j].Legal_Movim = false;
                    Matriz[i, j].Pieza1 = null;
                    Matriz[i, j].Pieza2 = null;
                }
            }
        }

        public void ImprimirTablero()
        {
            for (int i = 0; i < Tam; i++)
            {
                for (int j = 0; j < Tam; j++)
                {
                    if (Matriz[i, j].Pieza2 != null)
                    {
                        if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Caballo && Matriz[i, j].Pieza2 is Alfil)
                        {
                            Console.Write("|CA|");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Alfil && Matriz[i, j].Pieza2 is Caballo)
                        {
                            Console.Write("|CA|");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Caballo)
                        {
                            Console.Write("|C |");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Reina)
                        {
                            Console.Write("|R |");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Rey)
                        {
                            Console.Write("|r |");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Torre)
                        {
                            Console.Write("|T |");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Alfil)
                        {
                            Console.Write("|A |");
                        }
                        else if (Matriz[i, j].Legal_Movim == true)
                        {
                            Console.Write("|+ |");
                        }
                        else
                        {
                            //las que se encuentran vacias
                            Console.Write("|. |");
                        }


                    }
                    else
                    {
                        if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Caballo)
                        {
                            Console.Write("|C |");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Reina)
                        {
                            Console.Write("|R |");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Rey)
                        {
                            Console.Write("|r |");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Torre)
                        {
                            Console.Write("|T |");
                        }
                        else if (Matriz[i, j].Ocupados == true && Matriz[i, j].Pieza1 is Alfil)
                        {
                            Console.Write("|A |");
                        }
                        else if (Matriz[i, j].Legal_Movim == true)
                        {
                            Console.Write("|+ |");
                        }
                        else
                        {
                            //las que se encuentran vacias
                            Console.Write("|. |");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("========================");

        }

        public int CalcularCantMovLegales(Celda CeldaActual, Pieza_Ajedrez pieza_)
        {

            int contador = 0;
            int r;
            if (pieza_ is Caballo)
            {
                if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                {
                    if (Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                {
                    if (Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                {
                    if (Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                {
                    if (Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                {
                    if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                {
                    if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                {
                    if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                {
                    if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
            }
            else if (pieza_ is Rey)
            {
                if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna))
                {
                    if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna))
                {
                    if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1))
                {
                    if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1))
                {
                    if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna - 1))
                {
                    if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna - 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna + 1))
                {
                    if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna + 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1))
                {
                    if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1))
                {
                    if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
            }
            else if (pieza_ is Reina)
            {
                //ABAJO 
                for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                {
                    if (VerificarLugar(i, CeldaActual.NroColumna))
                    {
                        if (Matriz[i, CeldaActual.NroColumna].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //ARRIBA
                for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                {
                    if (VerificarLugar(i, CeldaActual.NroColumna))
                    {
                        if (Matriz[i, CeldaActual.NroColumna].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }

                }

                //PARA LA DERECHA
                for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                {
                    if (VerificarLugar(CeldaActual.NroFila, j))
                    {
                        if (Matriz[CeldaActual.NroFila, j].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //PARA LA IZQUIERDA
                for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                {
                    if (VerificarLugar(CeldaActual.NroFila, j))
                    {
                        if (Matriz[CeldaActual.NroFila, j].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }

                //DIAGONAL HACIA ABAJO DERECHA
                r = CeldaActual.NroColumna;

                for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                {
                    r++;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //DIAGONAL HACIA ARRIBA IZQUIERDA
                r = CeldaActual.NroColumna;
                for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                {
                    r--;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //DIAGONAL HACIA ARRIBA DERECHA
                r = CeldaActual.NroColumna;
                for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                {
                    r++;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //DIAGONAL HACIA ABAJO IZQUIERDA
                r = CeldaActual.NroColumna;
                for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                {
                    r--;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }

                }
            }
            else if (pieza_ is Torre)
            {
                //ABAJO 
                for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                {
                    if (VerificarLugar(i, CeldaActual.NroColumna))
                    {
                        if (Matriz[i, CeldaActual.NroColumna].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //ARRIBA
                for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                {
                    if (VerificarLugar(i, CeldaActual.NroColumna))
                    {
                        if (Matriz[i, CeldaActual.NroColumna].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }

                }

                //PARA LA DERECHA
                for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                {
                    if (VerificarLugar(CeldaActual.NroFila, j))
                    {
                        if (Matriz[CeldaActual.NroFila, j].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //PARA LA IZQUIERDA
                for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                {
                    if (VerificarLugar(CeldaActual.NroFila, j))
                    {
                        if (Matriz[CeldaActual.NroFila, j].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
            }
            else if (pieza_ is Alfil)
            {
                //DIAGONAL HACIA ABAJO DERECHA
                r = CeldaActual.NroColumna;

                for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                {
                    r++;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //DIAGONAL HACIA ARRIBA IZQUIERDA
                r = CeldaActual.NroColumna;
                for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                {
                    r--;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //DIAGONAL HACIA ARRIBA DERECHA
                r = CeldaActual.NroColumna;
                for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                {
                    r++;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //DIAGONAL HACIA ABAJO IZQUIERDA
                r = CeldaActual.NroColumna;
                for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                {
                    r--;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }

                }
            }
            else if (pieza_ is CaballoAlfil)
            {
                //DIAGONAL HACIA ABAJO DERECHA
                r = CeldaActual.NroColumna;

                for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                {
                    r++;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //DIAGONAL HACIA ARRIBA IZQUIERDA
                r = CeldaActual.NroColumna;
                for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                {
                    r--;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //DIAGONAL HACIA ARRIBA DERECHA
                r = CeldaActual.NroColumna;
                for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                {
                    r++;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                }
                //DIAGONAL HACIA ABAJO IZQUIERDA
                r = CeldaActual.NroColumna;
                for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                {
                    r--;
                    if (VerificarLugar(i, r))
                    {
                        if (Matriz[i, r].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }

                }
                if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                {
                    if (Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                {
                    if (Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                {
                    if (Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                {
                    if (Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                {
                    if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                {
                    if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                {
                    if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
                if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                {
                    if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim == false)
                    {
                        contador++;
                    }
                }
            }

            return contador;
        }


        //VERIFICA SI LA COORDENADA PASADA EXISTE EN EL TABLERO SINO RETORNA FALSE
        private bool VerificarLugar(int x1, int y2)
        {

            if (x1 >= 0 && x1 < Tam && y2 >= 0 && y2 < Tam && Matriz[x1,y2].Ocupados==false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
