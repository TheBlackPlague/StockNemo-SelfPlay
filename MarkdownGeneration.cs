using System;
using System.IO;
using System.Text;

namespace Backend;

public static class MarkdownGeneration
{

    private const int START = 0;
    private const int LIMIT = 800;
    private const string PATH = ".\\Markdown.md";

    public static void Main()
    {
        Console.WriteLine("Generating string...");
        StringBuilder sb = new();
        int lastSection = 0;
        for (int i = START; i < LIMIT; i++) {
            if (i % 4 == 0) {
                sb.Append("| ");
                lastSection = i;
            }

            
            sb.Append("<img src=\"GIF/" + i + ".gif\" alt=\"GAME-" + i + "\" width=\"180\" height=\"210\"/>");
            sb.Append(" |");
            if (i == lastSection + 3) {
                sb.Append('\n');
            }
            if (i == 3) {
                sb.Append("|--------------------------------------------------------------|")
                    .Append("--------------------------------------------------------------|")
                    .Append("--------------------------------------------------------------|")
                    .Append("--------------------------------------------------------------|\n");
            }
        }
        Console.WriteLine("String generated.");

        File.WriteAllText(PATH, sb.ToString());
    }

}