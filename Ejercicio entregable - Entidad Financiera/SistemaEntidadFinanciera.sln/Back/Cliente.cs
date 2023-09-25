namespace Back
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set;}
        public string info_list_box
        {
            get { return $"Cliente {Nombre} {Apellido}. ID: {Id}.Dni: {Dni}."; }
        }
    }
}