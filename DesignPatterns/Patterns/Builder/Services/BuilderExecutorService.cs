using DesignPatterns.Patterns.Builder.Builders;
using DesignPatterns.Patterns.Builder.Directors;
using DesignPatterns.Patterns.Builder.Services;
using DesignPatterns.Shared.Helpers;

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
        SharedPrintHelpers.InvalidOption();
        return null;
    }
}