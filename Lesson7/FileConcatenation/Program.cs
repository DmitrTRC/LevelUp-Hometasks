Console.WriteLine("FileConcatenation");

static async Task FileConcat(string path) {


    if (!Directory.Exists(path))
    {
        Console.WriteLine("Directory does not exist.");
        return;
    }

    var outPath = path + "/Result.bak";

    if (File.Exists(outPath))
    {
        File.Delete(outPath);
    }

    string[] files = Directory.GetFiles(path, "*.txt").OrderBy(f => f).ToArray();

    await using StreamWriter sw = File.CreateText(outPath);

    foreach (string file in files)
    {
        Console.WriteLine($"Writing {file} to {path}/OUT/result.txt");
        using StreamReader sr = File.OpenText(file);

        string? s = "";

        while ((s = await sr.ReadLineAsync()) != null)
        {
            await sw.WriteLineAsync(s);
        }
    }

    Console.WriteLine("Done.");


}

// Concatenate all .txt files in the given directory
FileConcat("../../../Demo");