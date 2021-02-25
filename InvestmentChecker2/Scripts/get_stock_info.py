from classes.Stock import Stock
import sys

ticker = sys.argv[1]
stock = Stock(ticker)
print(stock.found)
print(stock.get_stock_info())