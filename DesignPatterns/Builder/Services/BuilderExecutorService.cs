using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Directors;
using DesignPatterns.Builder.Helpers;
using DesignPatterns.Builder.Services;

internal static class BuilderExecutorService
{
    public static HouseConstructionService? Execute(int option)
    {
        Director? director = option switch
        {
            1 => new Director(new BrickHouseBuilder()),
            2 => new Director(new StoneHouseBuilder()),
            3 => new Director(new WoodHouseBuilder()),
            9 => null,
            _ => ReturnNullWithMessage()
        };

        return director != null ? new HouseConstructionService(director) : null;
    }

    private static Director? ReturnNullWithMessage()
    {
        PrintsHelper.InvalidOption();
        return null;
    }
}
