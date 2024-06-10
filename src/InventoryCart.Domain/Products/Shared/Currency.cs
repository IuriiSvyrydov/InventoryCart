namespace InventoryCart.Domain.Products.Shared;

public record Currency
{

    public string Code { get; init; }

    private Currency(string code) => Code = code;

    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        USD,
        EUR,
        UAH
    };

    public static readonly Currency None = new("");
    public static readonly Currency USD = new("USD");
    public static readonly Currency EUR = new("EUR");
    public static readonly Currency UAH = new("UAH");

    public static Money Zero() => new Money(0, None);

    public static Currency FromZero(string code) => All.FirstOrDefault(x => x.Code == code) ??
                                                    throw new ApplicationException("The currency code is invalid");
};