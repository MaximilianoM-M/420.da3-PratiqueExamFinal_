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

    private readonly PratiqueExamFinalApp parentApp;
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
        foreach (Acteur acteur in serieTele.Acteurs)
        {
            this.serietelevisionActeurListBox.SelectedItems.Add(acteur);
        }



    }




    private void UpdateInstanceWithData()
    {
        if (this.serieteleTextBox.Text.Length > SerieTele.MAX_NOMSERIETELE_LENGTH)
        {
            throw new Exception($"Nom de Série Télévision trop long,{this.serieteleTextBox.Text.Length} caractères entrés, maximum de {SerieTele.MAX_NOMSERIETELE_LENGTH} ");
        }
        if (this.genreTextBox.Text.Length > SerieTele.MAX_GENRE_LENGTH)
        {
            throw new Exception($"Le genre de la série Télévision est trop long,{this.genreTextBox.Text.Length} caractères entrés, maximum de {SerieTele.MAX_GENRE_LENGTH} ");
        }
        this.currentSerieTele.NomSerietele = this.serieteleTextBox.Text;
        this.currentSerieTele.Genre = this.genreTextBox.Text;
        List<Acteur> selectedActeurs = new List<Acteur>();
        foreach (object? selectedActeur in this.serietelevisionActeurListBox.SelectedItems)
        {
            selectedActeurs.Add((Acteur)selectedActeur);
        }
        this.currentSerieTele.Acteurs = selectedActeurs;

    }



   

    private void actionButton_Click_1(object sender, EventArgs e)
    {
        try
        {
            switch (this.currentIntent)
            {
                case ViewIntentEnum.CREATE:
                case ViewIntentEnum.EDIT:
                    this.UpdateInstanceWithData();
                    break;
                case ViewIntentEnum.VIEW:
                case ViewIntentEnum.DELETE:
                default:
                    // rien a faire 
                    break;
            }
            this.DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show(ex.Message);
        }

    }

    private void cancelButton_Click_1(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }
}




