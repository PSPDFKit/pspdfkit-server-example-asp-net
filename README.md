# PSPDFKit Server Example – ASP.NET

This example shows how to integrate [PSPDFKit for Web](https://pspdfkit.com/web/) into an ASP.NET back end app.

This example demonstrates both Standalone and Server backend.

## Prerequisites

- Visual Studio 2017 or 2019.
- A PSPDFKit for Web license. If you don't already have one
  you can [request a free trial here](https://pspdfkit.com/try/).

## Getting Started

Once the project is opened in Visual Studio right click on "References" in the Solution Explorer and click on "Manage NuGet Packages".
If Visual Studio informs you that some packages are missing then click on the "Restore" on the right.

## Standalone

After you have requested a trial and downloaded PSPDFKit for Web, place the contents of the `dist` directory in `\ExampleMVC\Content\pspdfkit\`.

Then place your trial key in `\ExampleMVC\Views\Home\StandaloneExample.cshtml` where it says `YOUR LICENSE KEY HERE`.

You can then build and run the example.

## Server

The Standalone example does not require a running PSPDFKit Server but the Server example does.

Follow the [guide here](https://pspdfkit.com/guides/web/current/server-backed/setting-up-pspdfkit-server/) to set up a running PSPDFKit Server.

Change the server address in `ExampleMVC\Views\Shared\_Layout.cshtml` to the address of your PSPDFKit server.

Once you have a running server you will need to generate a JWT and place it in `\ExampleMVC\Views\Home\Index.cshtml`.

Read [this guide](https://pspdfkit.com/guides/web/current/server-backed/client-authentication/) for more information on this topic.

Upload a document to the server if you haven't already. Get the document id and set it in `\ExampleMVC\Views\Home\Index.cshtml`.

Build the solution and click on the green play icon in the toolbar starting the app and the index page will open in the browser you have specified to launch with.

## License

This software is licensed under a [modified BSD license](LICENSE).

## Contributing

Please ensure
[you have signed our CLA](https://pspdfkit.com/guides/web/current/miscellaneous/contributing/) so that we can
accept your contributions.
