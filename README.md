# PDM API

This is a Entity Framework Core API for exposing data from the Production Data Mart (PDM) DB.  
It is a new version of the OData API "[ProdCom API](https://github.com/equinor/DataLakers/tree/master/projects/PDM/ProdCom)".  

## Getting started

### Prerequisites

1. Visual Studio 2019 or similar
2. .NET Core 2.2.0 SDK or newer
3. Permissions to relevant AD groups

### Querying with postman

- Open postman and import the collection found in the Postman folder.
- Right-click the collection and click on "Edit".
- Go to "Authorization" and click on "Get New Access Token".
- Fill in the required information (example bellow).
- Request a new token and update the collection.

| Field        | Value                                                                                                       |
| ------------ | ----------------------------------------------------------------------------------------------------------- |
| Grant Type   | Implicit                                                                                                    |
| Callback URL | https://www.getpostman.com/oauth2/callback                                                                  |
| Auth URL     | https://login.microsoftonline.com/3aa4a235-b6e2-48d5-9195-7fcf05b459b0/oauth2/authorize?resource={resource} |
| Client ID    | {ID of AAD used for authentication}                                                                         |

After following these steps you can now run the collection and/or individual requests.  
**Note:** The collection does not include any filtering by default.

<!-- TODO: Update baseUrl to the production url when it is ready -->

## Updating or adding new endpoints

Models and controllers can be generated from the database by using [this sql script](https://github.com/equinor/DataLakers/blob/master/tools/scripts/sql/EntityframeworkModelsAndControllers.sql).  
**Note:** Controllers generated from this script only have `top` and `skip`, no other filters.

## Deployment 

1. Clone repo 
2. Create AAD App Registrations if not already created
   1. PDM API: This is the registration that connects to the DB. This needs the permission `Microsoft Graph - Group.Read.All`
   2. PdmApim / PDM Frontend: This is what the APIM use to authenticate. This needs the permission `PDM API - user_impersonation`
3. Populate [appsettings.json](https://github.com/equinor/DataLakers/blob/master/projects/PDM/PDM%20API/PDM%20API/appsettings.json)
   1. These values can also be added to the app service in Settings - Configuration
4. Get or create a publishing profile
5. Publish from Visual Studio

# Solution documentation

## Authentication

This application uses implicit OAuth 2.0 tokens.  
These tokens contain a user identifier that is used with MS Graph to find the users access.  
The logic for this can be found in [Providers](https://github.com/equinor/DataLakers/tree/master/projects/PDM/PDM%20API/PDM%20API/Providers)

## Endpoints

Endpoints are separated into two parts. These are:

### Models

[Models](https://github.com/equinor/DataLakers/tree/master/projects/PDM/PDM%20API/PDM%20API/Models) are used as both the internal class used when handling data, and the model mapping against the database.  
These are then registered and given primary keys in [PDMContext.cs](https://github.com/equinor/DataLakers/blob/master/projects/PDM/PDM%20API/PDM%20API/PDMContext.cs).

There are two types of models. These are "normal" and "compact".  
The only difference between the two is that where the "normal" model would have this column:
```c#
public DateTime? PROD_DAY { get; set; }
```
The "compact" model would have it like this:
```c#
public IEnumerable<DateTime?> PROD_DAY { get; set; }
```

The "compact" model is only used to generate swagger documentation with the correct return type.

### Controllers

The [controllers](https://github.com/equinor/DataLakers/tree/master/projects/PDM/PDM%20API/PDM%20API/Controllers) are where the endpoints are created.  
These hold the logic that creates the request sent to the db, as well as what parameters are accepted.

Just like models, controllers have two types.  
The "normal" controllers return data like this:
```JSON
[
    {
        "column1": value,
        "column2": value,
        "column3": value,
        "column4": value,
    },
    {
        "column1": value,
        "column2": value,
        "column3": value,
        "column4": value,
    },
    ...
]
```

While the "compact" controller returns data like this:
```JSON
{
    "column1": [value, value, ...],
    "column2": [value, value, ...],
    "column3": [value, value, ...],
    "column4": [value, value, ...]
}
``` 

## Swagger

This solution uses swagger as a UI for exploring the API.
This is configured in [Startup.cs](https://github.com/equinor/DataLakers/blob/master/projects/PDM/PDM%20API/PDM%20API/Startup.cs).

## Authors

Ådne E. Moldesæter (Omega) - adnm@equinor.com