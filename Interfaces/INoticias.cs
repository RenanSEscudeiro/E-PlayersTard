using System.Collections.Generic;
using Eplayers_Tard.Models;

namespace E_players.Interfaces
{
    public interface INoticias
    {
         void Create(Noticias e);
         List<Noticias> ReadAll();
         void Update (Noticias e);
         void Delete(int IdNoticias);
    }
}