module ProjectA.Sql

open FSharp.Data.TypeProviders

let [<Literal>] CONNECTION_STRING = @"Server=(localdb)\ProjectsV13; Initial Catalog=DummyDB; Integrated Security=True; MultipleActiveResultSets=true"

//type DataConnection = float //<- this works in Intellisense in ProjectB, the line below doesn't
type DataConnection = SqlDataConnection<CONNECTION_STRING>