# Specflow3 + MsTest

> Documentation for reference in future with the setups to integrate Specflow 3 with MSTest.

**Libraries Used**

	- MsTest
	- Specflow (version 3)
	- Microsoft.NetCore.App

**Build & Execute**

	-  Restore the NuGet Packages using the MsBuild.exe shipped with VS 2019 Community Edition. Navigate to the folder containing the MSBuild.exe
		
		```shell
		cd C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin
		```
	
	- Restore the nuget packages
	
		```shell
		MSBuild.exe <path of the csproj file> -t:restore
		```
	- Build the project 

		```shell
		MSBuild.exe <path of the csproj file>
		```

	- It's time to execute the tests now.

		```shell
		dotnet test <path to project dll> --filter TestCategory=<tag(if any)>
		```

**Execution Report**
	
	-Reporting has been removed in Specflow version 3 onwards 
	
			- Issue `https://github.com/SpecFlowOSS/SpecFlow/issues/1036`
			- Specflow `https://specflow.org/documentation/Reporting/`
	
	
	