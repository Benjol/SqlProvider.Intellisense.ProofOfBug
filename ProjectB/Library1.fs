namespace ProjectB
open ProjectA //<-- Intellisense says "namespace not defined" as long as ProjectA.SqlProvider.fs contains reference to SqlDataProvider

module Dibble =

    // if [type DataConnection = float] in ProjectA, following two lines work (so *Xml*Provider works)
    let y = Xml.Author.Parse("""<author name="Karl Popper" born="1902" />""")
    let z = y.Born

    // if [type DataConnection = SqlDataConnection<CONNECTION_STRING>] in ProjectA, this won't work
    let w = Sql.DataConnection.ServiceTypes.DummyTable()