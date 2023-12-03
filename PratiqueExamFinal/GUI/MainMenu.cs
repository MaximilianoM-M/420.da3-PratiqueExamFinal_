using PratiqueExamFinal.Business;

namespace PratiqueExamFinal.GUI;

internal partial class MainMenu : Form
{
    private PratiqueExamFinalApp parentApp;
    public MainMenu(PratiqueExamFinalApp parentApp)
    {
        this.parentApp = parentApp;
        this.InitializeComponent();
        this.RealoadSerieTeleListBox();

    }

    public void RealoadSerieTeleListBox()
    {
        this.SérieTeleListBox.Items.Clear();
        this.SérieTeleListBox.SelectedItem = null;
        this.SérieTeleListBox.DataSource = parentApp.GetAllSerieTele();
    }

    private void quitBtn_Click(object sender, EventArgs e)
    {
        this.parentApp.Terminate();
    }
}
