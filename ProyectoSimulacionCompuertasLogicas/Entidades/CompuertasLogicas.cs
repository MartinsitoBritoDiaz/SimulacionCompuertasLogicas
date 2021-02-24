using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimulacionCompuertasLogicas.Entidades
{
    public class CompuertasLogicas
    {
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }
        public int CantidadPuertos { get; set; }
        public int CantidadSalida { get; set; }
        public bool Estado { get; set; }

        public CompuertasLogicas(string nombre,int cantidadPuertos,int cantidadSalida)
        {
            Nombre = nombre;
            CantidadPuertos = cantidadPuertos;
            CantidadSalida = cantidadSalida;
        }

        public CompuertasLogicas()
        {
        }

    }
}
