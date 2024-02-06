del "*.nupkg"
"..\..\oqtane.framework\oqtane.package\nuget.exe" pack Oqtane.MarketplaceWebhook.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework\Oqtane.Server\Packages\" /Y

