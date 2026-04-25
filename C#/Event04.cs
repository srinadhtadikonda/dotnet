Define Custom EventArgs: We start by defining a custom EventArgs class StockPriceChangedEventArgs to encapsulate information about the stock price change.

using System;

// Custom EventArgs class for passing stock price change information

public class StockPriceChangedEventArgs : EventArgs
{
    public string StockSymbol { get; }
    public decimal NewPrice { get; }

    public StockPriceChangedEventArgs(string stockSymbol, decimal newPrice)
    {
        StockSymbol = stockSymbol;
        NewPrice = newPrice;
    }
}



Publisher Class — Stock: The Stock class represents a stock with properties for Symbol and Price. It defines a delegate StockPriceChangedHandler and an event StockPriceChanged for notifying price changes.

public class Stock
{
    // Delegate for stock price change event handler
    public delegate void StockPriceChangedHandler(object sender, StockPriceChangedEventArgs e);

    // Event for notifying stock price changes
    public event StockPriceChangedHandler StockPriceChanged;

    private decimal price;
    public string Symbol { get; }

    public Stock(string symbol, decimal initialPrice)
    {
        Symbol = symbol;
        price = initialPrice;
    }

    // Property for updating the stock price and raising the event
    public decimal Price
    {
        get { return price; }
        set
        {
            if (price != value)
            {
                price = value;
                OnStockPriceChanged(new StockPriceChangedEventArgs(Symbol, value));
            }
        }
    }

    // Method for raising the stock price change event
    protected virtual void OnStockPriceChanged(StockPriceChangedEventArgs e)
    {
        StockPriceChanged?.Invoke(this, e);
    }
}







Subscriber — Investors: In our example, two investors (Investor1 and Investor2) are subscribers to the StockPriceChanged event. They each have event handler methods (Investor1_StockPriceChanged and Investor2_StockPriceChanged) that are invoked when the stock price changes.

public class Program
{
    static void Main(string[] args)
    {
        // Create a new stock instance
        Stock appleStock = new Stock("AAPL", 150.00m);

        // Subscribe multiple investors to the stock price change event
        appleStock.StockPriceChanged += Investor1_StockPriceChanged;
        appleStock.StockPriceChanged += Investor2_StockPriceChanged;

        // Simulate stock price changes
        appleStock.Price = 155.00m;
        appleStock.Price = 160.00m;
    }

    // Event handler method for Investor 1
    private static void Investor1_StockPriceChanged(object sender, StockPriceChangedEventArgs e)
    {
        Console.WriteLine($"Investor 1: The price of {e.StockSymbol} changed to {e.NewPrice:C}");
    }

    // Event handler method for Investor 2
    private static void Investor2_StockPriceChanged(object sender, StockPriceChangedEventArgs e)
    {
        Console.WriteLine($"Investor 2: The price of {e.StockSymbol} changed to {e.NewPrice:C}");
    }
}
Explanation:
•	StockPriceChangedEventArgs Class: Custom EventArgs class to pass stock symbol and new price information when the event is raised.
•	Stock Class: Represents a stock with properties for Symbol and Price. It defines a delegate StockPriceChangedHandler and an event StockPriceChanged for notifying subscribers about price changes. The OnStockPriceChanged method raises the event.
Program Class (Main):
•	Creates an instance of Stock (e.g., Apple stock with an initial price).
•	Subscribes two investors (Investor1 and Investor2) to the StockPriceChanged event using event handlers (Investor1_StockPriceChanged and Investor2_StockPriceChanged).
•	Simulates changes in stock price by updating the Price property of Stock, which triggers the StockPriceChanged event.
•	Event Handlers (Investor1_StockPriceChanged and Investor2_StockPriceChanged):
•	Print messages to the console when the event is raised, indicating the stock symbol and the new price.
Output:
When you run this console application, it will output messages indicating how the stock price changes are notified to each investor subscribed to the event. Here’s a sample output:
Investor 1: The price of AAPL changed to $155.00
Investor 2: The price of AAPL changed to $155.00
Investor 1: The price of AAPL changed to $160.00
Investor 2: The price of AAPL changed to $160.00
