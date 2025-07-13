using GameLogParser.Models;

namespace GameLogParser.Interfaces
{
    public interface ILogParserService
    {
        List<GameLog> Parse();
    }
}
