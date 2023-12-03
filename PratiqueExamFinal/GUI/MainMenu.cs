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
        this.S�rieTeleListBox.Items.Clear();
        this.S�rieTeleListBox.SelectedItem = null;
        this.S�rieTeleListBox.DataSource = parentApp.GetAllSerieTele();
    }

    private void quitBtn_Click(object sender, EventArgs e)
    {
        this.parentApp.Terminate();
    }
}
