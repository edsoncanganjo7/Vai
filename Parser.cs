namespace Vai;

public class Parser : IParser
{
    public int ParseToInt(string value){
        if(string.IsNullOrWhiteSpace(value)) return 0;

        int number = 0;
        foreach (char num in value.ToCharArray())
        {
            number =+ (int)((uint)num * 10);
        }

        return number;
    }
}

public interface IParser {}