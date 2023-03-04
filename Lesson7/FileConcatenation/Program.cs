Console.WriteLine("FileConcatenation");

static async void FileConcat(string path)
{
    if (!Directory.Exists(path))
    {
        Console.WriteLine("Directory does not exist.");
        return;
    }

    if (File.Exists("result.txt"))
    {
        File.Delete("result.txt");
    }

    string[] files = Directory.GetFiles(path, "*.txt");

    await using StreamWriter sw = File.CreateText("result.txt");

    foreach (string file in files)
    {
        using StreamReader sr = File.OpenText(file);

        string? s = "";

        while ((s = await sr.ReadLineAsync()) != null)
        {
            await sw.WriteLineAsync(s);
        }
    }
}

// Concatenate all .txt files in the given directory
FileConcat("../../../Demo");