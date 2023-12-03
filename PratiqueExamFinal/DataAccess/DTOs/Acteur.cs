using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamFinal.DataAccess.DTOs;
internal class Acteur
{
    public const int MAX_NOM_LENGTH = 40;
    public const int MAX_AGE_LENGTH = 2;
    public int Id { get; set; }
    public string NomActeur { get; set; }
    public string Age { get; set; }
    public byte[] Version { get; set; }

    public  virtual List<SerieTele> SerieTeles { get; set; }

    public Acteur() 
    { 
    
    }

    public Acteur(int id, string nomActeur, string age, byte[] version) 
    {
      this.Id = id;
      this.NomActeur = nomActeur;
      this.Age = age;
      this.Version = version;
    }

}
