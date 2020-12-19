## Vendor Page -- Basic C# Webpage

### _Create vendor profiles on page and allow vendors to place orders_

### _Created by: Eric Stratton_

## Description

Use this webpage to create multiple vendor profiles and place orders distinct to each one

## Setup/Instillation

### Requirements:

- Internet browser
- Code editor if you wish to view/edit the code (recommended)
- .NET Core SDK

### .NET Core:

- Application is built using the deprecated .NET Core vs 2.2.
- .NET Core is a requirement for running this application, if you need to install it visit <https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer>
- Or if you wish to downloaded the latest editions of .Net Core, select `.NET core` in the file path at the top of the dowloaded page provided in the link above

### Download: 

- Download this repository by clicking the green 'Code' icon and selecting download zip
- Use your favorite zip.file opener to extract files to your local device

### Terminal:

- Open command terminal on local device
- Navigate to desktop in terminal using `$ cd desktop`
- Copy repository link by clicking on green 'Code' icon and clicking the clipboard to the right of the url
- Use command `$ git clone {specific_repository_URL}`
- From desktop, run command `$ cd {newly-downloaded-directory}` to navigate to the installed directory
- Run command `$ code .` to open directory in default code editor
- Run command `dotnet restore <mainDirectory>` in the console to upload necessary .NET Core files
- You'll have to do the same for the `<testDirectory>` if you want to run the tests
- Run command `$ cd VendorPage` to navigate into the main directory to run console app
- Run command `$ donet run` 
- If everything has gone correctly, the web application should run in the web browser at `localhost:5000`

### Navigating in Application:

- App opens on landing page at `localhost:5000/`
- Click on one of the hyperlinks to navigate to a different section of app

### RESTful Protocol:

- **_Page routes are named using RESTful notation as reflected in the pathway urls_**
- `localhost:5000/`: landing page
- `localhost:5000/vendors`: homepage for vendor profiles, displays all existing vendor profiles
- `localhost:5000/vendoes/new`: page for creating a new vendor profile
- `localhost:5000/vendors/{vendorId}`: page for select vendor profile, displays vendor description and existing orders for vendor
- `localhost:5000/vendors/{vendorId}/orders/new`: page for select vendor to place new order
- `localhost:5000/vendors/{vendorId}/orders/{orderId}`: page for specific order details

## Tests

Test | Input | Output |
| :------------| :---------------| :-----------|
| Order |
| Create instance of Order | Order newOrder = new Order(); | newOrder |
| Add order description to Order instance | "For next Tuesday" | newOrder.Description = "For next Tuesday"; |
| Find instance of Order by Id | newOrder.Id | 1 |
| Vendor |
| Create instance of Vendor | Vendor newVendor = new VendorOrder(); | newVendor |
| Add Vendor description | "Bread orders only" | newVendor.Description = "Bread orders only"; |
| Find instance of Vendor by Id | newVendor.Id | 1 |

### To run your own tests: 

- Navigate to the `VendorPage.Tests` directory
- Run command `$ dotnet restore`
- Run command `$ dotnet test` to run test suite

## Known Bugs

There are no known bugs at this time.

## Support & Contact Details

Do not hesitate to contact me at:

<strattonericj@gmail.com>

## Technologies 

- _VisualStudio Code_
- _C#_
- _.NET Core 2.2_
- _Git_
- _GitHub_

## Licensing

Copyright (c) 2020 **_Eric Stratton_**

This software is licensed under the MIT license