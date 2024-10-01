namespace FontesCSharp.Core.Entities
{
    public class Artigo
    {
        public string Titulo { get; set; } = "";
        public int Ano { get; set; } = DateTime.Now.Year; // Assume o ano atual
        public string Local { get; set; } = ""; // Esta propriedade precisa ser definida de acordo com a lógica desejada para a URL
        public List<Periodico> Periodicos { get; set; } = new List<Periodico>();
        public List<Autor> Autores { get; set; } = new List<Autor>();
        public List<Referencia> Referencias { get; set; } = new List<Referencia>();
        public List<PalavraChave> PalavrasChave { get; set; } = new List<PalavraChave>();
    }
}
