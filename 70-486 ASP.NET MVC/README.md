# Exam 70-486 Developing ASP .NET MVC Web Applications Outline

## Design the application architecture (15-20%)

### [Plan the application layers](http://failedturing.blogspot.com/2014/05/microsoft-70-486-plan-application-layers.html)

* [Plan data access](https://docs.microsoft.com/en-us/dotnet/standard/modern-web-apps-azure-architecture/work-with-data-in-asp-net-core-apps)
* Plan for 
    * [Separation of concerns](https://docs.microsoft.com/en-us/dotnet/standard/modern-web-apps-azure-architecture/architectural-principles#separation-of-concerns)
    * [Appropriate use of models, views, controllers](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.2)
    * [Components](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-2.2)
    * [Service dependency injection](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2)
* [Choose between client-side and server-side processing](https://softwareengineering.stackexchange.com/questions/138561/pros-cons-between-emphasizing-client-side-or-server-side-processing)
* Design for scalability
* [Choose between ASP.NET Core and ASP.NET](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/choose-aspnet-framework?view=aspnetcore-2.2)
* [Choose when to use .NET standard libraries](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)

### [Design a distributed application](http://failedturing.blogspot.com/2014/06/microsoft-70-486-design-distributed.html)

* Design a hybrid application
* [Plan for session management in a distributed environment](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-2.2)
* [Plan web farms](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/web-farm?view=aspnetcore-2.2)
* [Run Microsoft Azure services on-premises with Azure Pack](https://azure.microsoft.com/en-us/resources/videos/microsoft-azure-stack-azure-services-on-premises/)
* Enable deferred processing through Azure features including
    * [Queues](https://docs.microsoft.com/en-us/azure/storage/queues/storage-dotnet-how-to-use-queues)
    * [Scheduled and on-demand jobs](https://docs.microsoft.com/en-us/azure/logic-apps/logic-apps-overview)
    * [Azure Functions](https://docs.microsoft.com/en-us/azure/azure-functions/functions-overview)
    * [Azure Web Jobs](https://docs.microsoft.com/en-us/azure/app-service/webjobs-create)

### [Design and implement the Azure Web Apps life cycle](http://failedturing.blogspot.com/2014/06/microsoft-70-486-design-and-implement.html)

* Identify and implement Start, Run, and Stop events
* Code against application events in applications
* Configure startup tasks, including 
    * IIS
    * App pool configuration
    * Third-party tools

### [Configure state management](http://failedturing.blogspot.com/2014/09/microsoft-70-486-configure-state.html)

* Choose a state management mechanism including 
    * In-process
    * Out of process
    * [Redis-based state management](https://docs.microsoft.com/en-us/azure/azure-cache-for-redis/cache-aspnet-session-state-provider)
* Plan for scalability
* Use cookies or local storage to maintain state
* Apply configuration settings in web.config files
* Implement sessionless state including query strings
* [Configure middleware to enable session and application state in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-2.2#session-state)

### [Design a caching strategy](http://failedturing.blogspot.com/2014/10/microsoft-70-486-design-caching-strategy.html)

* Implement page output caching and data caching
* [Create cache profiles](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/improving-performance-with-output-caching-cs#creating-a-cache-profile)
* Implement HTTP caching
* Implement Azure Redis caching
* [Plan a content delivery network (CDN) strategy, for example, Azure CDN](https://docs.microsoft.com/en-us/azure/cdn/)

### [Design and implement a Web Socket strategy](http://failedturing.blogspot.com/2014/11/microsoft-70-486-design-and-implement.html)

* Read and write string and binary data asynchronously
* Choose a connection loss strategy
* Decide when to use Web Sockets
* Implement SignalR
* [Enable web socket features in an Azure Web App instance](https://azure.microsoft.com/en-us/blog/introduction-to-websockets-on-windows-azure-web-sites/)

### Design a configuration management solution - todo

* Manage configuration sources, including 
    * XML
    * JSON
    * INI files
* Manage environment variables
* Implement Option objects
* Implement multiple environments using files and hierarchical structure
* Manage sensitive configuration
* React to runtime configuration changes
* Implement a custom configuration source
* Secure configuration by using Azure Key Vault
* Use the Secret Manager tool in development to keep secrets out of your code for configuration values

### Interact with the host environment - todo

 * Work with file system using file providers
 * Work with environment variables
 * Determine hosting environment capabilities
 * Implement native components, including PInvoke and native dependencies for hosts including Linux and Windows
 * Use ASP.NET hosting on an Open Web Interface for .NET (OWIN)-based server
* Compose an application by using the framework pipeline
* Add custom request processing modules to the pipeline
* Add, remove, and configure services used in the application
* Design and implement middleware
* Design for kestrel, Http.sys web server and IIS
* Design and implement startup filters

### Preparation resources

* [Entity Framework Development workflows](http://msdn.microsoft.com/en-US/data/jj590134)
* [DataAdapters and DataReaders](http://msdn.microsoft.com/en-us/library/ms254931(v=vs.110).aspx)
* [ASP.NET State Management overview](http://msdn.microsoft.com/en-us/library/75x4ha6s(v=vs.100).aspx)

## Design the build and deployment architecture (10-15%) - todo

### Design a browser artifact build strategy

* Design a JavaScript build pipeline using 
    * [Gulp](https://gulpjs.com/docs/en/getting-started/quick-start)
    * [Grunt](https://gruntjs.com/getting-started)
    * [npm](https://docs.microsoft.com/en-us/azure/devops/pipelines/ecosystems/javascript?view=azure-devops)
    * [Bower](https://bower.io/)
* Design an artifact build strategy using 
    * [Less](http://lesscss.org/)
    * [Sass](https://sass-lang.com/guide)
    * [Font Awesome](https://fontawesome.com/start)
* [Design and implement a bundling and minification strategy for browser artifacts, including JavaScript, CSS and images](https://docs.microsoft.com/en-us/aspnet/mvc/overview/performance/bundling-and-minification)

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

### Preparation resources

* [Developing with .NET on Microsoft Azure](https://www.pluralsight.com/courses/developing-dotnet-microsoft-azure-getting-started?aid=7010a000001xH0EAAU&promo=&oid=&utm_source=&utm_medium=partner_partner_web_referral&utm_campaign=&utm_content=&utm_term=)
* [Building your CI/CD pipeline](https://channel9.msdn.com/Events/dotnetConf/2017/T323/)
* [Developing ASP.NET MVC 5 Web Applications](https://www.microsoft.com/en-us/learning/course.aspx?cid=20486)

## Design the User Experience (15-20%)

### [Create elements of the user interface for a web application](http://failedturing.blogspot.com/2015/01/microsoft-70-486-apply-user-interface.html)

* Create and apply styles by using CSS
* Structure and lay out the user interface by using HTML
* Implement dynamic page content based on a design

### [Design and implement UI behavior](http://failedturing.blogspot.com/2015/01/microsoft-70-486-design-and-implement.html)

* Implement client-side validation
* Use JavaScript to manipulate the DOM
* Extend objects by using prototypal inheritance
* Use AJAX to make partial page updates

### [Design the UI layout of an application](http://failedturing.blogspot.com/2015/02/microsoft-70-486-compose-ui-layout-of.html)

* Implement partial views and view components for reuse in different areas of the application
* Design and implement pages by using Razor Pages
* Design and implement layouts to provide visual structure
* Define and render optional and required page sections
* [Create and use tag and HTML helpers to simplify markup](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro?view=aspnetcore-2.2)

### [Plan a responsive UI layout](http://failedturing.blogspot.com/2015/01/microsoft-70-486-enhance-application.html) 

* Plan for applications that run on multiple devices and screen resolutions
* Use media queries and Bootstrap’s responsive grid - todo
* Detect browser features and capabilities
* Create a web application that runs across multiple browsers and mobile devices
* Enable consistent cross-browser experiences with polyfills - todo

### [Plan mobile UI strategy](http://failedturing.blogspot.com/2015/01/microsoft-70-486-plan-adaptive-ui-layout.html)

* Implement mobile specific UI elements such as touch input, low bandwidth situations, and device oritentation changes
* Define and implement a strategy for working with mobile browsers

### Preparation resources

* [Build a better mobile browsing experience](http://msdn.microsoft.com/en-us/magazine/hh288079.aspx)
* [Display modes](http://www.asp.net/whitepapers/mvc4-release-notes#_Toc303253810)
* [Building Modern Web Apps Jump Start](https://mva.microsoft.com/training-courses/building-modern-web-apps-jump-start)

## Develop the User Experience (15-20%)

### [Plan for search engine optimization and accessibility](http://failedturing.blogspot.com/2015/03/microsoft-70-486-plan-for-search-engine.html)

* Use analytical tools to parse HTML
* Provide an xml sitemap and robots.txt file to improve scraping - todo
* Write semantic markup for accessibility, for example, screen readers
* Use rich snippets to increase content visibility - todo

### [Plan and implement globalization and localization](http://failedturing.blogspot.com/2016/03/microsoft-70-486-plan-and-implement.html)

* Plan a localization strategy
* Create and apply resources to UI including JavaScript resources
* Set cultures
* Implement server side localization and globalization - todo

### [Design and implement MVC controllers and actions](http://failedturing.blogspot.com/2015/04/microsoft-70-486-design-and-implement.html)

* Apply authorization attributes
* Filters including 
    * Global
    * Authentication
    * Overriddable filters
* Choose and implement custom HTTP status codes and responses - todo
* Implement action results
* Implement MVC areas - todo
* Implement Dependency Injection for services in controllers - todo

### [Design and implement routes](http://failedturing.blogspot.com/2015/12/microsoft-70-486-design-and-implement.html)

* Define a route to handle a URL pattern
* Apply route constraints
* Ignore URL patterns
* Add custom route parameters
* Define areas
* Define routes that interoperate with Single Page Application frameworks such as Angular - todo

### [Control application behavior by using MVC extensibility points](http://failedturing.blogspot.com/2015/12/microsoft-70-486-control-application.html)

* Create custom middleware and inject it into the pipeline - todo
* Implement MVC filters and controller factories
* Control application behavior by using action results, model binders, and route handlers
* Inject services into a view - todo

### Design and implement serialization and model binding - todo

* Serialize models and data using supported serialization formats, including JSON, XML, protobuf, and WCF/SOAP
* Implement model and property binding, including custom binding and model validation
* Implement web socket communication in MVC
* Implement file uploading and multipart data
* Use AutoRest to build clients

### Preparation resources

* [Search Engine Optimization Toolkit](http://www.iis.net/downloads/microsoft/search-engine-optimization-toolkit)
* [GlobalizationSection Class](http://msdn.microsoft.com/en-us/library/system.web.configuration.globalizationsection.aspx)
* [FormCollection Class](http://msdn.microsoft.com/en-us/library/system.web.mvc.formcollection(v=vs.118).aspx)

## Troubleshoot and Debug Web Applications (20-25%)

### [Prevent and troubleshoot runtime issues](http://failedturing.blogspot.com/2016/03/microsoft-70-486-prevent-and.html)

* Troubleshoot performance, security, and errors
* Implement tracing, logging, and debugging including IntelliTrace
* Enable and configure health monitoring including Performance Monitor
* [Configure and use App Insights runtime telemetry](https://docs.microsoft.com/en-us/azure/azure-monitor/app/asp-net)

### [Design an exception handling strategy](http://failedturing.blogspot.com/2016/03/microsoft-70-486-design-exception.html)

* Handle exceptions across multiple layers
* [Use MVC middleware to configure error handling](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-2.2)
* Use different exception handling strategies for different environments - todo
* Create and display custom error pages
* Configure a custom pipeline for error handling - todo
* Handle first chance exceptions
* Configure and use App Insights - todo
* Log application exceptions - todo

### [Test a web application](http://failedturing.blogspot.com/2016/01/microsoft-70-486-test-web-application.html)

* Create and run unit tests, for example, use the Assert class
* Create mocks and stubs
* Create and run web tests including using Browser Link
* Debug a web application in multiple browsers and mobile emulators
* [Use Azure DevTest Labs](https://docs.microsoft.com/en-us/azure/lab-services/devtest-lab-overview)
* [Use Visual Studio Team Services](https://docs.microsoft.com/en-us/azure/devops/test/run-automated-tests-from-test-hub?view=azure-devops)

### [Debug an Azure application](http://failedturing.blogspot.com/2016/02/microsoft-70-486-debug-azure-application.html)

* Collect diagnostic information by using Azure App Insights - todo
* Choose log types, for example, event logs, performance counters, and crash dumps
* Stream logs directly to Visual Studio from a deployed site - todo
* Debug an Azure application by using Visual Studio and remote debugging - todo
* Interact directly with remote Azure websites using Server Explorer - todo

### Preparation resources

* [Using shims to isolate your application from other assemblies for unit testing](http://msdn.microsoft.com/en-us/library/hh549176(v=vs.120).aspx)

## Design and Implement Security (15-20%) - todo

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

### Preparation resources

* [Introduction to ASP.NET Identity](http://www.asp.net/identity/overview/getting-started/introduction-to-aspnet-identity)
* [Chapter 5: Authentication, authorization, and identities in WCF](http://msdn.microsoft.com/en-us/library/ff647503.aspx)
* [Easy Web App Integration with Windows Azure Active Directory, ASP.NET & Visual Studio](http://blogs.technet.com/b/ad/archive/2013/06/26/improved-windows-azure-active-directory-integration-with-asp-net-amp-visual-studio.aspx)

## Other Resources
* [Professional ASP.NET MVC 5](http://www.cs.unsyiah.ac.id/~frdaus/PenelusuranInformasi/File-Pdf/Professional%20ASP.NET%20MVC%205.pdf)
