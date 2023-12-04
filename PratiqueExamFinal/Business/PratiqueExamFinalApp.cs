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
    private readonly AppDbContexts context;
    private readonly MainMenu mainMenu;
    private readonly SerieTeleDAO serieteleDAO;
    private readonly ActeurDAO acteurDAO;
    private readonly SerieTeleManagementForm serieteleForm;
    public PratiqueExamFinalApp()
    {
        ApplicationConfiguration.Initialize();
        this.context = new AppDbContexts();
        this.serieteleDAO = new SerieTeleDAO(this.context);
        this.acteurDAO = new ActeurDAO(this.context);
        this.mainMenu = new MainMenu(this);
        this.serieteleForm = new SerieTeleManagementForm(this);


    }

    public void Start()
    {
        Application.Run(this.mainMenu);
    }

    public void Terminate()
    {
        Application.Exit();
    }

    public SerieTele? CreateNewSerieTele()
    {
        SerieTele newserietele = new SerieTele();
        DialogResult resultat = this.serieteleForm.OpenForCreate(newserietele);
        if ( resultat == DialogResult.OK ) 
        {
            _ = this.serieteleDAO.Create(newserietele);
           return newserietele;
        }
        else
        {
            return null; 
        }
    }

    public SerieTele? EditSerieTele(SerieTele serietele)
    {
        
        DialogResult resultat = this.serieteleForm.OpenForEdit(serietele);
        if (resultat == DialogResult.OK)
        {
            _ = this.serieteleDAO.Update(serietele);
            
        }
        return serietele;

    }

    public SerieTele? ViewSerieTele(SerieTele serietele)
    {

        _ = this.serieteleForm.OpenForView(serietele);
       return serietele;

    }

    public SerieTele? DeleteSerieTele(SerieTele serietele)
    {

        DialogResult resultat = this.serieteleForm.OpenForDelete(serietele);
        if (resultat == DialogResult.OK)
        {
            _ = this.serieteleDAO.Delete(serietele);

        }
        else
        {
            return null;
        }
        return serietele;

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
