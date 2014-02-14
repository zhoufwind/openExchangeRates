openExchangeRates
=================

Easy steps on how to get JSON formatted data from a web service, deserialize it, and map it to custom local class for further usage

*************

Source Article:
http://www.codeproject.com/Tips/397574/Use-Csharp-to-get-JSON-Data-from-the-Web-and-Map-i

*************

openexchangerates.org
The Quick Start Guide
Welcome to the Open Exchange Rates API, Stephen!
This is the 60-second Quick Start guide, which will get you up and running in the shortest time possible.

Step 1: Your App ID
This is your app_id, which you will use to query the API:
3ffce3987c764a84bdb8fad0aa0bd7c2 

Step 2: API Endpoints
Data is available at these 'endpoints' (addresses). To use them, simply attach your app_id on to the URL as a query parameter, eg:
/api/latest.json?app_id=3ffce3987c764a84bdb8fad0aa0bd7c2 
The base URL is http://openexchangerates.org/api/.
Paid plan clients can connect securely via https://.
Unlimited plan customers accessing the latest data at latest.json will automatically receive 10 minute-updated rates.
latest.json
get the most recent exchange rates 
historical/YYYY-MM-DD.json
get rates for any given day, where available 
currencies.json
get list of currency codes and names 
time-series.json
get time-series (multiple day) data. more info » 
(Enterprise/Unlimited clients only) 

MyApp URL: https://openexchangerates.org/api/latest.json?app_id=3ffce3987c764a84bdb8fad0aa0bd7c2
