Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Hosting

Module Program

    Sub Main(args As String())
        Dim builder = CreateHostBuilder(args)

        'Config here

        builder.Build().Run()
    End Sub

    Public Function CreateHostBuilder(args() As String) As IHostBuilder
        Return Host.CreateDefaultBuilder(args).
                ConfigureWebHostDefaults(Sub(webBuilder) webBuilder.UseStartup(Of Startup)())
    End Function

End Module