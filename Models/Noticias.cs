namespace E_players.Models
{
    public class Noticias
    {
         public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }
        private const string PATH = "Database/noticias.csv";

        public Noticias(){
            CreateFolderAndFile(PATH);
        }

        public void Create(Noticias e){
            string[] linha = { Prepare(e) };
            File.AppendAllLines(PATH, linha);
        }

        private string Prepare(Noticias e){
            return $"{e.IdNoticia};{e.Nome};{e.Imagem}";
        }

        public List<Noticias> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Noticias e)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(y => y.Split(";") [0] == e.IdEquipe.ToString());
            linhas.Add(PrepararLinhas(e) );
            RewriteCSV(PATH, linhas);
        }

        public void Delete(int IdNoticias)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(y => y.Split(";") [0] == IdNoticias.ToString());

            RewriteCSV(PATH, linhas);
        }

    public List<Noticias> ReadAll(){
        List<Noticias> noticia = new List<Noticias>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Noticias equipe = new Noticias();
                Noticias.IdEquipe = Int32.Parse(linha[0]);
                Noticias.Nome = linha[1];
                Noticias.Imagem = linha[2];

                Noticias.Add(Noticias);
            }
            return Noticias;
        }
    }
}

