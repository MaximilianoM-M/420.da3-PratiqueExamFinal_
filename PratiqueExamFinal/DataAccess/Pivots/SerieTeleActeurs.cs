using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamFinal.DataAccess.Pivots;
internal class SerieTeleActeurs
{
    public int ActeurId { get; set; }
    public int SerieTeleId { get; set; }

    public SerieTeleActeurs(int acteurId, int serieTeleId) 
    { 
       this.ActeurId = acteurId;
       this.SerieTeleId = serieTeleId;
    }
}
