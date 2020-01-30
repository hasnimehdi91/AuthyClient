# AuthyNetCore

AuthyNetCore is a  client for the Authy API.

Forked from https://github.com/devinmartin/authy.net

## License

This is released under an MIT license. See the file LICENSE.txt for more information.

## Documentation
The API is really simple and corresponds to the [Authy Documentation]

Create an instance of the client. You must provide your API key and indicate if this is to run in test mode or not.

```
var client = new AuthyClient("my key", test:false);
```

All of the methods return a result object specific to the call. There is always a Status property and a RawResponse property. The raw response can be used to get additional information when debugging problems but generally isn't needed in actual code.


### The statuses are:
1. Success
2. BadRequest
3. Unauthorized
    * This can mean that your API key is invalid or that the provided token is invalid. Once your integration has been
      tested it likely means that the token is invalid but the raw response will provide more info.
4. ServiceUnavailable



