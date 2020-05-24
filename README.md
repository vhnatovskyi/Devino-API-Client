[Devino API Client](https://docs.devino.online/ru/)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://gitlab.com/V.Gnatovskyi/devino.api/-/tree/master)

### Get authorize token

```sh
var authToken = "Basic " + Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{login}:{password}");
```

### Use SMS Client

```sh
IClient client = new SmsClient(authToken);
var message = new SmsMessage();
var response = client.SendMessage(message);
```

### Use Viber Client

```sh
IClient client = new ViberClient(authToken);
var message = new ViberMessage();
var response = client.SendMessage(message);
```
