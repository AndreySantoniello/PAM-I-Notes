namespace Notes;

public partial class NotesPage : ContentPage
{
    
    public String path = Path.Combine(FileSystem.AppDataDirectory, "dotado.txt");

    public NotesPage()
	{
		InitializeComponent();

        if (File.Exists(path))
        {
		    FileEditor.Text = File.ReadAllText(path);
        }
	}
	private void SaveBtn_Clicked(object sender, EventArgs e)
	{

        String saveTextAreaValue = FileEditor.Text;

        File.WriteAllText(path, saveTextAreaValue);
	
	}
    private void DeleteBtn_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(path, "");
        FileEditor.Text = "";
        File.Delete(path);
    }
}