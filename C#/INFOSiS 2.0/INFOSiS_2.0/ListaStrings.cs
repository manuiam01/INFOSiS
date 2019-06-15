namespace INFOSiS_2._0
{
    public class ListaStrings
    {
        private string cadena;

        public ListaStrings(string cadena)
        {
            this.Cadena = cadena;
        }
        public string Cadena { get => cadena; set => cadena = value; }
    }
}