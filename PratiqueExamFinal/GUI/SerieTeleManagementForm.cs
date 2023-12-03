using PratiqueExamFinal.Business;
using PratiqueExamFinal.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PratiqueExamFinal.GUI;
internal partial class SerieTeleManagementForm : Form
{
    private enum ViewIntentEnum
    {
        VIEW,
        CREATE,
        EDIT,
        DELETE

    }

    private PratiqueExamFinalApp parentApp;
    private ViewIntentEnum currentIntent;
    private SerieTele currentSerieTele = null!;
    public SerieTeleManagementForm(PratiqueExamFinalApp parentApp)
    {
        this.parentApp = parentApp;
        InitializeComponent();
        this.ReloadActeursListBox();
        
    }

    public void ReloadActeursListBox()
    {
        this.serietelevisionActeurListBox.Items.Clear();
        this.serietelevisionActeurListBox.DataSource = parentApp.GetAllActeurs();
    }

    public DialogResult OpenForView(SerieTele serieTele)
    {
        this.currentIntent = ViewIntentEnum.VIEW;
        this.actionButton.Text = "Close";
        this.currentSerieTele = serieTele;
        this.DeactivateControls();
        this.LoadSerieTeleDataInControls(serieTele);
        return this.ShowDialog();

    }

    public DialogResult OpenForCreate(SerieTele serieTele)
    {
        this.currentIntent = ViewIntentEnum.CREATE;
        this.actionButton.Text = "Créer";
        this.currentSerieTele = serieTele;
        this.ActivateControls();
        this.LoadSerieTeleDataInControls(serieTele);
        return this.ShowDialog();
    }

    public DialogResult OpenForEdit(SerieTele serieTele)
    {
        this.currentIntent = ViewIntentEnum.EDIT;
        this.actionButton.Text = "Sauvegarder";
        this.currentSerieTele = serieTele;
        this.ActivateControls();
        this.LoadSerieTeleDataInControls(serieTele);
        return this.ShowDialog();
    }

    public DialogResult OpenForDelete(SerieTele serieTele)
    {
        this.currentIntent = ViewIntentEnum.DELETE;
        this.actionButton.Text = "Supprimer";
        this.currentSerieTele = serieTele;
        this.DeactivateControls();
        this.LoadSerieTeleDataInControls(serieTele);
        return this.ShowDialog();
    }

    private void ActivateControls()
    {
        this.idField.Enabled = false;
        this.serieteleTextBox.Enabled = true;
        this.genreTextBox.Enabled = true;
        this.serietelevisionActeurListBox.Enabled = true;
    }

    private void DeactivateControls()
    {
        this.idField.Enabled = false;
        this.serieteleTextBox.Enabled = false;
        this.genreTextBox.Enabled = false;
        this.serietelevisionActeurListBox.Enabled = false;
    }

    private void LoadSerieTeleDataInControls(SerieTele serieTele)
    {
        this.idField.Value = serieTele.Id;
        this.serieteleTextBox.Text = serieTele.NomSerietele;
        this.genreTextBox.Text = serieTele.Genre;
        this.serietelevisionActeurListBox.SelectedItems.Clear();
        foreach ( Acteur acteur in serieTele.Acteurs)
        {
            this.serietelevisionActeurListBox.SelectedItems.Add(acteur);
        }
       


    }

    

    private void actionButton_Click(object sender, EventArgs e)
    {
        switch (this.currentIntent)
        {

        }
    }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    
}
   
