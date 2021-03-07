from classes.Stock import Stock
import sys

tickers = iter(sys.argv)
next(tickers, None)

output = []

for ticker in tickers:
    stock = Stock(ticker)
    output.append(str(stock.get_stock_price()))

print(" ".join(output))