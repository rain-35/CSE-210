
using System.Runtime.CompilerServices;
public class SaveLoad
{
    private string InitializeAndGetSaveFolder([CallerFilePath] string sourceFilePath = "")
    {
        
        string sourceDirectory = Path.GetDirectoryName(sourceFilePath);

        string saveDirectoryPath = Path.Combine(sourceDirectory, "Saves");

        if (!Directory.Exists(saveDirectoryPath))
        {
            Directory.CreateDirectory(saveDirectoryPath);
            Console.WriteLine($">>> Created dedicated save directory at: {saveDirectoryPath}");
        }

        return saveDirectoryPath;
    }

    public string InitializeProjectFolder()
    {
        string baseSaveFolder = InitializeAndGetSaveFolder();

        Console.Write("Enter the name of your project: ");
        string projectName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(projectName))
        {
            projectName = "UntitledProject";
        }

        string projectFolderPath = Path.Combine(baseSaveFolder, projectName);

        if (!Directory.Exists(projectFolderPath))
        {
            Directory.CreateDirectory(projectFolderPath);
            Console.WriteLine($">>> Created dedicated project folder at: {projectFolderPath}");
        }

        return projectFolderPath;
    }

}