Stock Application POC
The application displays simulated stock prices ticking (price for each stock is provided below)
Stock1 - random price between 240 and 270
Stock2 - random price between 180 and 210
Prices tick every second, and we keep track of all the price ticks along with the time that the price changed within the client (in memory).
Client subscribes with a ticker i.e. Stock, and the servie will keep publishing prices for that ticker for as long as it is subscribed.
Service module will act as a provider and publish prices based on the price logic to the client.

