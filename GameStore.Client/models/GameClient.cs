namespace GameStore.Client.models;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id =1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 200,
            ReleaseDate = new DateTime(1991 ,2, 1)
        },
        new Game()
        {
            Id =2,
            Name = "Final Fantasy XIV",
            Genre = "Roleplaying",
            Price = 500,
            ReleaseDate = new DateTime(2010 ,9, 30)
        },
        new Game()
        {
            Id =3,
            Name = "FIFA 23",
            Genre = "Sports",
            Price = 550,
            ReleaseDate = new DateTime(2022 ,9, 27)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }
}