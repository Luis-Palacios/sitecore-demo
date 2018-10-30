# Sitecore demo

Example source code to implement an existing bootstrap template in a Sitecore instance. The content that exists on the template
is modeled in templates so that author users are able to add it and modify it.

This illustrates the basics of the core concepts of Sitecore such as:

1. Templates
2. Placeholders
3. Renderings
4. Unicorn
5. Pages and navigation
6. Models and complex field types

You can follow along step by step here: [Get-development-started-with-Sitecore](https://medium.com/@Luis_Palacios/get-development-started-with-sitecore-part-1-set-up-40fff89ea0a)

## Pre-requisites

1. Valid Sitecore license
2. Sitecore Repositories or access to download sitecore versions

## Required tools

1. Windows 10
2. [IIS](https://www.betterhostreview.com/turn-on-iis-windows-10.html)
3. [URL Rewrite 2](https://www.iis.net/downloads/microsoft/url-rewrite)
4. [SQL Server](https://go.microsoft.com/fwlink/?linkid=853017 )
5. [MongoDB](https://www.mongodb.com/download-center?jmp=nav#community) [(Installation instructions)](https://docs.mongodb.com/manual/tutorial/install-mongodb-on-windows/#install-mdb-edition)
6. [SIM](http://dl.sitecore.net/updater/sim/) **Note:** This project is setup to work with version 8.2 170728 Update - 5
7. [Node js](https://nodejs.org/en/)
8. Bootstrap template

## Project setup

1. Make sure that your MongoDb server is up and running
2. Use SIM to create a new Sitecore Instance
3. Configure your publish profile. Create a copy of the file: `FolderProfile.pubxml.example` located on `/SitecoreDemo.Web/Properties/PublishProfiles/` on that same directory but remove `.example` from your copy.
4. Open your newly created `FolderProfile.pubxml.example` file and update the `<publishUrl>` node according to the directory where you have your Sitecore instance
5. Configure your source folder: Create a copy of the file: `z.LocalDevelopment.config.example` located on `\SitecoreDemo.Web\App_Config\Include\zzz\` on that same directoy but remove the `.example` from your copy
6. Open your new created `z.LocalDevelopment.config` file and update the sourceFolder value to the location where you want to put your searialized items
7. Open visual studio as Administrator and open the solution
8. Add Sitecore feed to your nuget feed https://sitecore.myget.org/F/sc-packages/api/v3/index.json
9. Build the solution and publish
10. Navigate to the Sitecore instance and see if it is still working if you get Access to the path is denied grant permissions to the newtwork service to the you source folder.
11. You should still see the vanilla sitecore running, log in in /sitecore as admin user and navigate to /unicorn.aspx and run the sync
12. You should now see the updated Sitecore Site

## TODO

- [ ] Create local development configurations for unicorn
- [ ] Complete steps to have the code working with a Sitecore blank instance
