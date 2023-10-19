using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string info_list_box
        {
            get { return $" ID: {Id}. Nombre: {Nombre}. Apellido: {Apellido}.DNI {Dni}."; }
        }

    }
}
