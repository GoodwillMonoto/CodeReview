//Updates
//
//Gave the function a descriptive name, now it clearly conveys what the function is intended for. Was is supposed to sort number or do and alphabetical sort?
//Added validation and provided helpful error messages.
//Made use fo the string builder to working with possibly large lists
//Made it an utility class made the function an extension method, improved ease of use and promotion of separation of concerns.



	
public static class RiskEngineUtilities
{
    public static string ParseReverseSpaceDelimitedString(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var listBuilber = new StringBuilder();

        for (int i = words.Length - 1; i >= 0; i--)
        {
            listBuilber.Append(words[i]);
            if (i > 0)
                listBuilber.Append(",");
        }

        return listBuilber.ToString();
    }
}