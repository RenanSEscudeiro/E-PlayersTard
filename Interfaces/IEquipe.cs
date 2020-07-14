using System.Collections.Generic;
using Eplayers_Tard.Models;

namespace E_players.Interfaces
{
    public interface IEquipe
    {
         void Create(Equipe e);
         List<Equipe> ReadAll();
         void Update (Equipe e);
         void Delete(int IdEquipe);
    }
}