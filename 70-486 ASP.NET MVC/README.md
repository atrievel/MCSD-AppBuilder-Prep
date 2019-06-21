# Exam 70-486 Developing ASP.NET MVC Web Applications Outline

## Design the build and deployment architecture (10-15%)

### Design a browser artifact build strategy

* Design a JavaScript build pipeline using 
    * Gulp
    * Grunt
    * npm
    * Bower 
* Design an artifact build strategy using 
    * Less
    * Sass 
    * Font Awesome
* Design and implement a bundling and minification strategy for browser artifacts, including JavaScript, CSS and images

### Design a server build strategy

* Manage NuGet dependencies
* Target runtimes
    * Full .NET Framework
    * .NET core
    * .NET standard
* Manage debug and release configurations, including compilation and optimization options
* Include or exclude files from build
* Manage build sources including content, resources, and shared files
* Implement metadata for projects, including version, release notes, and description
* Define other build options, including xmlDoc and warningsAsErrors
* Work with static files in ASP.NET core


### Design a publishing strategy

* Implement application publishing using dotnet.exe
* Mnage publishing options in csproj
* Implement additional tooling
* Implement pre-publish and post-publish scripts
* Implement native compilation
* Publish to Docker container image






### Implement an Azure deployment strategy

* Deploy Azure Web App using supported deployment models including 
    * FTP
    * Kudu 
    * Web Deploy
    * Visual Studio Publishing Wizard
* Provision ARM-based resources while deploying applications
* Implement deployment environments, including dev, test, and prod in Azure
* Use deployment slots for staging sites
* Deploy to Azure Stack

### Implement a on-premises deployment strategy

* Deploy application to IIS using 
    * Web Deploy
    * xcopy
    * Visual Studio Publishing Wizard
* Deploy application to Windows Nano Server,
* Deploy application to IIS Hosted Web Core
* Deploy application to HTTP.sys web server
* Deploy application to Kestrel on Windows and Linux
* Implement reverse proxying to Kestrel using IIS and Nginx

## Design the User Experience (15-20%)

### Create elements of the user interface for a web application

* Create and apply styles by using CSS
* Structure and lay out the user interface by using HTML
* Implement dynamic page content based on a design

### Design and implement UI behavior

* Implement client-side validation
* Use JavaScript to manipulate the DOM
* Extend objects by using prototypal inheritance
* Use AJAX to make partial page updates

### Design the UI layout of an application

* Implement partial views and view components for reuse in different areas of the application
* Design and implement pages by using Razor Pages
* Design and implement layouts to provide visual structure
* Define and render optional and required page sections
* Create and use tag and HTML helpers to simplify markup

### Plan a responsive UI layout

* Plan for applications that run on multiple devices and screen resolutions
* Use media queries and Bootstrap’s responsive grid
* Detect browser features and capabilities
* Create a web application that runs across multiple browsers and mobile devices
* Enable consistent cross-browser experiences with polyfills

### Plan mobile UI strategy

* Implement mobile specific UI elements such as touch input, low bandwidth situations, and device oritentation changes
* Define and implement a strategy for working with mobile browsers

## Develop the User Experience (15-20%)

### Plan for search engine optimization and accessibility

* Use analytical tools to parse HTML
* Provide an xml sitemap and robots.txt file to improve scraping
* Write semantic markup for accessibility, for example, screen readers; u
* Use rich snippets to increase content visibility

### Plan and implement globalization and localization

* Plan a localization strategy
* Create and apply resources to UI including JavaScript resources
* Set cultures
* Implement server side localization and globalization

### Design and implement MVC controllers and actions

* Apply authorization attributes, filters including global, authentication, and overriddable filters
* Choose and implement custom HTTP status codes and responses
* Implement action results
* Implement MVC areas
* Implement Dependency Injection for services in controllers

### Design and implement routes

* Define a route to handle a URL pattern
* Apply route constraints
* Ignore URL patterns
* Add custom route parameters
* Define areas
* Define routes that interoperate with Single Page Application frameworks such as Angular

### Control application behavior by using MVC extensibility points

* Create custom middleware and inject it into the pipeline
* implement MVC filters and controller factories
* Control application behavior by using action results, model binders, and route handlers
* Inject services into a view

### Design and implement serialization and model binding

* Serialize models and data using supported serialization formats, including JSON, XML, protobuf, and WCF/SOAP
* Implement model and property binding, including custom binding and model validation
* Implement web socket communication in MVC
* Implement file uploading and multipart data
* Use AutoRest to build clients

## Troubleshoot and Debug Web Applications (20-25%)

### Prevent and troubleshoot runtime issues

* Troubleshoot performance, security, and errors
* Implement tracing, logging, and debugging including IntelliTrace
* Enable and configure health monitoring including Performance Monitor
* Configure and use App Insights runtime telemetry

### Design an exception handling strategy

* Handle exceptions across multiple layers
* Use MVC middleware to configure error handling
* Use different exception handling strategies for different environments
* Create and display custom error pages
* Configure a custom pipeline for error handling
* Handle first chance exceptions
* Configure and use App Insights; log application exceptions

### Test a web application

* Create and run unit tests, for example, use the Assert class, create mocks and stubs;
* Create and run web tests including using Browser Link
* Debug a web application in multiple browsers and mobile emulators
* Use Azure DevTest Labs
* Use Visual Studio Team Services

### Debug an Azure application

* Collect diagnostic information by using Azure App Insights
* Choose log types, for example, event logs, performance counters, and crash dumps
* Stream logs directly to Visual Studio from a deployed site
* Debug an Azure application by using Visual Studio and remote debugging
* Interact directly with remote Azure websites using Server Explorer

## Design and Implement Security (15-20%)

### Configure authentication

* Authenticate users
* Enforce authentication settings
* Implement ASP.NET Core Identity
* Enable Facebook, Google and other external providers
* Implement account confirmation, password recovery, and multi-factor authentication
* Perform authentication using 
    * Azure Active Directory
    * Azure Active Directory B2C
    * Azure Active Directory B2B
    * Microsoft Identity manage user session by using cookies
* Acquire access tokens using the Microsoft Authentication Library (MSAL)

### Configure and apply authorization

* Create roles
* Authorize roles programmatically
* Configure and work with custom UserStores using middleware
* Configure controllers and actions to participate in authorization

### Design and implement claims-based authentication

* Perform authentication and authorization using tokens including 
    * OpenID
    * OAuth
    * JWT
    * SAML
    * Bearer tokens

### Manage data integrity

 * Apply encryption to application data
 * Apply encryption to the configuration sections of an application
 * Sign application data to prevent tampering
 * Secure data using Azure Key Vault
 * Implement encryption for data protection using the data protection APIs in transit and at rest

### Implement a secure site

* Secure communication by applying SSL certificates
* Require SSL for all requests
* Enable SSL hosting in the development environment
* Implement SSL using Azure Load Balancers
* Salt and hash passwords for storage
* Use HTML encoding to prevent cross-site scripting attacks (ANTI-XSS Library)
* Implement deferred validation and handle unvalidated requests, for example, form, querystring, and URL
* Prevent SQL injection attacks by parameterizing queries
* Prevent cross-site request forgeries (XSRF)
* Use Azure Security Center to monitor Azure resources
* Implement Cross Origin Resource Sharing (CORS)
* Implement protection against open redirect attacks