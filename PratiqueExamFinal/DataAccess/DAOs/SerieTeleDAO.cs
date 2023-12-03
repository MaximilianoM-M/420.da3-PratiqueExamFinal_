using Microsoft.EntityFrameworkCore;
using PratiqueExamFinal.DataAccess.Contexts;
using PratiqueExamFinal.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamFinal.DataAccess.DAOs;
internal class SerieTeleDAO
{
    private AppDbContexts Contexts { get; set; }

    public SerieTeleDAO(AppDbContexts contexts)
    {
        this.Contexts = contexts;
    }

    public List<SerieTele> GetAll()
    {
        return this.Contexts.SerieTeles
            .Include(serietele => serietele.Acteurs)
            .ToList();
    }

    public SerieTele? GetById(int id)
    {
        return this.Contexts?.SerieTeles.FirstOrDefault(x => x.Id == id);
    }

    public SerieTele Create(SerieTele serietele)
    {
        this.Contexts.SerieTeles.Add(serietele);
        this.Contexts.SaveChanges();
        return serietele;   
    }

    public SerieTele Update(SerieTele serietele)
    {
        this.Contexts.SerieTeles.Update(serietele);
        this.Contexts.SaveChanges();
        return serietele;
    }

    public SerieTele Delete(SerieTele serietele)
    {
        this.Contexts.SerieTeles.Remove(serietele);
        this.Contexts.SaveChanges();
        return serietele;
    }

}
