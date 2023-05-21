using System;

namespace ManagedDoom; 

public static class LevelRandomizer {
    private static readonly Random Random = new ((int)DateTime.Now.ToFileTime());

    private static int Next(int startInclusive, int endInclusive) => Random.Next(startInclusive, endInclusive + 1);
    
    public static int GetMap(GameMode gameMode) => gameMode switch {
        GameMode.Commercial => Next(1, 32),
        _ => Next(1, 9)
    };

    public static int GetEpisode(GameMode gameMode) => gameMode switch {
        GameMode.Registered => Next(1, 3),
        GameMode.Retail => Next(1, 4),
        _ => 1
    };
}
