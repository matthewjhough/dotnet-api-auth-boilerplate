# App Config

Configure an appsettings.json file with your info, ex: 

```javascript
{
  "Logging": {
    "IncludeScopes": false,
    "Debug": {
      "LogLevel": {
        "Default": "Warning"
      }
    },
    "Console": {
      "LogLevel": {
        "Default": "Warning"
      }
    }
  },
  "Auth0": {
    "Authority": "<YOUR_AUTHORITY_URL>",
    "Audience": "<YOUR_AUDIENCE_URL>"
  },
  "AllowedHosts": "*"
}

```