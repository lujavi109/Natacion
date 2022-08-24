using ComparativoMarcas.app.Dominio;
namespace ComparativoMarcas.app.Dominio
{
    public class Deportista{
        public int documento_identidad{get; set;}
        public string club{get;set;}
        public string liga{get; set;}
        public int año_categoria{get; set;}
        public Genero Genero{get; set;}
        public string nombre{get;set;}
        public string apellidos{get;set;}
        public string cumple{get;set;}
        public string no_cumple{get;set;}
        

        

    }
}
