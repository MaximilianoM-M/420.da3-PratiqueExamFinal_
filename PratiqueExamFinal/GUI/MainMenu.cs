using PratiqueExamFinal.Business;
using PratiqueExamFinal.DataAccess.DTOs;

namespace PratiqueExamFinal.GUI;

internal partial class MainMenu : Form
{
    private readonly PratiqueExamFinalApp parentApp;
    private SerieTele? selectedSerieTele;
    public MainMenu(PratiqueExamFinalApp parentApp)
    {
        this.parentApp = parentApp;
        this.InitializeComponent();
        this.RealoadSerieTeleListBox();

    }

    public void RealoadSerieTeleListBox()
    {
        this.SérieTeleListBox.SelectedItem = null;
        this.SérieTeleListBox.DataSource = parentApp.GetAllSerieTele();
    }

    private void quitBtn_Click(object sender, EventArgs e)
    {
        this.parentApp.Terminate();
    }

    private void ActivateSerieTeleSelectedButtons()
    {
        this.serieteleViewBtn.Enabled = true;
        this.editSerieTeleBtn.Enabled = true;
        this.deleteSerieTeleBtn.Enabled = true; 
    }

    private void DeativateSerieTeleSelectedButtons()
    {
        this.serieteleViewBtn.Enabled = false;
        this.editSerieTeleBtn.Enabled = false;
        this.deleteSerieTeleBtn.Enabled = false;
    }

    private void createSerieTeleBtn_Click(object sender, EventArgs e)
    {
        SerieTele? newSerieTele = this.parentApp.CreateNewSerieTele();
        this.RealoadSerieTeleListBox();
    }

    private void serieteleViewBtn_Click(object sender, EventArgs e)
    {
        if (this.selectedSerieTele is not null) 
        {
            _ = this.parentApp.ViewSerieTele(this.selectedSerieTele);
        }
        
    }

    private void editSerieTeleBtn_Click(object sender, EventArgs e)
    {
        if (this.selectedSerieTele is not null)
        {
            _ = this.parentApp.EditSerieTele(this.selectedSerieTele);
            this.RealoadSerieTeleListBox();
        }
    }

    private void deleteSerieTeleBtn_Click(object sender, EventArgs e)
    {
        if (this.selectedSerieTele is not null)
        {
            SerieTele? deletedSerieTele = this.parentApp.DeleteSerieTele(this.selectedSerieTele);
            if (deletedSerieTele is not null) 
            {
                this.RealoadSerieTeleListBox();
                this.selectedSerieTele = null;
                this.DeativateSerieTeleSelectedButtons();
            }
        }

    }

    private void SérieTeleListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.selectedSerieTele = this.SérieTeleListBox.SelectedItem as SerieTele;
        this.ActivateSerieTeleSelectedButtons();
    }
}
