# SqlProvider.Intellisense.ProofOfBug
This is a micro proof of bug for this bug report: https://github.com/dotnet/fsharp/issues/12078

## Preparation
In order to run/reproduce, create a database "DummyDB" in (localdb)\ProjectsV13, and create a single table with:

	CREATE TABLE [dbo]. [DummyTable] (
	[Id] [int] NOT NULL,
	[Name] [nvarchar] (50) NOT NULL,
	CONSTRAINT [PK_DummyTable] PRIMARY KEY (Id)
	)

(If the database has a different name or location, change the connection string in ProjectA.SqlProvider.fs)

## To reproduce
As-is, the solution will (should) build correctly with no errors in Output:Build, however Intellisense will light up ProjectB.Library1.fs, and the Error List.

Just to prove that it is not all Type Providers that are broken, swapping the comments in ProjectA.SqlProvider.fs lines 7 & 8 will demonstrate that the Xml provider works.