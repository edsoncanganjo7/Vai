namespace Vai.Parse;

public class Parser : IParser
{
    public static int ParseToInt(ReadOnlySpan<char> s){
        if(s.IsEmpty) return 0;

        if(!int.TryParse(s.ToString(), out int result)) return 0;

        return result;
    }
}

public interface IParser {}