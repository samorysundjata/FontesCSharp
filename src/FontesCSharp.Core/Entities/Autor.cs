namespace FontesCSharp.Core.Entities
{
    public class Autor //Refazer?
    {
        public string Nome { get; set; } = "";
        public List<Instituicao> Instituicoes { get; set; } = new List<Instituicao>();
    }
}
