using PratiqueExamFinal.DataAccess.Contexts;
using PratiqueExamFinal.DataAccess.DAOs;
using PratiqueExamFinal.DataAccess.DTOs;
using PratiqueExamFinal.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamFinal.Business;
internal class PratiqueExamFinalApp
{
    private AppDbContexts context;
    private MainMenu mainMenu;
    private SerieTeleDAO serieteleDAO;
    private ActeurDAO acteurDAO;
    public PratiqueExamFinalApp()
    {
        ApplicationConfiguration.Initialize();
        this.context = new AppDbContexts();
        this.serieteleDAO = new SerieTeleDAO(this.context);
        this.acteurDAO = new ActeurDAO(this.context);
        this.mainMenu = new MainMenu(this);
    }

    public void Start()
    {
        Application.Run(this.mainMenu);
    }

    public void Terminate()
    {
        Application.Exit();
    }

    public List<SerieTele> GetAllSerieTele()
    {
        return this.serieteleDAO.GetAll();
    }

    public List<Acteur> GetAllActeurs()
    {
        return this.acteurDAO.GetAll();
    }

}
