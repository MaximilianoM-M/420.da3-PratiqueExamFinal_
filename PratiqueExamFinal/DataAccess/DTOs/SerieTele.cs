using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamFinal.DataAccess.DTOs;
public class SerieTele
{
    public const int MAX_NOMSERIETELE_LENGTH = 40;
    public const int MAX_GENRE_LENGTH = 50;
    public int Id { get; set; }
    public string NomSerietele { get; set; }
    public string Genre { get; set; }
    public byte[] Version { get; set; }

    public virtual List<Acteur> Acteurs { get; set; } = new List<Acteur>();

    public SerieTele() 
    { 
    
    }

    public SerieTele(int id, string nomSerietele, string genre, byte[] version)
    {
        this.Id = id;
        this.NomSerietele = nomSerietele;
        this.Genre = genre;
        this.Version = version;
    }

    public override string ToString()
    {
        return this.Id.ToString()  + " - " + this.NomSerietele;
    }
}
