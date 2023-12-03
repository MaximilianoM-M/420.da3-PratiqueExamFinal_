using PratiqueExamFinal.DataAccess.Contexts;
using PratiqueExamFinal.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamFinal.DataAccess.DAOs;
internal class ActeurDAO
{
    private AppDbContexts Contexts {  get; set; }

    public ActeurDAO(AppDbContexts contexts)
    {
        this.Contexts = contexts;
    }

    public List<Acteur> GetAll()
    {
        return this.Contexts.Acteurs.ToList();
    }
}
